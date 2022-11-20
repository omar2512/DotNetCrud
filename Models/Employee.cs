namespace CrudOperation.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public float Salary { get; set; }
        public DateTime DataOfBirth { get; set; }
        public string? Department { get; set; }

    }
}
