using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AccountType AccountType  { get; set; }
        public int Balace { get; set; }

    }

    public enum AccountType
    {
        Savings ,
        Current ,
    }
}
