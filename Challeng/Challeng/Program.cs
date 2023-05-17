using Challeng;

Employee employee1 = new Employee ("Jan","Kowalski", 34);
Employee employee2 = new Employee ("Maria","Trzcińska", 26);
Employee employee3 = new Employee ("Zofia", "Nowakowska", 30);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(2);
employee1.AddScore(4);
employee1.AddScore(9);

employee2.AddScore(2);
employee2.AddScore(1);
employee2.AddScore(4);
employee2.AddScore(7);
employee2.AddScore(9);

employee3.AddScore(7);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(9);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
  employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + ", wiek " + employeeWithMaxResult.Age + ", punkty " + maxResult);