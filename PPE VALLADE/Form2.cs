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
using Dapper;

namespace PPE_Vallade
{
    public partial class Form2 : Form
    {
        Client unAutreClient;
        public static string connectionstring = "Server=127.0.0.1;Database=Sucrerie;Uid=root;Pwd='';";
       public static object IdClients;
        public Form2()
        {
            
            InitializeComponent();

           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void fill_txbox(object unClient)
        {

            unAutreClient = (Client)unClient;
            textBox_Nom.Text = unAutreClient.nom;
            textBox_telephone.Text = unAutreClient.telephone;
            textBox_Adresse.Text = unAutreClient.Adresse;
            textBox_Codepostal.Text = unAutreClient.cp;
            textBox_Ville.Text = unAutreClient.ville;

          
        }

        public void save()
        {
              unAutreClient.nom = textBox_Nom.Text;
              unAutreClient.telephone = textBox_telephone.Text;
              unAutreClient.Adresse = textBox_Adresse.Text;
              unAutreClient.cp = textBox_Codepostal.Text;
              unAutreClient.ville = textBox_Ville.Text;
            
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            string StrQueryString;

            var connection = new MySqlConnection(connectionstring);
            connection.Open();

            save();
            
            StrQueryString = "UPDATE Client set nom = '" + unAutreClient.nom + "', adresse = '" + unAutreClient.Adresse
                + "', telephone = '" + unAutreClient.telephone
                + "' cp = '" + unAutreClient.cp
                + "' ville = '" + unAutreClient.ville + "'";

          
            try
            {
               MySqlCommand command = new MySqlCommand(StrQueryString, connection);
                MySqlDataReader MyReader;
                connection.Open();
                MyReader = command.ExecuteReader();
                while (MyReader.Read())
                {
                    MessageBox.Show("workd ! ");
                }
               

        }
            catch (Exception ex)
            {
            MessageBox.Show("Can not open connection ! ");  
            }
            connection.Close();
        }
    }
}
