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
    public partial class FormForm : Form
    {
        public FormForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Organizer org = new Organizer();
            org.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sponsor sp = new Sponsor();
            sp.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mass_media mm = new Mass_media();
            mm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Scientific_adviser scient = new Scientific_adviser();
            scient.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Project pr = new Project();
            pr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conference conf = new Conference();
            conf.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rapporteur rap = new Rapporteur();
            rap.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Org a = new Org();
            a.Show();
            this.Close();
        }
    }
}
