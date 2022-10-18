using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Models;

namespace MyFirstAPI.Services
{
    public class EmployeeDbRepo : IRepo<int, Employee>
    {
        private readonly CompanyContext _context;

        public EmployeeDbRepo(CompanyContext context)
        {
            _context = context;
        }
        public Employee Add(Employee item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                
            }
            return null;
        }

        public Employee Delete(int key)
        {
            var emp = Get(key);
            if(emp != null)
            {
                try
                {
                    _context.Employees.Remove(emp);
                    _context.SaveChanges();
                    return emp;
                }
                catch (Exception e)
                {

                    throw;
                }
            }
            return null;
        }

        public Employee Get(int key)
        {
            var emp = _context.Employees.FirstOrDefault(e => e.Id == key);
            if (emp != null)
            {
                try
                {
                    return emp;
                }
                catch (Exception e)
                {
                }
            }
            return null;
        }

        public ICollection<Employee> GetAll()
        {
            //Eager loading
            var employees = _context.Employees.Include(e=>e.Department).ToList();
            return employees;
        }

        public Employee Update(Employee item)
        {
            var emp = Get(item.Id);
            if (emp != null)
            {
                try
                {
                    emp.Name = item.Name;
                    emp.Salary = item.Salary;
                    emp.DepartmentId = item.DepartmentId;
                    _context.SaveChanges();
                    return emp;
                }
                catch (Exception e)
                {

                    throw;
                }
            }
            return null;
        }
    }
}
