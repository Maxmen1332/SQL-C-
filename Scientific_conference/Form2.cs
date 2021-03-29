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
    public partial class Form2 : Form
    {
        SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-I5HK0D4;Initial Catalog=Scientific_conference;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Perfomance_details". При необходимости она может быть перемещена или удалена.
            
            this.organizerTableAdapter1.Fill(this.scientific_conferenceDataSet.Organizer);
            comboBox3.Visible = false;
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conference conf = new Conference();
            conf.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conferenceTableAdapter1.Insert(Convert.ToDateTime(Day.Text), Scientific_sphere.Text, Address.Text, Convert.ToInt32(comboBox3.Text));
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
