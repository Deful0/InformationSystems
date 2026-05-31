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

        public RequestFormUnit()
        {
            InitializeComponent();
        }

        public RequestFormUnit(ISession session)
        {
            InitializeComponent();
            nhibernate_session = session;  // Сохраняем сессию
            LoadBooks();                   // Загружаем книги
        }


        // Загрузка списка книг
        private void LoadBooks()
        {
            try
            {
                if (nhibernate_session != null)
                {
                    books = nhibernate_session.QueryOver<Book>().List<Book>();

                    comboBoxBook.DataSource = books;
                    comboBoxBook.DisplayMember = "book_name";
                    comboBoxBook.ValueMember = "book_id";
                    comboBoxBook.DropDownStyle = ComboBoxStyle.DropDownList;
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

            // Очищаем старые привязки, чтобы избежать дублирования
            comboBoxBook.DataBindings.Clear();
            comboBoxBook.DataBindings.Add("SelectedValue", requestBindingSource, "book_id", true, DataSourceUpdateMode.OnPropertyChanged);

            if (request.request_id == 0)
            {
                textBox1.Text = "(Новый)";
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Text = request.request_id.ToString();
                textBox1.Enabled = false;
            }
        }

        // Возвращаем обновленный объект Request
        public Request GetUpdatedRequest()
        {
            this.Validate();
            this.requestBindingSource.EndEdit();
            return (Request)this.requestBindingSource.Current;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
