using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationSystems.NHibernate.Entites;

namespace InformationSystems
{
    public partial class UserFormUnit : Form
    {
        public UserFormUnit()
        {
            InitializeComponent();
        }

        public void SetDataSource(User user)
        {
            this.userBindingSource.DataSource = user;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
