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
    public partial class NewRap_Conf : Form
    {
        public NewRap_Conf()
        {
            InitializeComponent();
        }

        private void NewRap_Conf_Load(object sender, EventArgs e)
        {
            IDconf.Visible = false;
            IDRap.Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Conference". При необходимости она может быть перемещена или удалена.
            this.conferenceTableAdapter.Fill(this.scientific_conferenceDataSet.Conference);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Rapporteur". При необходимости она может быть перемещена или удалена.
            this.rapporteurTableAdapter.Fill(this.scientific_conferenceDataSet.Rapporteur);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            performance_detailsTableAdapter1.Insert(Convert.ToInt32 (IDRap.Text),Convert.ToInt32(IDconf.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
