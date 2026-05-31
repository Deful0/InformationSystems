using System;
using System.Windows.Forms;

namespace InformationSystems
{
    public partial class FormEditWorkers : Form
    {
        private formWorkers mainForm;

        private int workerId;
        private string workerName;
        private DateTime workStart;
        private DateTime workEnd;
        private int workerSalary;
        private string workerStatus;

        public FormEditWorkers(formWorkers parentForm, int _workerId, string _workerName, DateTime _workStart, DateTime _workEnd, int _workerSalary, string _workerStatus)
        {
            InitializeComponent();
            mainForm = parentForm;

            // Сохраняем полученные данные
            workerId = _workerId;
            workerName = _workerName;
            workStart = _workStart;
            workEnd = _workEnd;
            workerSalary = _workerSalary;
            workerStatus = _workerStatus;

            // Загружаем данные в форму
            LoadFormData();
        }

        private void LoadFormData()
        {
            try
            {
                // Заполняем поля формы
                textBoxID.Text = workerId.ToString();
                textBoxID.ReadOnly = true; // ID нельзя менять

                textBoxName.Text = workerName;
                textBoxStart.Text = workStart.ToString("yyyy-MM-dd");
                textBoxEnd.Text = workEnd.ToString("yyyy-MM-dd");
                textBoxSalary.Text = workerSalary.ToString();
                textBoxStatus.Text = workerStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка заполнения полей
                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxStart.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEnd.Text) ||
                    string.IsNullOrWhiteSpace(textBoxSalary.Text) ||
                    string.IsNullOrWhiteSpace(textBoxStatus.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Находим строку в DataSet
                var worker = mainForm.DataSet.workers.FindByworker_id(workerId);

                if (worker != null)
                {
                    // Обновляем поля
                    worker.worker_name = textBoxName.Text;
                    worker.work_start = DateTime.Parse(textBoxStart.Text);
                    worker.work_end = DateTime.Parse(textBoxEnd.Text);
                    worker.worker_salary = int.Parse(textBoxSalary.Text);
                    worker.worker_status = textBoxStatus.Text;

                    // Сохраняем изменения в базу данных
                    mainForm.WorkersTableAdapter.Update(mainForm.DataSet.workers);

                    MessageBox.Show("Данные сотрудника успешно обновлены!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Сотрудник не найден в DataSet!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность ввода:\nДаты в формате ГГГГ-ММ-ДД\nЗарплата должна быть числом",
                    "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditWorkers_Load(object sender, EventArgs e)
        {

        }
    }
}