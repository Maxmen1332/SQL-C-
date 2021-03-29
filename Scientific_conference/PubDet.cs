using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_conference
{
    public partial class PubDet : Form
    {
        public PubDet()
        {
            InitializeComponent();
        }

        private void PubDet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Performance_details". При необходимости она может быть перемещена или удалена.
       

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project_data a = new Project_data();
            a.Show();
            this.Close();
        }

        private void PubDet_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet1.Publication_details". При необходимости она может быть перемещена или удалена.
            //this.publication_detailsTableAdapter.Fill(this.scientific_conferenceDataSet1.Publication_details);
            dataGridView1.DataSource = publication_detailsTableAdapter.GetDataBy();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewPubDet a = new NewPubDet();
            a.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delPubDet a = new delPubDet();
            a.Show();
            this.Close();
        }
    }
}
