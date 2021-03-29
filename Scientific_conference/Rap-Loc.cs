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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Performance_details". При необходимости она может быть перемещена или удалена.
            dataGridView1.DataSource = performance_detailsTableAdapter.GetDataBy();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            NewRap_Conf a = new NewRap_Conf();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rapporteur_data a = new Rapporteur_data();
            a.Show();
            this.Close();
        }
    }
}
