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
    public partial class Raport2 : Form
    {
        public Raport2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Raport2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Sponsor". При необходимости она может быть перемещена или удалена.
            //this.sponsorTableAdapter.Fill(this.scientific_conferenceDataSet.Sponsor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Scientific_adviser". При необходимости она может быть перемещена или удалена.
            //this.scientific_adviserTableAdapter.Fill(this.scientific_conferenceDataSet.Scientific_adviser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Rapporteur". При необходимости она может быть перемещена или удалена.
            //this.rapporteurTableAdapter.Fill(this.scientific_conferenceDataSet.Rapporteur);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Project". При необходимости она может быть перемещена или удалена.
            //this.projectTableAdapter.Fill(this.scientific_conferenceDataSet.Project);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Mass_media". При необходимости она может быть перемещена или удалена.
            //this.mass_mediaTableAdapter.Fill(this.scientific_conferenceDataSet.Mass_media);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Organizer". При необходимости она может быть перемещена или удалена.
            //this.organizerTableAdapter.Fill(this.scientific_conferenceDataSet.Organizer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Conference". При необходимости она может быть перемещена или удалена.
            //this.conferenceTableAdapter.Fill(this.scientific_conferenceDataSet.Conference);
            Form form = this.Owner as Form;          
            switch (form.GetType().ToString())
            {
                case "Scientific_conference.Conference":
                    this.conferenceTableAdapter.Fill(this.scientific_conferenceDataSet.Conference);
                    dataGridView1.DataSource = conferenceTableAdapter.GetData();
                    break;
                case "Scientific_conference.Organizer":
                    this.organizerTableAdapter.Fill(this.scientific_conferenceDataSet.Organizer);
                    dataGridView1.DataSource = organizerTableAdapter.GetData();
                    break;
                case "Scientific_conference.Rapporteur":
                    this.rapporteurTableAdapter.Fill(this.scientific_conferenceDataSet.Rapporteur);
                    dataGridView1.DataSource = rapporteurTableAdapter.GetData();
                    break;
                case "Scientific_conference.Project":
                    this.projectTableAdapter.Fill(this.scientific_conferenceDataSet.Project);
                    dataGridView1.DataSource = projectTableAdapter.GetData();
                    break;
                case "Scientific_conference.Scientific_adviser":
                    this.scientific_adviserTableAdapter.Fill(this.scientific_conferenceDataSet.Scientific_adviser);
                    dataGridView1.DataSource = scientific_adviserTableAdapter.GetData();
                    break;
                case "Scientific_conference.Mass_media":
                    this.mass_mediaTableAdapter.Fill(this.scientific_conferenceDataSet.Mass_media);
                    dataGridView1.DataSource = mass_mediaTableAdapter.GetData();
                    break;
                case "Scientific_conference.Sponsor":
                    this.sponsorTableAdapter.Fill(this.scientific_conferenceDataSet.Sponsor);
                    dataGridView1.DataSource = sponsorTableAdapter.GetData();
                    break;
                case "Scientific_conference.Scientific_adviser2":
                    this.scientific_adviserTableAdapter.Fill(this.scientific_conferenceDataSet.Scientific_adviser);
                    dataGridView1.DataSource = scientific_adviserTableAdapter.GetData();
                    break;
                case "Scientific_conference.Rapporteur2":
                    this.rapporteurTableAdapter.Fill(this.scientific_conferenceDataSet.Rapporteur);
                    dataGridView1.DataSource = rapporteurTableAdapter.GetData();
                    break;
            }
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
