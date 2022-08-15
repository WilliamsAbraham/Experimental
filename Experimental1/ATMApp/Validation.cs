using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public class Validation
    {
        private readonly Account _account;
        private readonly Card _card;
        private readonly int _amount;
        private readonly int _pin;
        private readonly AtmMachine _machine;
        public Validation(Account account, Card card, int pin, int amount, AtmMachine machine)
        {
            _account = account;
            _card = card;
            _pin = pin;
            _amount = amount;
            _machine = machine;
        }

        public bool IsValideCard()
        {
            if (_pin == _card.Pin && _card.ExpiryDate > DateTime.UtcNow)
            return true;
            return false;
        }

        public bool IsWithdrawable()
        {
           if (IsValideCard() && _amount <= _account.Balace)

            return true;
            return false;
        }
        public bool IsDispensable()
        {
            if (_amount <=_machine.AmountAvailable)
                return true;
            return false;
        }
    }
}
