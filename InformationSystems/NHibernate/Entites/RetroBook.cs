using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystems.NHibernate.Entites
{
    public class RetroBook: Book
    {
        //public virtual int retro_book_id { get; set; }
        //public virtual int book_id { get; set; }
        public virtual string retro_book_name { get; set; }
        public virtual int retro_book_price { get; set; }

    }
}
