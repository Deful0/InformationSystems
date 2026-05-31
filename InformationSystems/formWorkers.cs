using InformationSystems.DBDataSetTableAdapters;
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
    public partial class formWorkers : Form
    {
        public formWorkers()
        {
            InitializeComponent();
        }

        public DBDataSet DataSet
        {
            get { return this.dBDataSet; }
        }

        public workersTableAdapter WorkersTableAdapter
        {
            get { return this.workersTableAdapter; }
        }

        private void formWorkers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dBDataSet.workers);
            dataGridView1.DataSource = workersBindingSource;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Form1"];

            if (main != null)
            {
                main.Show();
            }

            this.Close();
        }

        private void buttonAddWork_Click(object sender, EventArgs e)
        {
            FormAddWorkers f_add = new FormAddWorkers(this);
            f_add.ShowDialog();

            this.workersTableAdapter.Fill(this.dBDataSet.workers);
        }

        private void buttonEditWork_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Считываем данные из выбранной строки
                DataGridViewRow row = dataGridView1.CurrentRow;

                int workerId = Convert.ToInt32(row.Cells[0].Value);
                string workerName = row.Cells[1].Value.ToString();

                DateTime workStart = GetDateTimeFromCell(row.Cells[2].Value);
                DateTime workEnd = GetDateTimeFromCell(row.Cells[3].Value);

                int workerSalary = Convert.ToInt32(row.Cells[4].Value);
                string workerStatus = row.Cells[5].Value.ToString();

                // Открываем форму редактирования
                FormEditWorkers f_edit = new FormEditWorkers(this, workerId, workerName, workStart, workEnd, workerSalary, workerStatus);
                f_edit.ShowDialog();

                // Обновляем данные после редактирования
                this.workersTableAdapter.Fill(this.dBDataSet.workers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для получения даты, с обработкой на NULL
        private DateTime GetDateTimeFromCell(object cellValue)
        {
            if (cellValue == null || cellValue == DBNull.Value)
            {
                return DateTime.MinValue;
            }
            return Convert.ToDateTime(cellValue);
        }

        private void buttonDeleteWork_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем ID выбранного сотрудника
            int workerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string workerName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            // Запрашиваем подтверждение удаления
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить сотрудника:\n{workerName} (ID: {workerId})?\n\nЭто действие нельзя отменить!",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Находим запись в DataSet
                    var worker = this.dBDataSet.workers.FindByworker_id(workerId);

                    if (worker != null)
                    {
                        // Удаляем запись
                        worker.Delete();

                        // Сохраняем изменения в базу данных
                        this.workersTableAdapter.Update(this.dBDataSet.workers);

                        MessageBox.Show("Сотрудник успешно удален!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Сотрудник не найден!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("foreign key") || ex.Message.Contains("REFERENCES"))
                    {
                        MessageBox.Show("Невозможно удалить сотрудника, так как он связан с другими записями (например, бронированиями)!",
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
