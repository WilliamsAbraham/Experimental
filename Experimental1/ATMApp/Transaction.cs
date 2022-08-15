using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public static class Transactions
    {
        public static void Withdraw()
        {
            try
            {
                int trial = 4;
                while(trial >= 0)
                {
                    Console.WriteLine("your pin");
                    int pin = int.Parse(Console.ReadLine());
                    Console.WriteLine("amount");
                    int amount = int.Parse(Console.ReadLine());
                    var card = DataStore.Cards.Find(x => x.Pin == pin);
                    var atmMachine = DataStore.Machine;
                    if (card == null)
                    { Console.WriteLine("invalidCard, Please input a correct pin"); }
                    else
                    {
                        var account = DataStore.Accounts.Find(x => x.Name == card.CustomerName);
                        Validation validation = new Validation(account, card, pin, amount, atmMachine);
                        if (!validation.IsDispensable())
                        {
                            Console.WriteLine("Unable To Dispense Cash");
                        }
                        else
                        {
                            if (!validation.IsWithdrawable())
                            {
                                Console.WriteLine("Insufficient fund");
                            }
                            else
                            {
                                Console.WriteLine("Transaction in Progress");
                                account.Balace -= amount;
                                atmMachine.AmountAvailable -= amount;
                                Console.WriteLine("Transaction Receipt");
                                Console.WriteLine($"Account ..................{account.Name}\n" +
                                    $"Amount Withdrawn ......................{amount}\n" +
                                    $"Balance ...............................{account.Balace}\n" +
                                    $"Date ...................................{DateTime.UtcNow}");
                                Console.WriteLine("Input your pin to continue");
                                

                            }
                        }

                    }
                    trial--;
                }
                Console.WriteLine("You have exceeded the number of trial and can no longer proceed, please visite you bank to resolve");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }

        }
    }
}