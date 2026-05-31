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
        public virtual string vip_user_name { get; set; }
        public virtual User user_id { get; set; }
        public virtual DateTime vip_user_date_start { get; set; }
        public virtual IList<Request> requests { get; set; }

        // Вычисляемое свойство 
        public virtual string user_mail
        {
            get { return user_id != null ? user_id.user_mail : string.Empty; }
            set { } 
        }
    }
}
