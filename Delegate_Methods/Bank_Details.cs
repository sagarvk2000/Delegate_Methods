using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a Bank class
Initialize balance in the constructor
Class must have two methods 1. Credit 2. Debit
If User debit the amount which is greater than balance , raise an event “Insufficient balance”
If balance is less than 3000, raise an event “Low_balance”
If balance is zero then raise an event “Zero_balance”

Credit will add amount to the balance*/

namespace Delegate_Methods
{
    public delegate void DelegateBank();
    public class Bank
    {
        public event DelegateBank Insufficient_balance;
        public event DelegateBank Low_balance;
        public event DelegateBank Zero_balance;

        private int balance;

        public Bank()
        {
            balance = 20000;
        }

        public void Credit(int amount)
        {
            balance += amount;
        }

        public void Debit(int amount)
        {
            if (amount > balance)
            {
                Insufficient_balance();
            }
            else if (balance > amount)
            {
                balance = balance - amount;
                
                    if(balance == 0)
                    {
                        Zero_balance();
                    }
                    else if (balance < 3000)
                    {
                        Low_balance();
                    }
                
            }           
        }
        public override string ToString()
        {
            return $"{balance}";
        }
    }
}
