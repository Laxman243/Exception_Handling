using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class SerializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\myC#.net_Progrmas\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = new Student(101, "sonoo");
            formatter.Serialize(stream, s);
            Console.Read();

            stream.Close();
        }
    }
    //DESERIALIZATION
    
    /*class Student1
    {
        public int rollno;
        public string name;
        public Student1(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }*/
    public class DeserializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\myC#.net_Progrmas\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);
            Console.Read();
            stream.Close();
        }
    }
    
}
