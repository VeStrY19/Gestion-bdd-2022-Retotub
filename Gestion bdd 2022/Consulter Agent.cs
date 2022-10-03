using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_bdd_2022
{
    public partial class Consulter_Agent : Form
    {
        Gestion gestion = new Gestion("192.168.43.58", "resp", "pass", "login");
        public Consulter_Agent()
        {
            InitializeComponent();
        }

        private void Consulter_Agent_Load(object sender, EventArgs e)
        {
  
        }

        private void button_print_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection gest = new MySqlConnection("datasource=192.168.2.2;port=3306;database=login;username=sk_reto;password=sk_reto");
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM gestion", gest);


                gest.Open();

                DataSet ds = new DataSet();
                da.Fill(ds, "gestion");

                dataGridView1.DataSource = ds.Tables["gestion"];
                gest.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            try
            {
                gestion.Open();
                gestion.Delete(idd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                gestion.Close();
            }


        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string nom = textBox_nom.Text;
            string prenom = textBox_prenom.Text;
            string user = textBox_user.Text;
            string mdp = textBox_mdp.Text;

            MySqlConnection cnn = new MySqlConnection("datasource=192.168.2.2;port=3306;database=login;username=sk_reto;password=sk_reto");
            //MySqlCommand cmdd = new MySqlCommand($"SELECT id FROM gestion WHERE id  = '{textBox_id}'", cnn);
            MySqlCommand cmd = new MySqlCommand($"UPDATE `gestion` SET nom='{nom}', prenom='{prenom}', username='{user}', mdp='{mdp}' WHERE id = '{int.Parse(id)}'", cnn);
            MySqlCommand cmd_name = new MySqlCommand($"UPDATE gestion SET nom = '{nom}'",cnn);
            
            
            try
            {
                cnn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Modification réussi");
            }
            catch (MySqlException ex)
            {
                cnn.Close();
                MessageBox.Show(ex.Message);

            }


        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_prenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_user.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_mdp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interfaces inter = new Interfaces();
            this.Hide();
            inter.Show();
        }
    }
}