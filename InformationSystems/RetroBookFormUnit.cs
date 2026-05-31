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

namespace InformationSystems.NHibernate.Entites
{
    public partial class RetroBookFormUnit : Form
    {
        public RetroBookFormUnit()
        {
            InitializeComponent();
        }

        public void SetDataSource(RetroBook retro_book)
        {
            this.retroBookBindingSource.DataSource = retro_book;
        }
    }
}
