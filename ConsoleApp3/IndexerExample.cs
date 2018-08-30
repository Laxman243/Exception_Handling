using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee
    {
        int Eno;
        string EName;
        string Job;
        string DName;
        string Location;
        double Salary;

        public Employee(int Eno,string EName, string Job, string DName, string Location, double Salary)
        {
            this.Eno = Eno;
            this.EName = EName;
            this.Job = Job;
            this.DName = DName;
            this.Location = Location;
            this.Salary = Salary;
        }

        public object this[int index] // indexer implemented
        {
            // getting values 
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return EName;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return DName;
                else if (index == 4)
                    return Location;
                else if (index == 5)
                    return Salary;
                return null;
            }

            //Setting Values using int index
            set
            {
                if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    EName = (string)value;
                else if (index == 2)
                    Job = (string)value;
                else if (index == 3)
                    DName = (string)value;
                else if (index == 4)
                    Location = (string)value;
                else if (index == 5)
                    Salary = (double)value;
            }
        }
        public object this[string Name]
        {
            get
            {
                if (Name == "Eno")
                    return Eno;
                else if (Name == "EName")
                    return EName;
                else if (Name == "Job")
                    return Job;
                else if (Name == "DName")
                    return DName;
                else if (Name == "Location")
                    return Location;
                else if (Name == "Salary")
                    return Salary;
                return null;
            }
        }
        
    }
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(10, "Laxman", "Software","Eng","Bangalore",13000.9);
            Console.WriteLine("Eno :" + emp[0] );
            Console.WriteLine("EName :" + emp[1]);
            Console.WriteLine("Job :" + emp[2]);
            Console.WriteLine("DName :" + emp[3]);
            Console.WriteLine("Location :" + emp[4]);
            Console.WriteLine("Salary :" + emp[5]);

            // values modifications
             Console.WriteLine("======================After Change===============");
             Console.WriteLine("Eno :" + emp["Eno"]);
             Console.WriteLine("EName :" + emp["EName"]);
             Console.WriteLine("Job :" + emp["Job"]);
             Console.WriteLine("DName :" + emp["DName"]);
             Console.WriteLine("Location :" + emp["Location"]);
             Console.WriteLine("Salary :" + emp["Salary"]);
            Console.ReadLine();
        }
    }
}
