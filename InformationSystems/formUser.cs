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
    public partial class formUser : Form
    {
        ISession nhibernate_session;
        IList<User> users;

        public formUser()
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
            UpdateUserGrid();
        }

        void UpdateUserGrid()
        {
            // Загрузка данных из базы в массив
            users = nhibernate_session.QueryOver<User>().List<User>();
            this.userBindingSource.DataSource = users;
        }

        private void tsb_back_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Form1"];

            if (main != null)
            {
                main.Show();
            }

            this.Close();
        }

        private void tsb_update_Click(object sender, EventArgs e)
        {
            User user = MyUtilitis.Clone<User>((User)this.userBindingSource.Current);
            UserFormUnit users_form_unit = new UserFormUnit();
            users_form_unit.SetDataSource(user);
            if (users_form_unit.ShowDialog() == DialogResult.OK)
            {
                // Сохранение изменений
                nhibernate_session.Merge(user);
                // Внесение в базу
                nhibernate_session.Flush();

                // Обновление данных
                UpdateUserGrid();
            }
        }

        private void tsb_create_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserFormUnit users_form_unit = new UserFormUnit();
            users_form_unit.SetDataSource(user);
            if (users_form_unit.ShowDialog() == DialogResult.OK)
            {
                // Сохранение изменений
                nhibernate_session.Merge(user);
                // Внесение в базу
                nhibernate_session.Flush();

                // Обновление данных
                UpdateUserGrid();
            }
        }

        // Удаленмие
        private void tsb_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Действительно удалить?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            User user = (User)this.userBindingSource.Current;
            nhibernate_session.Delete(user);
            nhibernate_session.Flush();

            // Обновление данных
            UpdateUserGrid();
        }
    }
}
