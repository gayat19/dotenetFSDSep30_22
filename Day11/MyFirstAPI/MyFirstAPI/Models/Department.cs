using System.ComponentModel.DataAnnotations;

namespace MyFirstAPI.Models
{
    public class Department
    {
        [Key]
        public int Dep_Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
