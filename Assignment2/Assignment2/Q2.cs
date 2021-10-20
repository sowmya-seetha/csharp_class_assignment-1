using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Q2
    {

       int accno;
        String custname;
        String acctype;
        char transtype;
        int amt;
        int bal=10000;

        

        public void debit(int w)
        {
            bal -= w;
        }

        public void credit(int d)
        {
            bal += d;
        }
        public void accept(int accno, String custname, String acctype) {
            this.accno = accno;
            this.custname = custname;
            this.acctype = acctype;
        }
        public void show()
        {
            Console.WriteLine("Customername: " + custname);
            Console.WriteLine("Account number: " + accno);
            Console.WriteLine("Account type: " + acctype);
            Console.WriteLine("Balance: " + bal);

        }
        static void Main() {
            Q2 a = new Q2();
           a.accno = 100025346;
            a.custname = "Ram";
            a.acctype = "SalaryAccount";
            a.accept(a.accno, a.custname, a.acctype);
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
            a.show();



        
        }
    }
}
