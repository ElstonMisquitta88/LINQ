# Day 2 – Aggregations & Element Operators (Questions)

#### (1) Get all employees in IT with salary > 55k
```
var example_01 = employees.Where(e => e.Department == "IT" && e.Salary > 55000);
```
