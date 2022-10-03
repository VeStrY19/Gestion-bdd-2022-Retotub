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
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }
        string picPath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files(*png)|*.png|JPG Files (*.jpg)|*.jpg|All files(*.*)|*.*";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPath = ofd.FileName.ToString();
                textBox_id.Text = picPath;
                pictureBox.ImageLocation = picPath;
                File.ReadAllText(picPath);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Interfaces inter = new Interfaces();
            this.Hide();
            inter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            
            string querry = $"INSERT INTO `saveimg` (`img_id`, `imgname`, `imgtype`, `imgpath`) VALUES (NULL, '{name}', 'JPG', '{pictureBox}');";

            MySqlConnection cnn = new MySqlConnection("datasource=192.168.2.2;port=3306;database=login;username=sk_reto;password=sk_reto");
            cnn.Open();
            string path = pictureBox.Name;
            byte[] imageBytes = File.ReadAllBytes(picPath);

            MySqlCommand cmd = new MySqlCommand($"INSERT INTO `saveimg` (`img_id`, `imgname`, `imgtype`, `imgpath`) VALUES (NULL, '{name}', 'JPG', (@data))", cnn);
            cmd.Parameters.AddWithValue("@data", imageBytes);

            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
