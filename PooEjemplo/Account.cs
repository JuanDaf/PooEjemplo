using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PooEjemplo
{
    internal class Account
    {
        public String id;
        public String document;
        public String name;
        public String email;
        public String password;

        public Account(String name, String document)
        {
            this.name = name;   
            this.document = document;
        }

        public void mostrar()
        {
            Console.WriteLine("Nombre: "+ name+ " Documento: "+document );
            Console.ReadKey();
        }
    }
}
