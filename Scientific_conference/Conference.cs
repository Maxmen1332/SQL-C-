using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Scientific_conference
{   
    public partial class Conference : Form
    {
        SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-I5HK0D4;Initial Catalog=Scientific_conference;Integrated Security=True");
        public Conference()
        {
            InitializeComponent();
        }

        private void Conference_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Conference". При необходимости она может быть перемещена или удалена.
            this.conferenceTableAdapter.Fill(this.scientific_conferenceDataSet.Conference);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Organizer". При необходимости она может быть перемещена или удалена.
            this.organizerTableAdapter.Fill(this.scientific_conferenceDataSet.Organizer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Conference". При необходимости она может быть перемещена или удалена.
            this.conferenceTableAdapter.Fill(this.scientific_conferenceDataSet.Conference);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conference_data conf = new Conference_data();
            conf.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //scientific_conferenceDataSet.Tables{F}
           
            conferenceTableAdapter.Update(scientific_conferenceDataSet);
            this.Validate();
            
            this.conferenceBindingSource.EndEdit();
            //this.conferenceBindingSource.Add(FIO_organizer. = conf);
            //this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raport2 rep = new Raport2();
            rep.Owner = this;
            rep.Show();
        }

        private void conferenceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form org = new Form2();
            org.Show();
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_organizer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
