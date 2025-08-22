using System.Reflection.Metadata;
using C_BasicCourse;
namespace CSharpBasicCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass = new AbstractClass();
            abstractClass.Name = "Test";
            abstractClass.Show();
            abstractClass.Display();
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
