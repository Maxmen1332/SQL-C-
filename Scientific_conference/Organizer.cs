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
    public partial class Organizer : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I5HK0D4;Initial Catalog=Scientific_conference;Integrated Security=True");
        public Organizer()
        {
            InitializeComponent();
        }

        private void Organizer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "scientific_conferenceDataSet.Organizer". При необходимости она может быть перемещена или удалена.
            this.organizerTableAdapter.Fill(this.scientific_conferenceDataSet.Organizer);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Conference_data conf = new Conference_data();
            conf.Show();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            organizerTableAdapter.Update(scientific_conferenceDataSet);
            this.Validate();
            this.organizerBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);

            //ID_organizer.Text = bindingNavigatorPositionItem.ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //int x = Convert.ToInt32(ID_organizer.Text);
            //x = x + 1;
            //ID_organizer.Text = bindingNavigatorPositionItem.ToString();
            //organizerTableAdapter.Update(scientific_conferenceDataSet);
            //this.Validate();
            //this.organizerBindingSource.EndEdit();
            //this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //organizerTableAdapter.Update(scientific_conferenceDataSet);
            //this.Validate();
            //this.organizerBindingSource.EndEdit();
            //this.tableAdapterManager1.UpdateAll(scientific_conferenceDataSet);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Raport2 rep = new Raport2();
            rep.Owner = this;
            rep.Show();
        }
    }
}
