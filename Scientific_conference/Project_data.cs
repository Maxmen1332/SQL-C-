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
    public partial class Project_data : Form
    {
        public Project_data()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Org org = new Org();
            org.Show();
            this.Close();
        }

        private void project_Click(object sender, EventArgs e)
        {
            Project pr = new Project();
            pr.Show();
            this.Close();
        }

        private void sponsor_Click(object sender, EventArgs e)
        {
            Sponsor sp = new Sponsor();
            sp.Show();
            this.Close();
        }

        private void mass_media_Click(object sender, EventArgs e)
        {
            Mass_media mm = new Mass_media();
            mm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PubDet a = new PubDet();
            a.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoneyFounds a = new MoneyFounds();
            a.Show();
            this.Close();
        }
    }
}
