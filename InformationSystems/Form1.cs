using InformationSystems.NHibernate.Entites;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Справочник книг
        private void dimBooks_Click(object sender, EventArgs e)
        {
            formBooks fBook = new formBooks();
            this.Hide();
            fBook.Show();
        }

        // Справочник сотрудников
        private void dimEmployee_Click(object sender, EventArgs e)
        {
            formWorkers fWorkers = new formWorkers();
            this.Hide();
            fWorkers.Show();
        }

        // Справочник книг
        private void ButtonRentBook_Click(object sender, EventArgs e)
        {
            formRentBook fRentBook = new formRentBook();
            this.Hide();
            fRentBook.Show();
        }

        // Документ штрафы
        private void ButtonFins_Click(object sender, EventArgs e)
        {
            formFins fFins = new formFins();
            this.Hide();
            fFins.Show();
        }

        // Документ ЗП
        private void ButtonSalary_Click(object sender, EventArgs e)
        {
            formSalary fSalary = new formSalary();
            this.Hide();
            fSalary.Show();
        }
        
        // Справочник клиентов
        private void dimClient_Click(object sender, EventArgs e)
        {
            formUser fUser = new formUser();
            this.Hide();
            fUser.Show();
        }

        // Справочник VIP клиентов
        private void dimVipClient_Click(object sender, EventArgs e)
        {
            forVipUser fVIPUser = new forVipUser();
            this.Hide();
            fVIPUser.Show();
        }

        // Справочник retro книг
        private void dimRetroBooks_Click(object sender, EventArgs e)
        {
            RetroBookListUnit f_retro_book = new RetroBookListUnit();
            this.Hide();
            f_retro_book.Show();
        }
    }
}
