public class EmployeeManager
{
    private readonly Employee _employee;

    // Violation : Dependency Injection Principal
    // Caller should create the dependency rather than the class itself
    public EmployeeManager(Employee employee)
    {
        _employee = employee;
    }

    public int GetEmployeeCount()
    {
        return _employees.Count();
    }
}

public class Employee
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public Position Position { get; set; }
}