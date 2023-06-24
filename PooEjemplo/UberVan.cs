using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PooEjemplo
{
    internal class Ubervan : Car
    {
        Dictionary<String, Dictionary<String, int>> typecar;
        List<String> seatsMaterial;
        private int passengenger;
        public Ubervan(string licence, Account driver, Dictionary<String, Dictionary<String, int>> typecar, List<String> seatsMaterial)
            : base(driver, licence )
        {
            this.seatsMaterial = seatsMaterial;
            this.typecar = typecar;
        }
        
        public override void setPassenger(int passengenger)
        {
            if (passengenger == 6)
            {
                this.passengenger = passengenger;
            }
            else
            {
                Console.WriteLine("Deben ser 6 pasajeros");
            }
        }

        public override int getPassenger()
        {
            return base.getPassenger();
        }

        public override void Imprimir()
        {
            Console.WriteLine("Material:" + seatsMaterial.FirstOrDefault() + " Tipo: "+ typecar.Keys.First() + " " + typecar.Values.First().Keys.First() + " : "+ typecar.Values.First().Values.First());
            base.Imprimir();
        }

    }
}
