// in this class we use inheriatnce {acquring the feature or behaviour from other class is called inheriatnce}

namespace C_BasicCourse;

public class InheritanceEmployee
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
public class FullTimeEmployee : InheritanceEmployee
{
    //this is a child class property 
    public float yearlySalarly;
} 
public class PartTimeEmployee : InheritanceEmployee
{
    //this is a child class property 
    public float HoureSallary;
}
//main function code
//FullTimeEmployee Ftp = new FullTimeEmployee();
//            Ftp.FirstName = "Muhammad";
//            Ftp.LastName = "Aftab";
//            Ftp.Email = "aftabsattar14@gmail.com";
//            Ftp.yearlySalarly = 5000;
//            Ftp.PrintFullName();