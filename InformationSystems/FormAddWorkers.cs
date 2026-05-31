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
    public partial class FormAddWorkers : Form
    {
        private formWorkers mainForm;

        public FormAddWorkers(formWorkers parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
        }

        private void FormAddWorkers_Load(object sender, EventArgs e)
        {

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
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка");
                    return;
                }

                mainForm.WorkersTableAdapter.Insert(
                    textBox1.Text,
                    DateTime.Parse(textBox2.Text),
                    DateTime.Parse(textBox3.Text),
                    int.Parse(textBox4.Text),
                    textBox5.Text
                );

                mainForm.WorkersTableAdapter.Fill(mainForm.DataSet.workers);

                MessageBox.Show("Сотрудник успешно добавлен!", "Успех");
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
    }
}
