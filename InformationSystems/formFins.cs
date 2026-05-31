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

        private void button_delet_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка в DataGridView
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем ID штрафа (предполагаем, что первая колонка - fine_id)
            int fineId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            // Запрашиваем подтверждение
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить штраф №{fineId}?\n\nЭто действие нельзя отменить!",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Находим запись в DataSet
                    var fine = this.dBDataSet.fins.FindByfine_id(fineId);

                    if (fine != null)
                    {
                        // Удаляем запись
                        fine.Delete();

                        // Сохраняем изменения в базу
                        this.finsTableAdapter.Update(this.dBDataSet.fins);

                        // Обновляем DataGridView
                        this.finsTableAdapter.Fill(this.dBDataSet.fins);

                        MessageBox.Show("Штраф успешно удален!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Запись не найдена!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибки внешнего ключа
                    if (ex.Message.Contains("foreign key") || ex.Message.Contains("REFERENCES"))
                    {
                        MessageBox.Show("Невозможно удалить запись, так как она связана с другими данными!",
                            "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
