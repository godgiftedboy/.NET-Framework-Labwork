using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Raj
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> Roll = new List<int>();
            Roll.Add(1);
            Roll.Add(2);
            Roll.Add(3);
            Roll.Add(4);
            Roll.Add(5);
            foreach (int i in Roll) 
            {
                Console.WriteLine("Roll= "+i);
            }
            Console.ReadKey();
        }   
            /*
            //HASH TABLE
            Hashtable ht = new Hashtable();
            ht.Add("College", "BMC");
            ht.Add("Mobile", 9841);
            ht.Add("IsMarried?", false);
            foreach(var item in ht.Keys)
            {
                Console.WriteLine("Key is: {0} and value is {1}",item,ht[item]);
            }
            */
           /*
            //ARRAY LIST
            ArrayList mylist = new ArrayList();
            mylist.Add("RAK");
            mylist.Add("Shyan");
            mylist.Add(1);
            mylist.Add(true);
            mylist.Add(123);
            foreach (var item in mylist) 
            {
                Console.WriteLine(item);
            }
           */
            /*
            //INDEXER
            Indexer indexer=new Indexer();
            indexer[0] = "Raj";
            indexer[1] = "God";
            indexer[2] = "GiFTeD";
            indexer.college = "BMC";
            for(int i = 0; i <= 2; i++) 
            {
                Console.WriteLine(indexer[i]);
                Console.WriteLine("College = " + indexer.college);
            }
            Console.ReadKey();
            */
        /*
        //FUNCTION OVERLOADING
        Animal cow = new Animal();
        cow.WhatIEat();
        cow.WhatIEat("MOMO");
        cow.WhatIEat("Samosa", "Chowmein");
        Console.ReadKey();
        */

        //Person Raj = new Person();
        //Raj.HairColor = "black";
        //Raj.NumberOfEyes = 2;
        //Console.WriteLine("Raj has " + Raj.HairColor + " colored hair");
        //Console.WriteLine("Raj has " + Raj.NumberOfEyes + " Eyes");

        //BitwiseOperator();
        //LogicalOperation();
        //Console.ReadKey();

        static void LogicalOperation()
        {
            Console.WriteLine("Enter College Name:");
            string CollegeName=Console.ReadLine();
            Console.WriteLine("Enter the program name:");
            string programName=Console.ReadLine();
            if (CollegeName.ToUpper()=="BMC" && programName.ToUpper()=="CSIT")
            {
                Console.WriteLine("WELCOME TO LAB");
            }
            else
            {
                Console.WriteLine("You are not permitted to enter CSIT Lab");
            }
        }
        static void BitwiseOperator()
        {
            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
            int and = a & b;
            Console.WriteLine("BitwiseAND operation:");
            Console.WriteLine(and);
            int or = a | b;
            Console.WriteLine("BitwiseOR operation:");
            Console.WriteLine(or);
            int xor = a ^ b;
            Console.WriteLine("BitwiseXOR operation:");
            Console.WriteLine(xor);
            int complement = ~a;
            Console.WriteLine("Complement of first number:");
            Console.WriteLine(complement);
            int shiftleft = a << 3;
            Console.WriteLine("Binary left shift of first number by 3bits");
            Console.WriteLine(shiftleft);
            int shiftright = a >> 2;
            Console.WriteLine("Binary right shift of first number by 2bits");
            Console.WriteLine(shiftright);

        }
       // static void ()
        

        
        
    }
}
