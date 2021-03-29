using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Scientific_conference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckPassword_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I5HK0D4;Initial Catalog=Scientific_conference;Integrated Security=True");
            string query = "SELECT * FROM Groups WHERE [Group]='" +  User.Text  + "' and Pass='" + Password.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                Password.Clear();
                this.Hide();
                if (dataTable.Rows[0]["Group"].ToString().Trim() == "Организатор")
                {
                    Org org = new Org();                                       
                    org.Show();
                }
                if (dataTable.Rows[0]["Group"].ToString().Trim() == "Докладчик")
                {
                    Rapporteur_data2 rap = new Rapporteur_data2();                    
                    rap.Show();
                }
            }
            else
            {
                MessageBox.Show("Произошла ошибка! Проверьте тип пользователя и пароль.");
                Password.Clear();
            }
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Close();
        }

        private void User_SelectedIndexChanged(object sender, EventArgs e)
        {
            Password.Clear();
        }
    }
}
