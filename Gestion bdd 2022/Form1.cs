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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Gestion test = new Gestion("192.168.2.2", "sk_reto", "sk_reto", "login");
            Connexion conn = new Connexion(); 
               string nom = textBox_nom.Text.Trim();
               string prenom = textBox_prenom.Text.Trim();
               string userid = textBox_userid.Text;
            
            
            textBox_mdp.PasswordChar = '*';
            textBox_mdp.PasswordChar = '\0';
            string mdp = textBox_mdp.Text;

            if (nom == "")
            {
                MessageBox.Show("Entrez un nom");
            }
            else if (prenom == "")
            {
                MessageBox.Show("Entrez un prenom");
            }
            else if (userid == "")
            {
                MessageBox.Show("Entrez un nom d'utilisateur");
            }
            else if (mdp == "")
            {
                MessageBox.Show("Entrez un mot de passe");
            }
            else if (test.Open())
            {
                test.Insert(nom, prenom, userid, mdp); 
               
                this.Hide();
                conn.Show();
            
            }
            else
            {
                test.Close(); 
            } 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connexion conn = new Connexion();
            conn.Show();
            this.Hide();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            if(textBox_mdp.PasswordChar == '*')
            {
                button_not_view.BringToFront();
                textBox_mdp.PasswordChar = '\0';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox_mdp.PasswordChar == '\0')
            {
                button_view.BringToFront();
                textBox_mdp.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
