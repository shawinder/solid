public class EmployeeManager
{
    private readonly IEmployee _employee;

    // Passed : Dependency Inversion
    // Caller will create and pass the dependencies
    public EmployeeManager(IEmployee employee)
    {
        _employee = employee;
    }

    public int GetEmployeeCount()
    {
        return _employees.Count();
    }
}

public interface IEmployee
{
    string Name { get; set; }
    string Address { get; set; }
}

public class Employee : IEmployee
{
    public string Name { get; set; }
    public string Address { get; set; }
}