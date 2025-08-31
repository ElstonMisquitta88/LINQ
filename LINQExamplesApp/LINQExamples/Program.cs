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

        // (1) Get all employees in IT with salary > 55k
        //var example_01 = employees.Where(e => e.Department == "IT" && e.Salary > 55000);
        //foreach (var e in example_01)
        //{
        //    Console.WriteLine(e.Name +" : "+ e.Department + " : " + e.Salary);
        //}

        // (2) List only employee names
        //var example_02 = employees.Select(e => e.Name);
        //foreach (var e in example_02)
        //{
        //    Console.WriteLine(e);
        //}

        //(3) Show Name + Salary projection
        //var example_03 = employees.Select(e => new { e.Name ,e.Salary});
        //foreach (var empdt in example_03)
        //{
        //    Console.WriteLine(empdt.Name +" : "+ empdt.Salary);
        //}

        //(4) Order employees by Salary
        //var example_04 = employees.OrderBy(e => e.Salary);
        ////var example_04 = employees.OrderByDescending(e => e.Salary);

        //foreach (var empdt in example_04)
        //{
        //    Console.WriteLine("Name "+empdt.Name + " : " +"Salary "+ empdt.Salary);
        //}

        //(5) Order employees by Dept then Salary
        //var example_05 = employees.OrderBy(e => e.Department).ThenBy(e => e.Salary);
        //foreach (var empdt in example_05)
        //{
        //    Console.WriteLine("Name " + empdt.Name + " : " + "Department " + empdt.Department +" :  "+ " Salary " + empdt.Salary);
        //}

        //(6)Find top 3 highest salaries
        //var example_06 = employees.OrderByDescending(e => e.Salary).Take(3);
        //foreach (var empdt in example_06)
        //{
        //    Console.WriteLine("Name " + empdt.Name + " : "  + " Salary " + empdt.Salary);
        //}


    }
}
