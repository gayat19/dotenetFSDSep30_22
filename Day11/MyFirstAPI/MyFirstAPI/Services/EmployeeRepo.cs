using MyFirstAPI.Models;

namespace MyFirstAPI.Services
{
    public class EmployeeRepo : IRepo<int, Employee>
    {
        int num;
        static List<Employee> _employees = new List<Employee>()
        {
            new Employee{Id=101,Name="Ramu",Salary=12345.65f},
            new Employee{Id=102,Name="Somu",Salary=54321.78f}
        };
        public Employee Add(Employee item)
        {
            _employees.Add(item);
            return item;
        }
        public Employee Get(int key)
        {
            var employee = _employees.FirstOrDefault(x => x.Id == key);
            return employee;
        }

        public ICollection<Employee> GetAll()
        {
            return _employees;
        }
       
        public Employee Update(Employee item)
        {
            var employee = Get(item.Id);
            if (employee == null)
                return null;
            employee.Salary = item.Salary;
            employee.Name = item.Name;
            return employee;
        }
        public Employee Delete(int key)
        {
            var employee = Get(key);
            if (employee == null)
                return null;
            _employees.Remove(employee);//Since we are using collections Equals method of teh object has tobe overriden
            return employee;
        }
    }
}
