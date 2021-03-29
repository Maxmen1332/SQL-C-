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
    public partial class Rapporteur_data : Form
    {
        //public bool is_rapporteur = false;
        public Rapporteur_data()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Org org = new Org();
            org.Show();
            this.Close();
        }

        private void rapporteur_Click(object sender, EventArgs e)
        {
            Rapporteur rap = new Rapporteur();
            rap.Show();
            this.Close();
        }

        private void scient_adviser_Click(object sender, EventArgs e)
        {
            Scientific_adviser scient = new Scientific_adviser();
            scient.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Close();
        }
    }
}
