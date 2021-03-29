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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            scientific_conferenceDataSet.EnforceConstraints = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.scientific_conferenceDataSet.Project);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project_data pr = new Project_data();
            pr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectTableAdapter.Update(scientific_conferenceDataSet);
            projectTableAdapter.Update(scientific_conferenceDataSet);
            this.Validate();
            this.projectBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raport2 rep = new Raport2();
            rep.Owner = this;
            rep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Query1 q = new Query1();
            q.Owner = this;
            q.Show();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddProj a = new AddProj();
            a.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
