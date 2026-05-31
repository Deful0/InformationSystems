using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystems.NHibernate.Entites
{
    public class RetroBook: Book
    {
        public virtual int retro_book_price { get; set; }

    }
}
