using System;
using System.Data;
using System.Windows.Forms;

namespace galvex {

    public partial class Insert_Form : Form {
        private decimal poids_u =0; 
        public Insert_Form(ref synopticDataSet.galvex_conditionnementRow new_row, ref synopticDataSet ds) {
            InitializeComponent();
            myDS = ds;
            current_row = new_row;
            fill_combo_zone();
            affiche_current_row();
        }

        public synopticDataSet.galvex_conditionnementRow current_row;
        private synopticDataSet myDS;

        private void affiche_current_row() {
            //on affiche dans la fenêtre le contenu de la currentrow
            try
            { txt_OF.Text = current_row.NOOF; }
            catch { txt_OF.Text = ""; }

            try
            { Combox_zone.SelectedItem = current_row.IDZONE; }
            catch { Combox_zone.Text = ""; }

            try
            { numericbox_qte.Value = current_row.QTE; }
            catch { numericbox_qte.Value = 0; }

            try
            { txt_pan.Text = current_row.NUM_PANIER; }
            catch { txt_pan.Text = ""; }

            try
            { check_galv_pan.Checked = current_row.GALVAP; }
            catch { check_galv_pan.Checked = false; }

            try
            { numericbox_pds_pan.Value = current_row.POIDS_PANIER; }
            catch { numericbox_pds_pan.Value = 0; }

            try
            { txt_com.Text = current_row.COMMENTAIRE; }
            catch { txt_com.Text = ""; }
            try
            {
                numericbox_pds_tot.Value = current_row.POIDS + current_row.POIDS_PANIER;
            }
            catch
            {
                numericbox_pds_tot.Value = 0;
            }
            
        }

        //annuler la saisie et fermer la fenetre
        private void btn_cancel(object sender, EventArgs e) {
            var result = MessageBox.Show(this, "Êtes-vous sûr de vouloir annuler la saisie ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            { Close(); }
        }

        private void btn_ok_Click(object sender, EventArgs e) {

            bool saisie_valide = true;
            //mise à jour de la currentrow avec les informations saisies
            // Check si la zone est correctement sélectionné avant soumission de la saisie
            if (this.Combox_zone.Text == "")
            {
                MessageBox.Show(this, "Zone non sélectionné", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saisie_valide = false;
            } else
            {
                synopticDataSet.galvex_zoneRow row_zone = myDS.galvex_zone.FindByIDZONE((string)Combox_zone.Text);
                if (row_zone != null)
                {
                    if (row_zone.FLAG_PDS == true)
                    {
                        MessageBox.Show(string.Format("Vous ne pouvez pas ajouter de ligne sur {0} car le poids maximum est dépassé.", Combox_zone.Text), "Erreur poids max atteint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        saisie_valide = false;
                    }
                }
                current_row.IDZONE = Combox_zone.Text.Trim();
            }


            //check si l'OF est bien saisie
            if (!this.txt_OF.Text.StartsWith("OF") || this.txt_OF.Text.Length != 8)
            {
                MessageBox.Show(this, "Votre numéro d'OF est invalide", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saisie_valide = false;
            } else
                current_row.NOOF = txt_OF.Text.Trim();
            this.txt_OF.Clear();

            //check si la quantité est bien saisie
            if (this.numericbox_qte.Value == 0)
            {
                MessageBox.Show(this, "Vérifier le nombre de produits", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saisie_valide = false;
            } else
                current_row.QTE = (uint)numericbox_qte.Value;

            //check si le poids est bien saisie
            if (this.numericbox_pds_tot.Value == 0)
            {
                MessageBox.Show(this, "Vérifier le poids de produits", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saisie_valide = false;
            } else
                current_row.POIDS = Convert.ToUInt32(this.txt_pds_prod.Text);
            
                

            //ajouter un numero de pan 
            if (txt_pan.Text.Length > 0)
            {
                current_row.NUM_PANIER = txt_pan.Text.Trim();
            }

            current_row.GALVAP = check_galv_pan.Checked;
            current_row.POIDS_PANIER = (uint)numericbox_pds_pan.Value;
            current_row.DATE_SAISIE = DateTime.Now;
            current_row.COMMENTAIRE = txt_com.Text.Trim();
            current_row.ARTICLE = txt_article.Text;

            if (saisie_valide)
            {
                this.DialogResult = DialogResult.OK;

            }

        }

        private void read_article(object sender, EventArgs e) {
            //On s'assure que le numéro de l'OF a le bon format avant de chercher dans la base
            if (txt_OF.Text.StartsWith("OF") || (txt_OF.Text.Length == 8))
            {
                //On recherche dans la table lancement la ligne correspondant à l'OF
                DataRow[] result = myDS.lancement.Select(string.Format("NOOF = '{0}'", txt_OF.Text));
                {
                    if (result.Length > 0)
                    {
                        //on a trouvé un ligne
                        synopticDataSet.lancementRow myRow;
                        //on ramene la ligne typé du dataset et on affiche le resultat
                        myRow = myDS.lancement.FindByPOST_FAB((string)result[0]["POST_FAB"]);
                        txt_article.Text = myRow.ARTICLE;
                        synopticDataSet.article2Row myArticle;
                        myArticle = myRow.Getarticle2Rows()[0];
                        txt_code2.Text = myArticle.CODE2;
                        txt_Desigart.Text = myArticle.DESIGART;
                        poids_u = myArticle.POIDS_UNITAIRE;
                    } else
                    {
                        //s'il n'y a pas de résultat, on efface les champs article
                        txt_article.Text = "";
                        txt_code2.Text = "";
                        txt_Desigart.Text = "";
                    }
                }
            }
        }

        //afficher toutes les zones présentes dans la bdd dans la grille
        private void fill_combo_zone() {
            Combox_zone.Items.Clear();
            foreach (synopticDataSet.galvex_zoneRow z in myDS.galvex_zone.Rows)
            {
                Combox_zone.Items.Add(z.IDZONE);
            }
        }


        //saisir automatiquement 'OF' si l'utilisateur ne saisie que des chiffres
        private void txt_OF_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_OF.Text.Length == 6)
                {
                    txt_OF.Text = "OF" + txt_OF.Text;
                }
            }
        }

        //calculer poids total saisie
        private void calc_pds_tot() {
            decimal resultat = 0;
            resultat = numericbox_pds_tot.Value - numericbox_pds_pan.Value;
            txt_pds_prod.Text = resultat.ToString();

        }

        private void numericbox_pds_pan_ValueChanged(object sender, EventArgs e) {
            txt_pds_prod.Enabled = true;
            calc_pds_tot();
        }

        private void numericbox_pds_tot_ValueChanged(object sender, EventArgs e) {
            txt_pds_prod.Enabled = true;
            calc_pds_tot();
        }

        private void numericbox_qte_ValueChanged(object sender, EventArgs e) {
            decimal poids_th = 0;
            decimal qte = numericbox_qte.Value;
            poids_th = poids_u * qte;
            txt_pds_u.Text = poids_th.ToString("0");
        }
    }

}
