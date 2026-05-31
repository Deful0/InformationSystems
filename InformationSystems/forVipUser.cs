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
    public partial class forVipUser : Form
    {
        ISession nhibernate_session;
        IList<VipUser> vip_users;
        public ISession NhibernateSession => nhibernate_session;

        public forVipUser()
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
            UpdateVipUserGrid();
        }

        void UpdateVipUserGrid()
        {
            // Загрузка данных из базы в массив
            vip_users = nhibernate_session.QueryOver<VipUser>().List<VipUser>();
            this.vipUserBindingSource.DataSource = vip_users;
        }

        private void forVipUser_Load(object sender, EventArgs e)
        {

        }

        private void tsb_back_Click(object sender, EventArgs e)
        {
            // Сохранение данных
            this.vipUserBindingSource.EndEdit();            // синхронизируем данные с объектом
            this.Validate();

            foreach (VipUser vip_user in vip_users)
                nhibernate_session.SaveOrUpdate(vip_user);
            nhibernate_session.Flush();                     // Сохранение изменений в db


            // возвращение к main форме
            Form main = Application.OpenForms["Form1"];

            if (main != null)
            {
                main.Show();
            }

            this.Close();
        }

        private void tsb_change_Click(object sender, EventArgs e)
        {
            try
            {
                VipUser vip_user = MyUtilitis.Clone<VipUser>((VipUser)this.vipUserBindingSource.Current);
                VipUserFormUnit vip_users_form_unit = new VipUserFormUnit(nhibernate_session);
                vip_users_form_unit.SetDataSource(vip_user);

                if (vip_users_form_unit.ShowDialog() == DialogResult.OK)
                {
                    using (var transaction = nhibernate_session.BeginTransaction())
                    {
                        // Сохраняем VipUser (каскадно сохранятся и Request)
                        nhibernate_session.Merge(vip_user);
                        nhibernate_session.Flush();
                        transaction.Commit();
                    }

                    UpdateVipUserGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_create_Click(object sender, EventArgs e)
        {
            UserSelectionDialog user_selection_dialog = new UserSelectionDialog();
            user_selection_dialog.SetDataSource(nhibernate_session.QueryOver<User>().List<User>());

            if (user_selection_dialog.ShowDialog() == DialogResult.OK)
            {
                VipUser vip_user = new VipUser();

                // Устанавливаем все поля
                vip_user.user_id = user_selection_dialog.seceted_user;
                vip_user.vip_user_name = vip_user.user_id.user_name;
                vip_user.vip_user_date_start = DateTime.Now;
                vip_user.requests = new List<Request>();

                VipUserFormUnit vip_users_form_unit = new VipUserFormUnit(nhibernate_session);
                vip_users_form_unit.SetDataSource(vip_user);

                if (vip_users_form_unit.ShowDialog() == DialogResult.OK)
                {
                    using (var transaction = nhibernate_session.BeginTransaction())
                    {
                        nhibernate_session.SaveOrUpdate(vip_user);
                        nhibernate_session.Flush();
                        transaction.Commit();
                    }
                    UpdateVipUserGrid();
                }
            }
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Действительно удалить?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            VipUser vip_user = (VipUser)this.vipUserBindingSource.Current;
            nhibernate_session.Delete(vip_user);
            nhibernate_session.Flush();

            // Обновление данных
            UpdateVipUserGrid();
        }
    }
}
