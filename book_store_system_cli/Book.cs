using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store_system_cli
{
    internal class Book
    {
        public string serie_No, title, author, publisher;
        public DateTime public_Date;
        public void Add(string serie_No, string title, string author, string publisher, DateTime public_Date)
        {
            this.author = author;
            this.publisher = publisher;
            this.public_Date = public_Date;
            this.title = title;
            this.serie_No = serie_No;
        }
    }
}
