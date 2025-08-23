using C_BasicCourse;
namespace CSharpBasicCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegates.CalculationDelegate calD = Delegates.Div;
            Console.WriteLine("the Divsion of two number",+ calD(2,5));
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
