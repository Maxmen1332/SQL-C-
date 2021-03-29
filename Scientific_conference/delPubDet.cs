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
    public partial class delPubDet : Form
    {
        public delPubDet()
        {
            InitializeComponent();
        }

        private void delPubDet_Load(object sender, EventArgs e)
        {
            IDmasm.Visible = false;
            IDProj.Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Funding_details". При необходимости она может быть перемещена или удалена.
            this.funding_detailsTableAdapter.Fill(this.scientific_conferenceDataSet.Funding_details);
            scientific_conferenceDataSet.EnforceConstraints = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Mass_media". При необходимости она может быть перемещена или удалена.
            this.mass_mediaTableAdapter.Fill(this.scientific_conferenceDataSet.Mass_media);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.scientific_conferenceDataSet.Project);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PubDet a = new PubDet();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            publication_detailsTableAdapter1.Delete(Convert.ToInt32(IDProj.Text), Convert.ToInt32(IDmasm.Text));
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.publication_detailsTableAdapter1.FillBy(this.scientific_conferenceDataSet.Publication_details);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
