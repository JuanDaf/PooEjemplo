using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEjemplo
{
    internal class Car
    {
        private int id { get; set; }
        private String licence { get; set; }
        private Account driver { get; set; }
        private int passengenger;

        public Car(Account driver, String licence)
        {
            this.driver = driver;
            this.licence = licence;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine("Condctor: " + driver.name + " Matricula: " + licence + " Pasajeros: " + passengenger);
             
        }

        public virtual int getPassenger()
        {
            return passengenger;
        }

        public virtual void setPassenger(int passengenger)
        {
            if (passengenger == 4 )
            {
                this.passengenger = passengenger;
            }
            else
            {
                Console.WriteLine("Deben ser 4 pasajeros");
            }
        }
    }
}
