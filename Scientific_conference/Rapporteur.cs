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
    public partial class Rapporteur : Form
    {
        public Rapporteur()
        {
            InitializeComponent();
        }

        private void Rapporteur_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Scientific_adviser". При необходимости она может быть перемещена или удалена.
            this.scientific_adviserTableAdapter.Fill(this.scientific_conferenceDataSet.Scientific_adviser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Rapporteur". При необходимости она может быть перемещена или удалена.
            this.rapporteurTableAdapter.Fill(this.scientific_conferenceDataSet.Rapporteur);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rapporteur_data rap = new Rapporteur_data();
            rap.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scientific_adviserTableAdapter.Update(scientific_conferenceDataSet);
            rapporteurTableAdapter.Update(scientific_conferenceDataSet);
            this.Validate();
            this.rapporteurBindingSource.EndEdit();
            //this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rapporteurTableAdapter1.GetDataBy(search_data.Text);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raport2 rep = new Raport2();
            rep.Owner = this;
            rep.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form org = new InsRap();
            org.Show();
        }
    }
}
