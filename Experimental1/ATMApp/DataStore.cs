using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public static class DataStore
    {
        private static readonly List<Card> cards;
        private static readonly List<Account> accounts;
        private static readonly AtmMachine machine;
         static DataStore()
        {
            accounts = new List<Account>
            { new Account { Id = 1, Name = "Abraham", AccountType = AccountType.Current, Balace = 200000 },
              new Account { Id = 2, Name = "Williams", AccountType = AccountType.Savings, Balace = 100000 }
            };
            cards = new List<Card>
            {
                new Card { Id = 3, CardNumber = "12345", CustomerName = "Abraham", Pin = 1234, ExpiryDate = new DateTime(2023, 6, 10)},
                new Card { Id = 4,CardNumber = "56789", CustomerName = "Williams", Pin = 5678, ExpiryDate = new DateTime(2023, 6, 10)}
            };
            machine = new AtmMachine { Id = 1, Bank = "FineBank", Branch = "Surulere", AmountAvailable = 300000 };
        }
        public static List<Card> Cards { get { return cards;}}
        public static List<Account> Accounts { get {return accounts;}}
        public static AtmMachine Machine { get { return machine;}}
    
    }
}
