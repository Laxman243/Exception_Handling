using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace ConsoleApp3
{
    [Serializable]
    class SerializationSample
    {
        public int i;
        public string Name;


        static void Main(string[] args)
        {
            SerializationSample ss = new SerializationSample();
            ss.i = 10;
            ss.Name = "laxman";

            IFormatter formater = new BinaryFormatter();
            Stream fs = new FileStream("F:\\myC#.net_Progrmas\\Serial.txt", FileMode.OpenOrCreate, FileAccess.Write);

            formater.Serialize(fs, ss);
            fs.Close();

            //now deserialization
            Stream fs1 = new FileStream("F:\\myC#.net_Progrmas\\Serial.txt", FileMode.Open, FileAccess.Read);
            SerializationSample ss1 = (SerializationSample)formater.Deserialize(fs1);
            Console.WriteLine(ss1.i);
            Console.WriteLine(ss1.Name);
            Console.Read();
        }
    }
    // using exception handling 
    [Serializable]
    class ExceptionSerialization
    {
        public string Name;
        public string Student;
        public string Job;

        static void Main(string[] args)
        {
            ExceptionSerialization es = new ExceptionSerialization();
            es.Name = "laxmna";
            es.Student = "B.TECH";
            es.Job = "SoftwareEngineer";
            try
            {
                IFormatter IF = new BinaryFormatter();
                Stream obj = new FileStream("F:\\myC#.net_Progrmas\\Serial2.txt", FileMode.OpenOrCreate, FileAccess.Write);


                IF.Serialize(obj, es);
                obj.Close();
                // deserialization 
                Stream obj1 = new FileStream("F:\\myC#.net_Progrmas\\Serial2.txt", FileMode.Open);
                ExceptionSerialization Es = (ExceptionSerialization)IF.Deserialize(obj1);
                Console.WriteLine(Es.Name);
                Console.WriteLine(Es.Student);
                Console.WriteLine(Es.Job);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                Console.WriteLine("Deserialization completed");
            }
            Console.Read();
        }
    }
    // SERIALIZATION IN XML FILE
    [XmlRoot("Employees", Namespace = "www.employesez.com")]
    public class Employees
    {
        [XmlAttribute("EmployeesID")]
        public int id { get; set; }
        [XmlElement("FullName")]
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        [XmlIgnore]
        public string LastName { get; set; }
    }

    public class XmlSerialization
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees();
            emp.id = 10;
            emp.Name = "laxman";
            emp.DoB = DateTime.Now;
            emp.LastName = "shukla";

            string s1 = @"F:\myC#.net_Progrmas\xml1.xml";
            string fileName = s1;

              TextWriter tx = new StreamWriter(fileName);
              XmlSerializer ser = new XmlSerializer(typeof(Employees));
              ser.Serialize(tx, emp);
              tx.Close();
              Console.Read();
          }
        /*
            XmlSerializer desr = new XmlSerializer(typeof(Employees));
            using (XmlReader reader = XmlReader.Create(s1 + @"F:\myC#.net_Progrmas\xml1.xml"))
            {
                emp = (Employees)desr.Deserialize(reader);
                Console.WriteLine(emp.id + " " + emp.Name + " " + emp.DoB + " " + emp.LastName);
                Console.Read();
            }
        }*/
    }
}
