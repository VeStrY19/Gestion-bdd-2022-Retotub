using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace galvex {

    public partial class Data_Form : Form {

        public Data_Form() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            timer_actu.Interval = 30000;
            timer_actu.Enabled = true;
            charge_base(this.synopticDataSet, e);
            }

        //quitter l'application
        private void btn_quit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //ajouter une ligne depuis la deuxième fenetre
        private void btn_add_Click(object sender, EventArgs e) {
            timer_actu.Enabled = false;
            var new_row = synopticDataSet.galvex_conditionnement.Newgalvex_conditionnementRow();

            using (var form = new Insert_Form(ref new_row, ref synopticDataSet)) {
                
                if (form.ShowDialog(this) == DialogResult.OK && !form.current_row.IsNull("IDZONE")) {
                    synopticDataSet.galvex_conditionnement.Rows.Add(form.current_row);
                    this.galvex_conditionnementTableAdapter.Update(this.synopticDataSet.galvex_conditionnement);
                    this.galvex_conditionnementTableAdapter.Fill(this.synopticDataSet.galvex_conditionnement);
                    synopticDataSet.AcceptChanges();
                    aff_nblz1();
                }
            }
            timer_actu.Enabled = true;
        }

        //supprimer une ligne selectionner
        private void btn_delete_Click(object sender, EventArgs e) {
            timer_actu.Enabled = false;
            var result = MessageBox.Show(this, "Êtes-vous sûr de vouloir supprimer la ligne ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes) {
                foreach (DataGridViewRow r in this.dataGridView_conditionnement.SelectedRows) {
                    this.synopticDataSet.galvex_conditionnement.FindByID((int)r.Cells["ID_CDT"].Value).Delete();
                }
                galvex_conditionnementTableAdapter.Update(this.synopticDataSet.galvex_conditionnement);
                synopticDataSet.AcceptChanges();
                aff_nblz1();

            }
            timer_actu.Enabled = true;
        }

        //parcourir datagridview et afficher le nombre de ligne et les poids
        private void aff_nblz1() {
            foreach (DataGridViewRow zone in dataGridView_zone.Rows)
            {
                decimal pds_total = 0;
                decimal nb_lignes = 0;
                decimal pds_galva = 0;
                decimal pds_lim = 0;
                decimal p = 1.06M;

                foreach (DataGridViewRow conditionnement in dataGridView_conditionnement.Rows)
                {
                    if ((string)conditionnement.Cells["IDZONE_CDT"].Value == (string)zone.Cells["IDZONE_ZONE"].Value)
                    {
                        if (conditionnement.Cells["ID_CDT"].Value != null)
                        {
                            decimal pds_cdt = Convert.ToDecimal(conditionnement.Cells["POIDS_CDT"].Value);
                            decimal pds_panier = Convert.ToDecimal(conditionnement.Cells["POIDS_PANIER_CDT"].Value);
                            pds_total += pds_cdt + pds_panier;
                            pds_galva += pds_cdt;
                            nb_lignes++;
                            pds_lim = pds_total;
                            pds_lim = decimal.Multiply(pds_lim, p);
                        }
                        
                    }
                }
                //afficher le contenue des zones en temps réel
                zone.Cells["PDS_TOTAL"].Value = pds_total;
                zone.Cells["NB_LIGNES"].Value = nb_lignes;
                zone.Cells["PDS_GALVA"].Value = pds_galva;
                if(pds_lim > 24500.0M)
                {
                    //rouge si la zone est pleine
                    zone.Cells["PDS_TOTAL"].Style.BackColor = Color.Red;
                    zone.Cells["FLAG_PDS"].Value = true;
                    MessageBox.Show(this,string.Format("Attention vous dépasser le poids maximum autorisé sur la zone : {0}", zone.Cells["IDZONE_ZONE"].Value), "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                {
                    //vert si on peut encore chagrer  la zone
                    zone.Cells["PDS_TOTAL"].Style.BackColor = Color.GreenYellow;
                    zone.Cells["FLAG_PDS"].Value = false;
                }
            }
        }

        //modifier la ligne sélectionner
        private void btn_mod_Click(object sender, EventArgs e) {
            timer_actu.Enabled = false;
            DataRowView myrowview = dataGridView_conditionnement.CurrentRow.DataBoundItem as DataRowView;
            synopticDataSet.galvex_conditionnementRow myrow = myrowview.Row as synopticDataSet.galvex_conditionnementRow;

            using (var form = new Insert_Form(ref myrow, ref synopticDataSet))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.galvex_conditionnementTableAdapter.Update(this.synopticDataSet.galvex_conditionnement);
                    synopticDataSet.AcceptChanges();
                    aff_nblz1();
                }
            }
            timer_actu.Enabled = true;
        }

        private void timer_actu_Tick(object sender, EventArgs e) {
            synopticDataSet.Clear();
            charge_base(synopticDataSet, e);
        }

        private void charge_base(object sender, EventArgs e) {
            // TODO: cette ligne de code charge les données dans la table 'synopticDataSet.galvex_zone'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.galvex_zoneTableAdapter.Fill(this.synopticDataSet.galvex_zone);
            // TODO: cette ligne de code charge les données dans la table 'synopticDataSet.galvex_conditionnement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.galvex_conditionnementTableAdapter.Fill(this.synopticDataSet.galvex_conditionnement);

            using (MySqlDataAdapter da = new MySqlDataAdapter())
            {
                da.SelectCommand = this.galvex_zoneTableAdapter.Connection.CreateCommand();
                da.SelectCommand.CommandText = "select * from lancement where solde_fab = 'N'";
                da.Fill(synopticDataSet.lancement);
            }

            using (MySqlDataAdapter da = new MySqlDataAdapter())
            {
                da.SelectCommand = this.galvex_zoneTableAdapter.Connection.CreateCommand();
                da.SelectCommand.CommandText = "select * from article2 ";
                da.Fill(synopticDataSet.article2);
            }

            aff_nblz1();
        }
    }

}
