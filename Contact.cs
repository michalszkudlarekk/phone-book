using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Contact
    {
        public Contact ( string fullName, string number)
        {
            FullName = fullName;
            Number = number;
        }
        public string FullName { get; set; }
        public string Number { get; set; }
        public object Name { get; internal set; }
    }
}
