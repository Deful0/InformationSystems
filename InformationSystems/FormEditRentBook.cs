using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InformationSystems
{
    public partial class FormEditRentBook : Form
    {
        private formRentBook mainForm;

        private int rentId;
        private int workerId;
        private int userId;
        private int bookId;
        private DateTime rentDate;

        // Конструктор принимает все значения явно
        public FormEditRentBook(formRentBook parentForm, int _rentId, int _workerId, int _userId, int _bookId, DateTime _rentDate)
        {
            InitializeComponent();
            mainForm = parentForm;

            // Сохраняем полученные данные
            rentId = _rentId;
            workerId = _workerId;
            userId = _userId;
            bookId = _bookId;
            rentDate = _rentDate;

            // Загружаем данные в форму
            LoadFormData();
        }

        private void FormEditRentBook_Load(object sender, EventArgs e)
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

        private void LoadFormData()
        {
            try
            {
                // Загружаем список книг в comboBox1
                this.booksTableAdapter.Fill(mainForm.DataSet.books);
                comboBoxBook.DisplayMember = "book_name";
                comboBoxBook.ValueMember = "book_id";
                comboBoxBook.DataSource = mainForm.DataSet.books;
                // Выбираем нужную книгу
                comboBoxBook.SelectedValue = bookId;

                // Загружаем список пользователей в comboBox2
                this.usersTableAdapter.Fill(mainForm.DataSet.users);
                comboBoxUser.DisplayMember = "user_name";
                comboBoxUser.ValueMember = "user_id";
                comboBoxUser.DataSource = mainForm.DataSet.users;
                // Выбираем нужного пользователя
                comboBoxUser.SelectedValue = userId;

                // Загружаем список сотрудников в comboBox3
                this.workersTableAdapter.Fill(mainForm.DataSet.workers);
                comboBoxWorker.DisplayMember = "worker_name";
                comboBoxWorker.ValueMember = "worker_id";
                comboBoxWorker.DataSource = mainForm.DataSet.workers;
                // Выбираем нужного сотрудника
                comboBoxWorker.SelectedValue = workerId;

                // Устанавливаем дату
                dateTimePickerRentDate.Value = rentDate.Date;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainForm == null)
                {
                    MessageBox.Show("Ошибка: не найдена главная форма", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка выбора
                if (comboBoxBook.SelectedValue == null ||
                    comboBoxUser.SelectedValue == null ||
                    comboBoxWorker.SelectedValue == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Получаем новые значения
                int newBookId = (int)comboBoxBook.SelectedValue;
                int newUserId = (int)comboBoxUser.SelectedValue;
                int newWorkerId = (int)comboBoxWorker.SelectedValue;
                DateTime newRentDate = dateTimePickerRentDate.Value.Date;

                // Находим запись в DataSet по rent_id
                var rent = mainForm.DataSet.rents.FindByrent_id(rentId);

                if (rent != null)
                {
                    // Обновляем поля
                    rent.book_id = newBookId;
                    rent.user_id = newUserId;
                    rent.worker_id = newWorkerId;
                    rent.rent_date = newRentDate;

                    // Сохраняем изменения в базу данных
                    mainForm.RentsTableAdapter.Update(mainForm.DataSet.rents);

                    MessageBox.Show("Данные бронирования успешно обновлены!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Запись не найдена в DataSet!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}