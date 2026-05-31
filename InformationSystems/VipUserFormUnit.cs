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
    public partial class VipUserFormUnit : Form
    {
        private ISession nhibernate_session;

        // Конструктор с сессией
        public VipUserFormUnit(ISession session)
        {
            InitializeComponent();
            nhibernate_session = session;
        }

        public void SetDataSource(VipUser vip_user)
        {
            this.vipUserBindingSource.DataSource = vip_user;
            this.userBindingSource.DataSource = vip_user.user_id;
            this.requestBindingSource.DataSource = vip_user.requests;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Редактирование запросов
            RequestFormUnit request_form_unit = new RequestFormUnit(nhibernate_session);
            Request request = MyUtilitis.Clone<Request>((Request)this.requestBindingSource.Current);

            // Если новая запись или нет текущего запроса, создаем новый объект
            if (request == null || request.request_id == 0)
            {
                request = new Request();
                request.request_date = DateTime.Now;
            }

            request_form_unit.SetDataSource(request);

            if (request_form_unit.ShowDialog() == DialogResult.OK)
            {
                Request updatedRequest = request_form_unit.GetUpdatedRequest();

                // Обновляем BindingSource
                int currentPosition = this.requestBindingSource.Position;
                this.requestBindingSource[currentPosition] = updatedRequest;
                this.requestBindingSource.ResetCurrentItem();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Создание нового запроса
            RequestFormUnit request_form_unit = new RequestFormUnit(nhibernate_session);
            Request newRequest = new Request();
            newRequest.request_date = DateTime.Now;

            request_form_unit.SetDataSource(newRequest);

            if (request_form_unit.ShowDialog() == DialogResult.OK)
            {
                // Получаем готовый запрос
                Request createdRequest = request_form_unit.GetUpdatedRequest();

                // Получаем текущего VipUser из основного BindingSource
                VipUser currentVipUser = (VipUser)this.vipUserBindingSource.Current;

                // Устанавливаем связь между запросом и VIP-пользователем
                createdRequest.vip_user = currentVipUser;

                // Добавляем запрос в коллекцию и обновляем BindingSource
                currentVipUser.requests.Add(createdRequest);
                this.requestBindingSource.ResetBindings(false);
            }
        }
    }
}
