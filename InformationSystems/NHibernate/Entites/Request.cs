using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystems.NHibernate.Entites
{
    public class Request
    {
        public virtual int request_id { get; set; }
        public virtual int book_id { get; set; }
        public virtual DateTime request_date { get; set; }

        // Связь с VipUser
        public virtual VipUser vip_user { get; set; }
    }
}
