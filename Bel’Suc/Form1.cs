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
    
    public partial class Form1 : Form
    {
        public static string connectionstring = "Server=127.0.0.1;Database=Sucrerie;Uid=root;Pwd='';";
        public Form1()
        {
            InitializeComponent();
            var comboColor = new List<ComboValue>();
            comboColor.Add(new ComboValue() { Name = "Client", Value = "Client" });
            comboColor.Add(new ComboValue() { Name = "Produit", Value = "Produit" });
            comboColor.Add(new ComboValue() { Name = "Vendeur", Value = "Vendeur" });
            comboColor.Add(new ComboValue() { Name = "Commande", Value = "Commande" });
            comboBox1.DataSource = comboColor;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Value";
            //dataGridView1.Columns[]
        }

 
        private void button_rechercher_Click(object sender, EventArgs e)
        {
            string StrQueryString;
            
            var connection = new MySqlConnection(connectionstring);
            connection.Open();
            switch (comboBox1.SelectedValue)

            {
                case "Client":
                    StrQueryString = "SELECT code_c, nom, adresse, cp, ville, telephone FROM @ValeurCombo";
                    var ParametresRequetes = new DynamicParameters();
                    ParametresRequetes.Add("ValeurCombo", comboBox1.SelectedValue);
                    try
                    {
                     var oui =   ParametresRequetes.Get<object>("ValueCombo");
                        var ContexteClients = connection.Query<Client>(StrQueryString, ParametresRequetes).ToList();


                        dataGridView1.DataSource = ContexteClients;
                    }
                    catch( MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "Produit":

                    StrQueryString = "SELECT designation, quantite, prix_unitaire_ht, stock FROM " + comboBox1.SelectedValue;
                     var ContexteProduit = connection.Query<Produit>(StrQueryString).ToList();
                    dataGridView1.DataSource = ContexteProduit;

                    break;
                case "Vendeur":
                     StrQueryString = "SELECT nom, telephone FROM " + comboBox1.SelectedValue;
                    var ContexteVendeur = connection.Query<Vendeur>(StrQueryString).ToList();
                    dataGridView1.DataSource = ContexteVendeur;

                    break;
                
                case "Commande":
                    StrQueryString = "SELECT date_livraison, date_commande, total_ht FROM " + comboBox1.SelectedValue;
                    var ContexteCommande = connection.Query<Commande>(StrQueryString).ToList();
                    dataGridView1.DataSource = ContexteCommande;

                    break;

            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            //           if (comboBox1.SelectedValue.ToString() == "Client")
            //            {
            //                string StrQuery = "SELECT nom, telephone FROM " + comboBox1.SelectedValue;
            //                var ContexteClients = connection.Query<Client>(StrQuery).ToList();
            //                dataGridView1.DataSource = ContexteClients;

            //            }
            //           else if (comboBox1.SelectedValue.ToString() == "Produit")
            //            {
            //            }
            //           else if(comboBox1.SelectedValue.ToString() == "Vendeur")
            //            {

            //            }
            //            else
            //            {

            //            }
            connection.Close();

        }
        
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var obj_temp =(Client) row.DataBoundItem;
                Form2 form_client = new Form2();
                form_client.fill_txbox(obj_temp);
                form_client.Show();
                
            }
                   

            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
