using InformationSystems.DBDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace InformationSystems
{
    public partial class formRentBook : Form
    {
        public formRentBook()
        {
            InitializeComponent();
        }

        public DBDataSet DataSet
        {
            get { return this.dBDataSet; }
        }

        public rentsTableAdapter RentsTableAdapter
        {
            get { return this.rentsTableAdapter; }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Form1"];

            if (main != null)
            {
                main.Show();
            }

            this.Close();
        }

        private void formRentBook_Load(object sender, EventArgs e)
        {
            // Загружаем данные бронирований
            this.rentsTableAdapter.Fill(this.dBDataSet.rents);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Передаем this (текущую форму formRentBook)
            FormAddRentBook f_add = new FormAddRentBook(this);
            f_add.ShowDialog();

            // Обновляем данные после добавления
            this.rentsTableAdapter.Fill(this.dBDataSet.rents);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Считываем данные из выбранной строки
            DataGridViewRow row = dataGridView1.CurrentRow;

            int rentId = Convert.ToInt32(row.Cells[0].Value);      // rent_id
            int workerId = Convert.ToInt32(row.Cells[1].Value);    // worker_id
            int userId = Convert.ToInt32(row.Cells[2].Value);      // user_id
            int bookId = Convert.ToInt32(row.Cells[3].Value);      // book_id
            DateTime rentDate = Convert.ToDateTime(row.Cells[4].Value); // rent_date

            // Открываем форму редактирования и передаем все данные
            FormEditRentBook f_edit = new FormEditRentBook(this, rentId, workerId, userId, bookId, rentDate);
            f_edit.ShowDialog();

            // Обновляем данные после редактирования
            this.rentsTableAdapter.Fill(this.dBDataSet.rents);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем ID выбранной записи
            int rentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            // Запрашиваем подтверждение удаления
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить запись №{rentId}?\n\nЭто действие нельзя отменить!",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Находим запись в DataSet
                    var rent = this.dBDataSet.rents.FindByrent_id(rentId);

                    if (rent != null)
                    {
                        // Удаляем запись из DataSet
                        rent.Delete();

                        // Сохраняем изменения в базу данных
                        this.rentsTableAdapter.Update(this.dBDataSet.rents);

                        // Обновляем DataGridView
                        this.rentsTableAdapter.Fill(this.dBDataSet.rents);

                        MessageBox.Show("Запись успешно удалена!", "Успех",
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
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}