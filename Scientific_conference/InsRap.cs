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
    public partial class InsRap : Form
    {
        SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-I5HK0D4;Initial Catalog=Scientific_conference;Integrated Security=True");

        public InsRap()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ID_Adv.Visible = false;
            this.scientific_adviserTableAdapter1.Fill(this.scientific_conferenceDataSet1.Scientific_adviser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rapporteur conf = new Rapporteur();
            conf.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            rapporteurTableAdapter1.Insert(FIO_Rap.Text,Org.Text,Deg.Text,Convert.ToInt32  (ID_Adv.Text) );
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
