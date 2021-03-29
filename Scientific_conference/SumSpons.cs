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
    public partial class SumSpons : Form
    {
        public SumSpons()
        {
            InitializeComponent();
        }

        private void SumSpons_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet11.Sum_money_view". При необходимости она может быть перемещена или удалена.
            this.sum_money_viewTableAdapter.Fill(this.scientific_conferenceDataSet11.Sum_money_view);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Rapporteur_data2 a = new Rapporteur_data2();
            a.Show();
            this.Close();
        }
    }
}
