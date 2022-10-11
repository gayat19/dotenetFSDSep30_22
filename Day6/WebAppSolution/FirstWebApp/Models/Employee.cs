namespace FirstWebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public override bool Equals(object? obj)
        {
            Employee other = ((Employee)obj);
            return this.Id.Equals(other.Id);
        }
    }
}
