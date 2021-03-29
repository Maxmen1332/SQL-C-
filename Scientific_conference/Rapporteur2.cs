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
    public partial class Rapporteur2 : Form
    {
        public Rapporteur2()
        {
            InitializeComponent();
        }

        private void Rapporteur2_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Rapporteur". При необходимости она может быть перемещена или удалена.
            this.rapporteurTableAdapter.Fill(this.scientific_conferenceDataSet.Rapporteur);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rapporteur_data2 rap = new Rapporteur_data2();
            rap.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rapporteurTableAdapter.Update(scientific_conferenceDataSet);
            this.Validate();
            this.rapporteurBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);
        }

        private void search_Click(object sender, EventArgs e)
        {
            //scientific_conferenceDataSet.Rapporteur.GetDataBy();
            //Binding binding = rapporteurTableAdapter.GetDataBy("Сем").N
            //dataGridView1.DataBindings.Add(rapporteurTableAdapter.GetDataBy("Сем").NewRow());
            dataGridView1.DataSource = rapporteurTableAdapter.GetDataBy(search_data.Text);
            //= rapporteurTableAdapter.GetDataBy("Сем");
            dataGridView1.Columns[0].Visible = false;            
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
    }
}
