public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public decimal Salary { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 45000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 60000 },
            new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 55000 },
            new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 70000 },
            new Employee { Id = 5, Name = "Eva", Department = "Finance", Salary = 50000 },
            new Employee { Id = 6, Name = "Frank", Department = "HR", Salary = 40000 }
        };

        Console.WriteLine("Hello, World!");
    }
}
