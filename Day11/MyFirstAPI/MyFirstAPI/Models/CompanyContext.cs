using Microsoft.EntityFrameworkCore;

namespace MyFirstAPI.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department 
                { 
                    Dep_Id = 1,
                    DepartmentName="Admin"
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id=101,
                    Name="Ramu",
                    Salary=12345.54f,
                    DepartmentId=1,
                    Username=null
                },
                  new Employee
                  {
                      Id = 102,
                      Name = "Somu",
                      Salary = 34535.54f,
                      DepartmentId = 1,
                      Username = null
                  }
                );
            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Username="ramu",
            //        Password="1234",
            //        Role="admin",
            //        Status="Active"

            //    }
            //    );

          
        }
    }
}
