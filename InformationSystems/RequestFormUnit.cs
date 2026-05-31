using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using InformationSystems.NHibernate.Entites;

namespace InformationSystems
{
    public partial class RequestFormUnit : Form
    {
        private IList<Book> books; // Список книг для выпадающего списка
        private ISession nhibernate_session; // Сессия NHibernate

        public RequestFormUnit(ISession session)
        {
            InitializeComponent();
            nhibernate_session = session;
            LoadBooks();
        }


        // Загрузка списка книг
        private void LoadBooks()
        {
            try
            {
                if (nhibernate_session != null)
                {
                    // Загружаем ТОЛЬКО обычные книги, исключая ретро-книги
                    // Используем HQL для явного указания типа
                    books = nhibernate_session.CreateQuery("from Book b where b.book_exist = true")
                        .List<Book>();

                    comboBoxBook.DataSource = books;
                    comboBoxBook.DisplayMember = "book_name";
                    comboBoxBook.ValueMember = "book_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки книг: {ex.Message}");
            }
        }

        public void SetDataSource(Request request)
        {
            this.requestBindingSource.DataSource = request;

            // Если это новая запись (ID = 0), показываем "Новый" в поле ID
            if (request.request_id == 0)
            {
                textBox1.Text = "(Новый)";
                textBox1.Enabled = false;
            }

            // Устанавливаем выбранную книгу в ComboBox
            if (request.book_id > 0 && books != null)
            {
                comboBoxBook.SelectedValue = request.book_id;
            }
        }

        // Возвращаем обновленный объект Request
        public Request GetUpdatedRequest()
        {
            Request request = (Request)this.requestBindingSource.Current;
            if (comboBoxBook.SelectedValue != null)
            {
                request.book_id = (int)comboBoxBook.SelectedValue;
            }
            return request;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Завершаем редактирование
                this.Validate();
                this.requestBindingSource.EndEdit();

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
