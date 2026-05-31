using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystems.NHibernate.Entites
{
    public class User
    {
        public virtual int user_id { get; set; }

        public virtual string user_name { get; set; }
        public virtual string user_mail { get; set; }
        public virtual string user_phone { get; set; }
        public virtual DateTime user_registration { get; set; }

    }
}
