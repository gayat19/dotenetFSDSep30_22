using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public int DepartmentId { get; set; }

        public override bool Equals(object? obj)
        {
            Employee e = obj as Employee;
            return this.Id.Equals(e.Id);
        }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
        public string? Username { get; set; }
        [ForeignKey("Username")]
        public User? User { get; set; }
    }
}
