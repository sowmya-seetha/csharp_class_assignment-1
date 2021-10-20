using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Q4
    {
        
        static void Main()
        {
            Console.WriteLine("Enter the Book name:");
            String bookname = Console.ReadLine();

            Console.WriteLine("Enter the price:");
            int price = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter the Author name:");
            String authorname = Console.ReadLine();
            Console.WriteLine("Enter the quantity of books:");
            int no = int.Parse(Console.ReadLine());
            int tot = no * price;
            Console.WriteLine("Book Details");
            Console.WriteLine("Book Name :" + bookname);
            Console.WriteLine("Total Book Price :" + tot);
            Console.WriteLine("Author Name :" + authorname);

        }
    }
}
