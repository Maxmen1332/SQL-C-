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
    public partial class AddFounds : Form
    {
        public AddFounds()
        {
            InitializeComponent();
        }

        private void AddFounds_Load(object sender, EventArgs e)
        {
            scientific_conferenceDataSet.EnforceConstraints = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.scientific_conferenceDataSet.Project);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Sponsor". При необходимости она может быть перемещена или удалена.
            this.sponsorTableAdapter.Fill(this.scientific_conferenceDataSet.Sponsor);
            IDspons.Visible = false;
            IDproj.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoneyFounds a = new MoneyFounds();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scientific_conferenceDataSet.EnforceConstraints = false;
            int l = Convert.ToInt32(IDspons.Text);
            int r = Convert.ToInt32(IDproj.Text);
            funding_detailsTableAdapter1.Insert(l,r);
        }

        private void IDproj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDspons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
