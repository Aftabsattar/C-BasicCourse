using System;

namespace C_BasicCourse.ExceptionHandling;

public class CustomException: Exception
{
    public int age { get; set; }
    public CustomException(string message, int age) : base(message)// base keyword is used to call the constructor of the parent class and pass the message to it
    {
        this.age = age;
    }
    public void RegistereUser()
    {
        Console.WriteLine("Enter your age:");
        age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            throw new CustomException("Age must be greater than 18 to register", age);
        }
        else
        {
            Console.WriteLine("You are registered successfully");
        }
    }
}
//C# me built-in exceptions hote hain jaise NullReferenceException, DivideByZeroException, etc.
//Lekin kabhi kabhi tumhare apne business rules hote hain jinke liye ek special exception banana useful hota hai.
//Usko hum Custom Exception kehte hain
// in this class we can create our own custom exceptions by inheriting from the Exception class
// we use Custom exception when we want to throw exception according to our own business logic 
