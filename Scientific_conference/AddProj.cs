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
    public partial class AddProj : Form
    {
        public AddProj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project a = new Project();
            a.Show();
            this.Close();
        }

        private void AddProj_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Rapporteur". При необходимости она может быть перемещена или удалена.
            this.rapporteurTableAdapter.Fill(this.scientific_conferenceDataSet.Rapporteur);
            IDRap.Visible = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectTableAdapter1.Insert(ProjTop.Text,ProjSf.Text, Convert.ToInt32 (IDRap.Text));
            
        }
    }
}
