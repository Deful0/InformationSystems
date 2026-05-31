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
    public partial class UserSelectionDialog : Form
    {
        public UserSelectionDialog()
        {
            InitializeComponent();
        }

        // Заоплнение выпадающего списка
        public void SetDataSource(IList<User> users)
        {
            this.userBindingSource.DataSource = users;
        }
        public User seceted_user
        {
            get
            {
                return (User)this.comboBox1.SelectedItem;
            }
        }
    }
}
