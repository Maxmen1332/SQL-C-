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
    public partial class NewPubDet : Form
    {  
        public NewPubDet()
        {
            InitializeComponent();
        }

        private void NewPubDet_Load(object sender, EventArgs e)
        {
            IDmasmed.Visible = false;
            SerialNumber.Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet1.Mass_media". При необходимости она может быть перемещена или удалена.
            this.mass_mediaTableAdapter.Fill(this.scientific_conferenceDataSet1.Mass_media);
            scientific_conferenceDataSet.EnforceConstraints = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.scientific_conferenceDataSet.Project);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            publication_detailsTableAdapter1.Insert( Convert.ToInt32(SerialNumber.Text),Convert.ToInt32 (IDmasmed.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PubDet a = new PubDet();
            a.Show();
            this.Close();
        }

        private void SerialNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDmasmed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
