using C_BasicCourse;
namespace CSharpBasicCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // properties class : 
           Properties properties = new Properties();
            properties.Age = 20;
            properties.Email = "maftab256@gmail.com";
            Console.WriteLine(properties.Email);
            Console.WriteLine(properties.Age);
            properties.Display();
            //====
            // name space Concepts
            ProjectA.TeamA.Program.MethodA();
            //Iheritance 
            FullTimeEmployee Ftp = new FullTimeEmployee();
            Ftp.FirstName = "Muhammad";
            Ftp.LastName = "Aftab";
            Ftp.Email = "aftabsattar14@gmail.com";
            Ftp.yearlySalarly = 5000;
            Ftp.PrintFullName();
        }
    }
}
// name space Concepts
namespace ProjectA 
{
    namespace TeamA 
    {
        class Program 
        { 
            public static void MethodA() 
            { 
                Console.WriteLine("Hello from TeamA"); 
            } 
        }

    }
}
