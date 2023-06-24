using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PooEjemplo
{
    internal class User : Account
    {
        public User(String name, String document) :base(name, document){ }
    }
}
