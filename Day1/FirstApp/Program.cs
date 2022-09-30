using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee() { Id = 1,Name="Ramu" };
            employee[0] = "C";
            employee[1] = "Java";
            employee[2] = "C#";
            employee.PrintSkills();
            Console.WriteLine("employee skill Java position " + employee["Java"]);
            Console.ReadKey();
        }
    }
}
