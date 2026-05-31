using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InformationSystems
{
    public partial class FormAddRentBook : Form
    {
        private formRentBook mainForm;

        public FormAddRentBook(formRentBook parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
        }

        private void FormAddRentBook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet1.rents". При необходимости она может быть перемещена или удалена.
            this.rentsTableAdapter.Fill(this.dBDataSet1.rents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet1.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.dBDataSet1.books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet1.rents". При необходимости она может быть перемещена или удалена.
            this.rentsTableAdapter.Fill(this.dBDataSet1.rents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet1.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dBDataSet1.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.rents". При необходимости она может быть перемещена или удалена.
            this.rentsTableAdapter.Fill(this.dBDataSet.rents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dBDataSet.workers);

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainForm == null)
                {
                    MessageBox.Show("Ошибка: не найдена главная форма");
                    return;
                }

                // Проверка полей
                if (comboBox1.SelectedValue == null ||
                    comboBox2.SelectedValue == null ||
                    comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка");
                    return;
                }

                int bookId = (int)comboBox1.SelectedValue;
                int userId = (int)comboBox2.SelectedValue;
                int workerId = (int)comboBox3.SelectedValue;
                DateTime rentDate = dateTimePicker1.Value;

                mainForm.RentsTableAdapter.Insert(
                    bookId,
                    userId,
                    workerId,
                    rentDate
                );

                mainForm.RentsTableAdapter.Fill(mainForm.DataSet.rents);

                MessageBox.Show("Проверьте правильность ввода данных!", "Успех");
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность ввода:\nДаты в формате ДД.ММ.ГГГГ\nЗарплата должна быть числом");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
