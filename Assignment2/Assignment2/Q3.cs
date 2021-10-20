using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Q3
    {
        int rollno;
        string name;
        int clas;
        int sem;
        String branch;
        int sum = 0;
        int[] marks=new int[5];
        public Q3(int rollno,string name,int clas,int sem,string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.clas = clas;
            this.sem = sem;
            this.branch = branch;
        }
        public void displayresult(int[] marks)
        {
            bool flag2 = true;
            int avg;
            for(int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    flag2 = false;
                    
                   
                }
                else
                {
                    sum = sum + marks[i];
                }
            }
            avg = sum / 5;
            if(flag2==false)
                Console.WriteLine("You are failed");
            else if (avg<50)
                Console.WriteLine("You are failed");
            else
                Console.WriteLine("You are passed");

        }
        public void displaydata()
        {
            Console.WriteLine("Roll Number: " + rollno);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Class: " + clas);
            Console.WriteLine("Semester: " +sem);
            Console.WriteLine("Branch: " + branch);
            Console.WriteLine("Total Marks: " + sum);
            
        }
        static void Main() {
            Q3 a = new Q3(12345678, "Ram", 15, 2, "IT");

            Console.WriteLine("Enter five subjects marks");
            for(int i = 0; i < 5; i++)
            {
                a.marks[i] = int.Parse(Console.ReadLine());
                
            }
            a.displayresult(a.marks);
            a.displaydata();

        }
    }
}
