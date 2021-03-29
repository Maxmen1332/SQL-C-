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
    public partial class Org : Form
    {
        public Org()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Show();
            this.Close();
        }

        private void conference_data_Click(object sender, EventArgs e)
        {           
            Conference_data conf = new Conference_data();
            conf.Show();
            this.Close();
        }

        private void rapporteur_data_Click(object sender, EventArgs e)
        {
            Rapporteur_data rap = new Rapporteur_data();
            rap.Show();
            this.Close();
        }

        private void Project_data_Click(object sender, EventArgs e)
        {
            Project_data proj = new Project_data();
            proj.Show();
            this.Close();
        }

        private void Org_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];            
            form1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormForm a = new FormForm();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otcheti a = new Otcheti();
            a.Show();
            this.Close();
        }
    }
}
