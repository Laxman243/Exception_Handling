using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Shape // FIRST ABSTRACT CLASS
    {
        public abstract void draw();
    }
    public class Rectangle : Shape  // PROVIDING IMPLEMENTATION OF ABSTRACT METHOD
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Shape 
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestAbstract
    {
        public static void Main()
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.Read();
        }
    }

    // SECOND EXAMPLE
    public abstract class Rose
    {
        public int i = 0;
        public int L()
        {
            return 10;
        }
        public abstract void Smell();
        public abstract void Small();
    }
   public class RoseExample : Rose
    {
        public override void Smell()
        {
            Console.WriteLine("output Form the Smell Method :");
        }
        public override void Small()
        {
            Console.WriteLine("output from the Small Method");   
        }
    }

    public abstract class Flower
    {
        public abstract void Jump();
        public abstract int High();
    }
    class FlowerExample : Flower
    {
        public override void Jump()
        {
            Console.WriteLine("Output from the jump Methods");
        }
        public override int High()
        {
            Console.WriteLine("Output from the High method");
            return 10;
        }
       
    }

 // Object class
    public class Abstract1 
    {
 
        static void Main(string[] args)
        {
            RoseExample rs = new RoseExample();
            rs.Smell();
            rs.Small();

            FlowerExample fs = new FlowerExample();
            fs.High();
            fs.Jump();
            Console.Read();
        }
    }
}
