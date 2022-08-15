using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public class AtmMachine
    {
        public int Id { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public int AmountAvailable { get; set; }
    }
}
