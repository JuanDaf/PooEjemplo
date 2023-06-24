using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEjemplo
{
    internal class Uberpool : Car
    {
        String brand;
        String model;

        public Uberpool(string licence, Account driver, String brand, String model)
            : base(driver, licence)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}
