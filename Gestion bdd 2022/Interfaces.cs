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
    public partial class Interfaces : Form
    {
        public Interfaces()
        {
            InitializeComponent();
        }

        private void Interfaces_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajout ajout = new Ajout();
            this.Hide();
            ajout.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulter consulter = new Consulter();
            this.Hide();
            consulter.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consulter_Agent agent = new Consulter_Agent();
            this.Hide();
            agent.Show();
        }
    }
}
