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
        public RequestFormUnit()
        {
            InitializeComponent();
        }

        public void SetDataSource(Request request)
        {
            this.requestBindingSource.DataSource = request;
        }
    }
}
