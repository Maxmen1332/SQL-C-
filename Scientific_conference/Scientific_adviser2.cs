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
    public partial class Scientific_adviser2 : Form
    {
        public Scientific_adviser2()
        {
            InitializeComponent();
        }

        private void Scientific_adviser2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Scientific_adviser". При необходимости она может быть перемещена или удалена.
            this.scientific_adviserTableAdapter.Fill(this.scientific_conferenceDataSet.Scientific_adviser);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rapporteur_data2 rap = new Rapporteur_data2();
            rap.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scientific_adviserTableAdapter.Update(scientific_conferenceDataSet);
            this.Validate();
            this.scientificadviserBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raport2 rep = new Raport2();
            rep.Owner = this;
            rep.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
