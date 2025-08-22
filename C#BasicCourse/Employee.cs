// in this class we use inheriatnce {acquring the feature or behaviour from other class is called inheriatnce}

namespace C_BasicCourse;

public class Employee
{
    /* FirstName, Lastname,Email these are the filed because it does't have the get() ,set() logic*/
    public string? FirstName; 
    public string? LastName;
    public string? Email;
    // PrintFullName() is a instance method because it does't have static keyword
    public void PrintFullName()
    {
       Console.WriteLine(FirstName+ ' '+ LastName);
    }
}
//FullTimeEmployee is a child class which inherited from base class Employee
public class FullTimeEmployee : Employee
{
    //this is a child class property 
    public float yearlySalarly;
} 
public class PartTimeEmployee : Employee
{
    //this is a child class property 
    public float HoureSallary;
}