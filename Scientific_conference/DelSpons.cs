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
    public partial class DelSpons : Form
    {
        public DelSpons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoneyFounds a = new MoneyFounds();
            a.Show();
            this.Close();
        }

        private void DelSpons_Load(object sender, EventArgs e)
        {
            scientific_conferenceDataSet.EnforceConstraints = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Sponsor". При необходимости она может быть перемещена или удалена.
            this.sponsorTableAdapter.Fill(this.scientific_conferenceDataSet.Sponsor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.scientific_conferenceDataSet.Project);
            IDproj.Visible = false;
            IDspon.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funding_detailsTableAdapter1.Delete(Convert.ToInt32(IDproj.Text), Convert.ToInt32(IDspon.Text));
        }

        private void IDproj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
