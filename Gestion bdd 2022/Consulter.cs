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
using System.IO;


namespace Gestion_bdd_2022
{
    public partial class Consulter : Form
    {


        

        public Consulter()
        {
            InitializeComponent();
        }

        private void Consulter_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            
            string id = textBox_id.Text;
            
            //Connexion à la base de donnée
            MySqlConnection cnn = new MySqlConnection("datasource=192.168.2.2;port=3306;database=login;username=sk_reto;password=sk_reto"); 
            
            cnn.Open(); //Ouverture à la base de donnée
            var cmd = new MySqlCommand($"SELECT imgpath FROM saveimg WHERE img_id = '{id}'",cnn); //Requêts SQL

            byte[] image = null;
            using (MySqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                    image = (byte[])reader["imgpath"];
            if (image != null)
                pictureBox.Image = ByteArrayToImage(image);

        }

        //Conversion de l'image .bin en jpg
        private Image ByteArrayToImage(byte[] bytes)
        {
            //Lie les donnée de l'mage.bin
            using(MemoryStream ms = new MemoryStream(bytes))
            {
                //Retourne en l'image de base
                return Image.FromStream(ms);
            }
        }


        private int index = 0;

        private void button_next_Click(object sender, EventArgs e)
        {
           
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Interfaces inter = new Interfaces();
            this.Hide();
            inter.Show();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
         
        }
    }
}
