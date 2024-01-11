using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.Types;
using System.Data.Common;
using System.Data.SqlClient;


namespace todolist_project
{
    public partial class Form1 : Form
    {
        private Database database = new Database();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            try
            {
                if (database.connect_db())
                {
                    string query = "SELECT * FROM geciszar";
                    MySqlCommand mySqlCommand = new MySqlCommand(query);
                    mySqlCommand.Connection = database.mySqlConnection;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = mySqlCommand;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    dataGridView1.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("Database Error");
                }

            }
            catch (Exception ex) {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
           
            finally
            {
                database.close_db();
            }
        }

        private void add_Click_1(object sender, EventArgs e)
        {


            try
            {
                if (database.connect_db())
                {
                    // Felhasználói felületen megadott adatok
                    string newData = textBox1.Text; // Példa érték, helyettesítsd a saját logikáddal
                    string newData2 = textBox2.Text;

                    // SQL parancs a hozzáadáshoz
                    string insertQuery = $"INSERT INTO geciszar (id, products, price) VALUES (NULL, '{newData}', '{newData2}')";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, database.mySqlConnection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Frissíti a DataGridView-t az új adattal
                    loadData();
                }
                else
                {
                    MessageBox.Show("Database connection failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
            finally
            {
                database.close_db();
            }
        }

        private void search_Click_1(object sender, EventArgs e)
        {


            try
            {
                // Felhasználói felületen megadott keresési kifejezés
                string searchTerm = textBox1.Text; // textBoxSearch: a TextBox a keresési kifejezés megadásához

                // SQL parancs a kereséshez
                string searchQuery = $"SELECT * FROM geciszar WHERE products LIKE '{searchTerm}'";

                database.connect_db();

                // Frissíti a DataGridView-t a keresési eredményekkel
                MySqlCommand mySqlCommand = new MySqlCommand(searchQuery, database.mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
            finally
            {
                database.close_db();
            }
        }

        private void delete_Click_1(object sender, EventArgs e)
        {


            try
            {
                // Felhasználó által megadott törlendő érték
                string valueToDelete = textBox1.Text; // textBoxDelete: a TextBox a törlendő érték megadásához

                // SQL parancs a törléshez
                string deleteQuery = $"DELETE FROM geciszar WHERE products LIKE '{valueToDelete}'";

                database.connect_db();

                using (MySqlCommand command = new MySqlCommand(deleteQuery, database.mySqlConnection))
                {
                    command.ExecuteNonQuery();
                }

                // Frissíti a DataGridView-t a törlés után
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }
            finally
            {
                database.close_db();
            }
        }
    }
}
