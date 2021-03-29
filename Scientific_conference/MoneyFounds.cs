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
    public partial class MoneyFounds : Form
    {
        public MoneyFounds()
        {
            InitializeComponent();
        }

        private void MoneyFounds_Load(object sender, EventArgs e)
        {
            this.view_1TableAdapter.Fill(this.scientific_conferenceDataSet2.View_1);
            dataGridView1.DataSource = view_1TableAdapter.GetData();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet2.View_1". При необходимости она может быть перемещена или удалена.
            // this.view_1TableAdapter.Fill(this.scientific_conferenceDataSet2.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet2.View_1". При необходимости она может быть перемещена или удалена.
            

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

        private void button2_Click(object sender, EventArgs e)
        {
            AddFounds a = new AddFounds();
            a.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelSpons a = new DelSpons();
            a.Show();
            this.Close();
        }
    }
}
