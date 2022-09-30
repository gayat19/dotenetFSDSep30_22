using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private string[] skills { get; set; }
        public Employee()
        {
            skills = new string[3];
        }
        public string this[int index]
        {
            get { return skills[index]; }
            set { skills[index] = value; }
        }

        public int this[string name]
        {
            get {
                int idx = -1;
                for (int i = 0; i < skills.Length; i++)
                {
                    if (skills[i]==name)
                    {
                        idx= i+1;
                        break;
                    }
                }
                return idx;
            }
        }
        public void PrintSkills()
        {
            foreach (var item in skills)
            {
                Console.WriteLine(item);
            }
        }
    }
}
