using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEjemplo
{
    internal class Uberblack : Car
    {
        Dictionary<String, Dictionary<String, int> > typecar;
        List<String> seatsMaterial;
        
        public Uberblack(string licence, Account driver, Dictionary<String, Dictionary<String, int>> typecar, List<String> seatsMaterial)
            : base(driver, licence)
        {
            this.seatsMaterial= seatsMaterial;
            this.typecar= typecar;
        }
    }
}
