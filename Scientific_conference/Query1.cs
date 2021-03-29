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
    public partial class Query1 : Form
    {
        public Query1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Query1_Load(object sender, EventArgs e)
        {         
            Form form = this.Owner as Form;
            switch (form.GetType().ToString())
            {               
                case "Scientific_conference.Project":
                    this.project_viewTableAdapter.Fill(this.scientific_conferenceDataSet1.Project_view);
                    dataGridView1.DataSource = project_viewTableAdapter.GetData();
                    this.Text = "Общие сведения о проектах";
                    break;
                case "Scientific_conference.Sponsor":
                    this.sum_money_viewTableAdapter1.Fill(this.scientific_conferenceDataSet1.Sum_money_view);
                    dataGridView1.DataSource = sum_money_viewTableAdapter1.GetData();
                    this.Text = "Затраты спонсоров";
                    break;                   
            }
            dataGridView1.ReadOnly = true;
        }

        private void summoneyviewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
