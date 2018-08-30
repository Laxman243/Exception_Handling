using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //SIMPLE PROGRAM TO SHOW IF USER ENTER WRONG INPUT THEN HOW EXCEPTION WILL OCCUR
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter the 1st number :");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter the 2nd Number :");
                int y = int.Parse(Console.ReadLine());
                 int z = x / y;
            Console.WriteLine("Result is  : " + z);
                Console.WriteLine("end of the program");
                Console.ReadKey();

        }
    }
    class TryCatchDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the 1st number :");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter the 2nd Number :");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The Result is :" + z);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
           /* catch (OverflowException ex3)
            {
                Console.WriteLine("Numeric Value is too large");
            }*/
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("end of the program");
            Console.ReadKey();

        }
    }
    class TryFinallyDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter the 1st number : ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("enter the 2nd number : ");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The Result is : " + z);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block executed : ");
            }
            Console.WriteLine("End Of the Program");
            Console.Read();
        }
    }
    class SpecialityFinallyBlock
    {
        static void Main()
        {
            try
            {
                Console.Write("enter the 1st number :");
                int x = int.Parse(Console.ReadLine());
                Console.Write("enter the 2nd number :");
                int y = int.Parse(Console.ReadLine());
                // now put a condition like ,
                // if user enters the value 1 then the if condition should execute and return the program
                // remember returns is an jump stmt it takes the flow of your program to end of the program
                // it will makes your remainig code will not execute, if return execute , that scenario
                
                // finally block comes into power mechanism , even though your program is returning at end of the progrma
                // the finally block will excute , HOW LETS SEE IN THIS EXAMPLE
                if( y == 1)
                {
                    return;
                }
                int z = x / y;
                Console.WriteLine("The Result is :" + z);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
                Console.Read();
            }
            Console.WriteLine("End Of The Program");
            
        }
    }
    class ThrowDemo
    {
        static void Main()
        {

            Console.Write("enter the 1st number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("enter the 2nd number : ");
            int y = int.Parse(Console.ReadLine());
            if( y % 2 > 0)
            {
                throw new ApplicationException("Divisor value can't be greater than 0");
            }
            int z = x / y;
            Console.WriteLine("The Result is : " + z);
            Console.WriteLine("End Of The Program");
            Console.Read();
        }
    }
    //EXAMPLE OF CUSTOM / OUR OWN APPLICATION EXCEPTION
    public class DivideByNoException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to Divide By Odd Number"; 
            }
        }
    }
    class CustomExceptionExample
    {
        static void Main(string[] args)
        {
            Console.Write("enter the 1st Number : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd Number : ");
            int y = int.Parse(Console.ReadLine());

            if ( y % 2 > 0)
            {
                throw new DivideByNoException();
            }
            int z = x / y;
            Console.WriteLine("the result is : " + z);
            Console.WriteLine("End Of The Program ");
            Console.Read();
        }
    }
    class CheckedExample
    {    

        //FIRST DO CHECKED EXCEPTION WITHOUT USING CHECKED KEYWORD
        static void Main(string[] args)
        {
            // SECOND WITH CHECKED KEYWORD
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2); // after keeping checked keyword it will checked at compile time and clr will throw exception
            }
        }

    }
    
    class UncheckedExample
    {
        static void Main()
        {
            unchecked // in unchecked it wont check the overflow value and print the output
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
    }
}
