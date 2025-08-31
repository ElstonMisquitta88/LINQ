# Day 2 – Aggregations & Element Operators (Questions)

#### (11) Find total salary of all employees
```
var example = employees.Sum(e => e.Salary);
```
#### (12) Find average salary of IT employees
```
var example = employees.Where(e => e.Department == "IT").Average(x => x.Salary);
```
#### (13) Find highest salary in Finance
```
var example = employees.Where(e => e.Department == "Finance").Max(x => x.Salary);
```
#### (14) Find lowest salary overall
```
var example = employees.Min(x => x.Salary);
```
#### (15) Count employees in HR
```
var example = employees.Where(e => e.Department == "HR").Count();
```
#### (16) Check if any employee earns > 1 lakh
```
var example = employees.Any(e => e.Salary > 100000);
```
#### (17) Check if all Finance employees earn > 40k
```
var example = employees.Where(e => e.Department == "Finance").All(e => e.Salary > 40000);
```
#### (18) Find first employee in IT
```
var example = employees.First(e => e.Department == "IT");
var example = employees.FirstOrDefault(e => e.Department == "IT");
```
#### (19) Find last employee in HR
```
var example = employees.LastOrDefault(e => e.Department == "HR");
```
#### (20) Find employee with Id = 3
```
var example = employees.SingleOrDefault(e => e.Id == 33);
        if (example is null)
        {
            Console.WriteLine("Not Found");
        }
        else { Console.WriteLine(example.Name); }
```


