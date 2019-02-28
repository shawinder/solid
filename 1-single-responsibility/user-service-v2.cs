using System;

// Passed: Single Responsibility
// UserService is handling single responsibility of registering a user.
public class UserService
{
    EmailService _emailService;
    DatabaseService _databaseService;

    // Violation: Dependency Injection
    // Let the caller create the dependencies rather than the class itself
    public UserService()
    {
        _emailService = new EmailService();
        _databaseService = new DatabaseService();
    }

    public void Register(string email = null, string password = null)
    {
        // 1. Validate Email
        _emailService.ValidateEmail();

        // 2. Create and Save user
        _databaseService.CreateUser();

        // 3. Send Email
        _emailService.SendEmail();
    }
}

public class DatabaseService
{
    public void CreateUser()
    {
        Console.WriteLine("User Created.");
    }
}

public class EmailService
{
    public void ValidateEmail()
    {
        Console.WriteLine("Email Validated.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Email Sent.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        UserService service = new UserService();
        service.Register();
    }
}