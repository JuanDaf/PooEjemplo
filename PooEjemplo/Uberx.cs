using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEjemplo
{
    internal class Uberx : Car 
    {
        public String brand;
        public String model;

        public Uberx(string licence, Account driver , String brand, String model)
            : base(driver, licence)
        {
            this.brand = brand;
            this.model = model;
        }

        public override void  Imprimir() 
        {
            base.Imprimir();
            Console.WriteLine("Modelo: " + model + " Marca: " + brand);
            
        }

    }
}
