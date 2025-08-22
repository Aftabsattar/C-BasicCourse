/*
 in this class we use properties 
 */

using C_BasicCourse;

public class Properties : IEnterfaces
{
    private int _age;   // 👉 backing field
    private string? _email;
    public int Age
    {
        get { return _age; }   // returns the stored value
        set
        {
            if (value > 0)     // "value" is whatever we assign
            {
                _age = value;  // store in backing field
            }
        }
    }
    public string? Email
    {
        get { return _email; }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Email is not nul or Empty");
            }
            else
            {
                _email = value;
            }
        }

    }

    public void DiplyaResult()
    {
        Console.WriteLine($"your age is:{Age}");
        Console.WriteLine($"your Email is:{Email}");
    }
}
//main function code 
//Properties properties = new Properties();
//properties.Age = 20;
//properties.Email = "maftab256@gmail.com";
//Console.WriteLine(properties.Email);
//Console.WriteLine(properties.Age);
// in this we use interface to print propertires value 
//properties.DiplyaResult();