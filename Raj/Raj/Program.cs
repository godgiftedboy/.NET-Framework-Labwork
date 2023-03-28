using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Raj = new Person();
            Raj.HairColor = "black";
            Raj.NumberOfEyes = 2;
            Console.WriteLine("Raj has " + Raj.HairColor + " colored hair");
            Console.WriteLine("Raj has " + Raj.NumberOfEyes + " Eyes");
            //BitwiseOperator();
            //LogicalOperation();
            Console.ReadKey();
        }
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
