using System;

// Violation: Single Responsibility 
// UserService is handling multiple responsibilities e.g validation, database, email.
public class UserService
{
    public void Register(string email=null, string password=null)
    {
        // 1. Validate Email
        ValidateEmail();

        // 2. Create and Save user
        CreateUser();

        // 3. Send Email
        SendEmail();
    }

    public void ValidateEmail(){
        Console.WriteLine("Email Validated.");
    }

    public void CreateUser()
    {
         Console.WriteLine("User Created.");
    }

    public void SendEmail()
    {
         Console.WriteLine("Email Sent.");
    }
}

public class Program
{
    public static void Main(string[] args){
        UserService service = new UserService();
        service.Register();
    }
}