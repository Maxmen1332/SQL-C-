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
    public partial class Rapporteur_data2 : Form
    {
        public Rapporteur_data2()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Show();
            this.Close();
        }

        private void rapporteur_Click(object sender, EventArgs e)
        {
            Rapporteur2 rap = new Rapporteur2();
            rap.Show();
            this.Close();
        }

        private void scient_adviser_Click(object sender, EventArgs e)
        {
            Scientific_adviser2 scient = new Scientific_adviser2();
            scient.Show();
            this.Close();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Close();
        }

        private void Rapporteur_data2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SumSpons a = new SumSpons();
            a.Show();
            this.Close();
        }

        private void back_Click_2(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }
    }
}
