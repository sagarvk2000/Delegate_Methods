using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Methods
{
    public class Program
    {
        static void Insufficient_balanceMessage()
        {
            Console.WriteLine("Insufficient balance");
        }
        static void Low_balanceMessage()
        {
            Console.WriteLine("Low balance");
        }
        static void Zero_balanceMessage()
        {
            Console.WriteLine("Zero balance");
        }
        static void Main(string[] args)
        {
            //Events
            Bank b = new Bank();
            b.Insufficient_balance += new DelegateBank(Insufficient_balanceMessage);
            b.Low_balance += new DelegateBank(Low_balanceMessage);
            b.Zero_balance += new DelegateBank(Zero_balanceMessage);

            Console.WriteLine(b);

            b.Debit(5000);
            Console.WriteLine(b);
            b.Credit(4000);
            Console.WriteLine(b);



            
            //Singlecast Delegate
            //Calculation c = new Calculation();
            //Delegate d = new Delegate(c.Add);

            //Console.WriteLine(d.Invoke(20,100));

            //Test test = new Test();

            //Delegate1 d1 = new Delegate1(test.AcceptDetails);
            //d1.Invoke(1, "sagar", 45000);

            //Multicaste Delegate

            //Calculation c = new Calculation();
            //MyDelegate d = new MyDelegate(c.Add); //add ref of Add

            ////+= add ref in the invocation method
            //d += new MyDelegate(c.Sub);
            
            ////-=
            //Delegate[] list = d.GetInvocationList(); 
            //foreach (Delegate a in list)
            //{
            //    Console.WriteLine(a.Method);
            //    Console.WriteLine(a.DynamicInvoke(40,20));
            //}



        }
    }
}
