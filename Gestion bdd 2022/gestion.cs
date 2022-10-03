/*.................................*/
/* */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;




namespace Gestion_bdd_2022
{
    public class Gestion
    { 
        private MySqlConnection Connection { get; }

        public Gestion(string server, string user, string pwd, string database, ushort port = 3306)
        { 
            var b = new StringBuilder();
            b.Append($"Server={server};Port={port};Uid={user};Pwd={pwd};");

            if (database != null && database.Length > 0)
            {
                b.Append($"Database={database};");
            }

            Connection = new MySqlConnection(b.ToString());
        }

        //-----------------------------------------------//
        // Fonction Ouvert Connecion                     //
        //-----------------------------------------------//
        // Description : Ouvre la connexion et retourne  //
        //              l'état de la connexion           //
        //-----------------------------------------------//
        public bool Open()
        {
            Connection.Open(); //Ouvre la connexion
            return Connection.State == ConnectionState.Open; // retourne l'état de la connexion
        }

        //-----------------------------------------------//
        // Fonction Fermé  Connecion                     //
        //-----------------------------------------------//
        // Description : Ferme la connexion              //
        //-----------------------------------------------//
        public void Close()
        {
            Connection.Close();
        }

        //-----------------------------------------------//
        // Fonction Insertion gestion compte             //
        //-----------------------------------------------//
        // Description : Insert le nom, premnom, le nom   //
        //              d'utilisateur et le mot de passe //
        //              dans la base de données          //
        //-----------------------------------------------//
        public void Insert(string nom, string prenom, string username, string mdp)
        {

            var cmd = this.Connection.CreateCommand(); // Permet de crée une commande 
            // Requête SQL que l'on vas passer à la variable cmd
            cmd.CommandText = $"INSERT INTO `gestion` (`id`, `nom`, `prenom`, `username`, `mdp`) VALUES (NULL, '{nom}', '{prenom}', '{username}', '{mdp}');";
            
            Connexion conn = new Connexion(); // Instancication de l'interface Connexion
            
            // On essaie de éxécuter la requête, et si l'insertion à echouer on envoie un MessageBox d'érreur, sinon il nous ouvre l'interface Connexion du compte
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Compte crée avec succès !!!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //-----------------------------------------------//
        // DFonction Suppression d'un utilisateur        //
        //-----------------------------------------------//
        // Description : Supprime la ligne dans laquelle //
        //                un utilisateur est inscrit     //
        //                dans la base de données        //
        //-----------------------------------------------//
        public void Delete(int id)
        {
            //string query = $"DELETE * FROM gestion WHERE 0";
            var cmd = this.Connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM `gestion` WHERE id  = '{id}'";

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //-----------------------------------------------//
        // Fonction Seesion Connexion                    //
        //-----------------------------------------------//
        // Description : Ouvre une sesion de connexion   //
        //               en entrant le nom d'utilisateur //
        //               et mot de passe                 //
        //-----------------------------------------------//
        public bool Connect(string userid, string mdp)
        {
            // Requête SQL SELECT
            MySqlCommand cmd = new MySqlCommand($"SELECT id, username, mdp FROM `gestion` WHERE username = '{userid}' AND mdp = '{mdp}' ", Connection);

            MySqlDataReader dr; // Variable DataReader
            dr = cmd.ExecuteReader(); // Affecte dr à éxécution la variable cmd
            
            //Session de connexion, si la session est ouverte dans ce cas on ouvre une nouvelle l'interface sinon on envoie un message d'erreur
            if (dr.Read())
            {
                dr.Close();

                Interfaces inter = new Interfaces();
                Connexion con = new Connexion();
                MessageBox.Show("Login Sucessfull !!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.Hide();
                //inter.Show();

                inter.Show();
            }
            else
            {
                dr.Close();

                MessageBox.Show("Username or password incorrect !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public void Update_agent(string name, string prenom, string username, string passwd)
        {
            var cmd = this.Connection.CreateCommand();
            cmd.CommandText = $"UPDATE `gestion` SET `nom`= '{name}', `prenom`= '{prenom}', `username`= '{username}' ,`mdp`= '{passwd}' WHERE 1";

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
