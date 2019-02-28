using System;

// Passed: Single Responsibility
// UserService is handling single responsibility of registering a user.
public class UserService
{
    IEmailService emailService;
    IDatabaseService databaseService;

    // Passed: Dependency Injection
    // Caller creates and pass the dependencies
    public UserService(IEmailService emailService, IDatabaseService databaseService)
    {
        this.emailService = emailService;
        this.databaseService = databaseService;
    }

    public void Register(string email = null, string password = null)
    {
        // 1. Validate Email
        emailService.ValidateEmail();

        // 2. Create and Save user
        databaseService.CreateUser();

        // 3. Send Email
        emailService.SendEmail();
    }
}

public interface IDatabaseService
{
    void CreateUser();
}

public class DatabaseService : IDatabaseService
{
    public void CreateUser()
    {
        Console.WriteLine("User Created.");
    }
}

public interface IEmailService
{
    void ValidateEmail();
    void SendEmail();
}

public class EmailService : IEmailService
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
        EmailService emailService = new EmailService();
        DatabaseService databaseService = new DatabaseService();
        UserService service = new UserService(emailService, databaseService);
        service.Register();
    }
}