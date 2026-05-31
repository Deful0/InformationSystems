using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystems
{
    public partial class formFins : Form
    {
        public formFins()
        {
            InitializeComponent();
        }

        private void formFins_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.dBDataSet.books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dBDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.fins". При необходимости она может быть перемещена или удалена.
            this.finsTableAdapter.Fill(this.dBDataSet.fins);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.finsTableAdapter.Update(this.dBDataSet.fins);

            Form main = Application.OpenForms["Form1"];

            if (main != null)
            {
                main.Show();
            }

            this.Close();
        }
    }
}
