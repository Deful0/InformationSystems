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

namespace InformationSystems.NHibernate.Entites
{
    public partial class RetroBookListUnit : Form
    {
        ISession nhibernate_session;
        IList<RetroBook> retro_books;

        public RetroBookListUnit()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);

            string dbPath = System.IO.Path.Combine(Application.StartupPath, "Example_1.accdb");
            if (!System.IO.File.Exists(dbPath))
                MessageBox.Show("Файл БД НЕ НАЙДЕН по пути: " + dbPath);

            InitializeComponent();

            // Инициализация Nhibernate, создание сессии
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("InformationSystems");
            nhibernate_session = c.BuildSessionFactory().OpenSession();

            // Выполнить загрузку данных в DataGridView
            UpdateRetroBookGrid();
        }

        void UpdateRetroBookGrid()
        {
            // Загрузка из db все retro книги в виде списка
            retro_books = nhibernate_session.QueryOver<RetroBook>().List<RetroBook>();
            this.retroBookBindingSource.DataSource = retro_books;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // возвращение к main форме
            Form main = Application.OpenForms["Form1"];

            if (main != null)
            {
                main.Show();
            }

            this.Close();
        }

        private void tsb_update_Click(object sender, EventArgs e)
        {
            RetroBook retro_book = MyUtilitis.Clone<RetroBook>((RetroBook)this.retroBookBindingSource.Current);
            RetroBookFormUnit retro_book_form_unit = new RetroBookFormUnit();
            retro_book_form_unit.SetDataSource(retro_book);
            if (retro_book_form_unit.ShowDialog() == DialogResult.OK)
            {
                // Сохранение изменений
                nhibernate_session.Merge(retro_book);
                // Внесение в базу
                nhibernate_session.Flush();
                // Обновление данных
                UpdateRetroBookGrid();
            }
        }

        private void tsb_create_Click(object sender, EventArgs e)
        {
            RetroBook retro_book = new RetroBook();
            RetroBookFormUnit retro_book_form_unit = new RetroBookFormUnit();
            retro_book_form_unit.SetDataSource(retro_book);
            if (retro_book_form_unit.ShowDialog() == DialogResult.OK)
            {
                // Сохранение изменений
                nhibernate_session.Merge(retro_book);
                // Внесение в базу
                nhibernate_session.Flush();
                // Обновление данных
                UpdateRetroBookGrid();
            }
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Действительно удалить?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            
            // Получение объекта, выделенным пользователем
            RetroBook retro_book = (RetroBook)this.retroBookBindingSource.Current;
            
            // Удаление объекта
            nhibernate_session.Delete(retro_book);
            nhibernate_session.Flush();

            // Обновление данных
            UpdateRetroBookGrid();
        }
    }
}
