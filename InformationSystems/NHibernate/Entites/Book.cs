using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystems.NHibernate.Entites
{
    public class Book
    {
        public virtual int book_id { get; set; }
        public virtual string book_name { get; set; }
        public virtual string book_author { get; set; }
        public virtual DateTime book_date { get; set; }
        public virtual int book_count_list { get; set; }
        public virtual Boolean book_exist { get; set; }
    }
}
