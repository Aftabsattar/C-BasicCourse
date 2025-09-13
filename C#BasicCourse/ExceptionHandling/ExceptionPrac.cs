namespace C_BasicCourse.ExceptionHandling;

public class ExceptionPrac
{
    public void GetFile()
    {
        try
        {
            var ReadStream = new StreamReader(@"I:\7 sem notes\2nd year t6.txt");
            var line = ReadStream.ReadToEnd();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
// in this code we are going to see how to handle exception in c#
// there are two types of exception
// 1. checked exception
// 2. unchecked exception
// checked exception are those exceptions which are checked at compile time
// unchecked exception are those exceptions which are checked at runtime
// in c# all exceptions are unchecked exceptions
// in c# we can handle exception using try catch block
// try block is used to write the code which may throw exception
// catch block is used to handle the exception
// finally block is used to write the code which will be executed always
// throw keyword is used to throw the exception
// using throw keyword we can throw the exception explicitly
// using throw keyword we can throw the exception object
//in this class we are going to read a file which may from c Directory if 
//not be present in the given path we will get an exception