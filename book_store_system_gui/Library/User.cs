using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store_system_gui.Library
{
    internal class User : Account
    {
        Account Account { get; set; }
        public User() { }
    }
}
