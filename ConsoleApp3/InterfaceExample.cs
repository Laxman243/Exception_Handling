using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    // first interface
   public interface Drawable
    {
        void Shape();
    }
    // interface inheritance
   public interface Circles : Drawable
    {
        void Shapes();
    }
    public interface Cls : Circles
    {

    }
   public  class InterfaceExample : Circles , Drawable
    {
        public void Shape()
        {
            Console.WriteLine("from Drawable Shape Method");
        }
        public void Shapes()
        {
            Console.WriteLine("from circles Shapes Method");
        }
        static void Main()
        {
            InterfaceExample i = new InterfaceExample();
            i.Shape();
            i.Shapes();
            Console.Read();
        }
    }
    //Explicit Interface
    interface I1
    {
        void Same();
    }
    interface I2
    {
        void Same();
    }
    public class InterfaceProgram : I1, I2
    {
        void I1.Same()
        {
            Console.WriteLine("From the I1 Method");
        }
        void I2.Same()
        {
            Console.WriteLine("From the I2 Method");
        }
        static void Main()
        {
            InterfaceExample obj = new InterfaceExample();
            ((I1)obj).Same();
            ((I2)obj).Same();
            Console.Read();
        }
    }

}
