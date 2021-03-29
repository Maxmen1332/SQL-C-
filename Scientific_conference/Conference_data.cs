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
    public partial class Conference_data : Form
    {
        public Conference_data()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Org org = new Org();
            org.Show();
            this.Close();
        }

        private void organizer_Click(object sender, EventArgs e)
        {
            Organizer org = new Organizer();
            org.Show();
            this.Close();
        }

        private void conference_Click(object sender, EventArgs e)
        {
            Conference conf = new Conference();
            conf.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Close();
        }
    }
}
