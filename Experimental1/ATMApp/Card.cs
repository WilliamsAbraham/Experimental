using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public class Card
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CardNumber { get; set; }
        public int Pin { get; set; }
        public DateTime ExpiryDate { get; set; }
       

    }
}
