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
        public VipUserFormUnit()
        {
            InitializeComponent();
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
            RequestFormUnit request_form_unit = new RequestFormUnit();
            Request request = MyUtilitis.Clone<Request>((Request)this.requestBindingSource.Current);
            //Request request = (Request)this.requestBindingSource.Current;
            request_form_unit.SetDataSource(request);
            if (request_form_unit.ShowDialog() == DialogResult.OK)
            {
                this.requestBindingSource[this.requestBindingSource.Position] = request;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Редактирование запросов
            RequestFormUnit request_form_unit = new RequestFormUnit();
            Request request = (Request)this.requestBindingSource.Current;
            request_form_unit.SetDataSource(request);
            if (request_form_unit.ShowDialog() == DialogResult.OK)
            {
                this.requestBindingSource[this.requestBindingSource.Position] = request;
            }
        }
    }
}
