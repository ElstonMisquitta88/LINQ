public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public decimal Salary { get; set; }
    public List<string>? Skills { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {


        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 45000, Skills = new List<string>{ "Excel", "Recruitment" }},
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 60000, Skills = new List<string>{ "C#", "SQL", "Azure" }},
            new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 55000, Skills = new List<string>{ "JavaScript", "React" }},
            new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 70000, Skills = new List<string>{ "Accounting", "Excel" }},
            new Employee { Id = 5, Name = "Eva", Department = "Finance", Salary = 50000, Skills = new List<string>{ "Excel", "SAP" }},
            new Employee { Id = 6, Name = "Frank", Department = "HR", Salary = 40000, Skills = new List<string>{ "Onboarding" }}
        };

        #region Day 1 – Basics (Filtering, Projection, Sorting)
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

        //(7) Employees with even IDs
        //var example = employees.Where(e => e.Id % 2 == 0);
        //foreach (var empdt in example)
        //{
        //    Console.WriteLine("Name " + empdt.Name + " : " + " ID " + empdt.Id);
        //}

        //(8) Employees whose names start with 'A'
        //var example = employees.Where(e => e.Name!.StartsWith('A'));
        //foreach (var empdt in example)
        //{
        //    Console.WriteLine("Name " + empdt.Name);
        //}

        //(9)Employees with more than 2 skills
        //var example = employees.Where(e => e.Skills.Count > 2);
        //foreach (var empdt in example)
        //{
        //    Console.WriteLine("Name " + empdt.Name );
        //}

        //(10)Print salaries doubled
        //var example = employees.Select(e => new { e.Name, DoubleSalary = e.Salary * 2 });
        //foreach (var empdt in example)
        //{
        //    Console.WriteLine("Name " + empdt.Name + " : " + empdt.DoubleSalary);
        //}
        #endregion

        //Aggregations & Element Operators (Questions)

        //(11)Find total salary of all employees
        //var example = employees.Sum(e => e.Salary);
        //Console.WriteLine(example);

        //(12) Find average salary of IT employees
        //var example = employees.Where(e=>e.Department=="IT").Average(x=>x.Salary);
        //Console.WriteLine(example);


        //13. Find highest salary in Finance
        //var example = employees.Where(e => e.Department == "Finance").Max(x => x.Salary);
        //Console.WriteLine(example);

        //14 Find lowest salary overall
        //var example = employees.Min(x => x.Salary);
        //Console.WriteLine(example);

        //15. Count employees in HR
        //var example = employees.Where(e=>e.Department== "HR").Count();
        //Console.WriteLine("Count in HR "+example);

        //16.Check if any employee earns > 1 lakh
        //var example = employees.Any(e => e.Salary > 100000);
        //Console.WriteLine(example);

        //17.Check if all Finance employees earn > 40k 
        //var example = employees.Where(e => e.Department == "Finance").All(e => e.Salary > 40000);
        //Console.WriteLine(example);

        //18.Find first employee in IT
        //var example = employees.First(e => e.Department == "IT");
        //var example = employees.FirstOrDefault(e => e.Department == "IT");
        //Console.WriteLine(example.Name);

        //(19) Find last employee in HR
        //var example = employees.LastOrDefault(e => e.Department == "HR");
        //Console.WriteLine(example.Name);

        //(20)Find employee with Id=3
        //var example = employees.SingleOrDefault(e => e.Id == 33);
        //if (example is null)
        //{
        //    Console.WriteLine("Not Found");
        //}
        //else { Console.WriteLine(example); }



    }
}
