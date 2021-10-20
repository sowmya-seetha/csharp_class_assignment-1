using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Q7
    {
        int rollno;
        String sname;
        double meng;
        double mmat;
        double msci;
        double sum;
        double p;
        public void total(double e,double m,double s)
        {
            sum = e + m + s;
            Console.WriteLine("Total Marks: " + sum);
        }
          public void percentage()
        {
            p = (sum * 100) / 300;

            Console.WriteLine("Total Percentage: " + p);
        }
        static void Main()
        {
            Q7 a = new Q7();
            Console.WriteLine("Enter your roll no");
            a.rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name");
            a.sname = (Console.ReadLine());
            Console.WriteLine("Enter your marks in english");
            a.meng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your marks in maths");
            a.mmat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your marks in science");
            a.msci = Convert.ToDouble(Console.ReadLine());
            a.total(a.meng,a.mmat,a.msci);
            a.percentage();
        }
    }
}
