using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_bdd_2022
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion test = new Gestion("192.168.2.2", "sk_reto", "sk_reto", "login");
            Interfaces inter = new Interfaces();

            
            string userid = textBox_user.Text;
            string mdp = textBox_mdp.Text;

            if (textBox_mdp.Text == "")
            {
                MessageBox.Show("Entrez votre nom d'utilisateur");
            }
            else if (textBox_mdp.Text == "")
            {
                MessageBox.Show("Entrez votre mot de passe");
            }

            else if (test.Open())
            {

                test.Connect(userid, mdp);
                this.Hide();
            
            }
            else
            {
                test.Close();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            if (textBox_mdp.PasswordChar == '*')
            {
                button_not_view.BringToFront();
                textBox_mdp.PasswordChar = '\0';
            }
        }

        private void button_not_view_Click(object sender, EventArgs e)
        {
            if (textBox_mdp.PasswordChar == '\0')
            {
                button_view.BringToFront();
                textBox_mdp.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
