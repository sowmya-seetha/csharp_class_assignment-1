using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    

    class Q6
    {
        String dname;
        int accno;
        String acctype;
        int bal=10000;
        int amt;
        public void debit(int w)
        {if (bal > w)
                bal -= w;
            else
                Console.WriteLine("Your account doesn't have enough balance");
        }

        public void credit(int d)
        {
            bal += d;
        }
        public void accept(int accno, String dname, String acctype)
        {
            this.accno = accno;
            this.dname = dname;
            this.acctype = acctype;
        }
        public void display()
        {
            Console.WriteLine("Depositorname: " + dname);
            Console.WriteLine("Balance: " + bal);

        }
        static void Main()
        {
            Q6 a = new Q6();
            a.accno = 100025346;
            a.dname = "Ram";
            a.acctype = "SalaryAccount";
            a.accept(a.accno, a.dname, a.acctype);
            Console.WriteLine("Enter Transaction type?(d/w)");
            String type = Console.ReadLine();
            if (type.Equals("d"))
            {
                Console.WriteLine("Enter amount to deposit");
                a.amt = int.Parse(Console.ReadLine());
                a.credit(a.amt);
            }
            if (type.Equals("w"))
            {
                Console.WriteLine("Enter amount to Withdraw");
                a.amt = int.Parse(Console.ReadLine());
                a.debit(a.amt);
            }
            a.display();

        }
    }
}
