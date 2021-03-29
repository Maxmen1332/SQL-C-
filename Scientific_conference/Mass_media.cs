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
    public partial class Mass_media : Form
    {
        public Mass_media()
        {
            InitializeComponent();
        }

        private void Mass_media_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Mass_media". При необходимости она может быть перемещена или удалена.
            this.mass_mediaTableAdapter.Fill(this.scientific_conferenceDataSet.Mass_media);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project_data pr = new Project_data();
            pr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mass_mediaTableAdapter.Update(scientific_conferenceDataSet);
            this.Validate();
            this.massmediaBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raport2 rep = new Raport2();
            rep.Owner = this;
            rep.Show();
        }
    }
}
