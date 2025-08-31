# Day 1 – Basics (Filtering, Projection, Sorting)

#### (1) Get all employees in IT with salary > 55k
```
var example_01 = employees.Where(e => e.Department == "IT" && e.Salary > 55000);
```
#### (2) List only employee names
```
var example_02 = employees.Select(e => e.Name);
```
#### (3) Show Name + Salary projection
```
var example_03 = employees.Select(e => new { e.Name ,e.Salary});
```
#### (4) Order employees by Salary
```
var example_04 = employees.OrderBy(e => e.Salary);
var example_04 = employees.OrderByDescending(e => e.Salary);
```
#### (5) Order employees by Dept then Salary
```
var example_05 = employees.OrderBy(e => e.Department).ThenBy(e => e.Salary);
```
#### (6)Find top 3 highest salaries
```
var example_06 = employees.OrderByDescending(e => e.Salary).Take(3);
```
#### (7) Employees with even IDs
```
var example = employees.Where(e => e.Id % 2 == 0);
```
#### (8) Employees whose names start with 'A'
```
var example = employees.Where(e => e.Name!.StartsWith('A'));
```
#### (9)Employees with more than 2 skills
```
var example = employees.Where(e => e.Skills.Count > 2);
```
#### (10)Print salaries doubled
```
var example = employees.Select(e => new { e.Name, DoubleSalary = e.Salary * 2 });
```

