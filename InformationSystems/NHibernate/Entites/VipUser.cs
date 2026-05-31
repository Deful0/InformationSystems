using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystems.NHibernate.Entites
{
    public class VipUser
    {
        public virtual int vip_user_id { get; set; }
        public virtual string user_mail { 
            get { return user_id.user_mail; }
            set { user_id.user_mail = value; }
        }
        public virtual string vip_user_name { get; set; }
        public virtual User user_id { get; set; }
        public virtual DateTime vip_user_date_start { get; set; }
        public virtual IList<Request> requests { get; set; }
    }
}
