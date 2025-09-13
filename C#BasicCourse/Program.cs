using C_BasicCourse.ExceptionHandling;
namespace CSharpBasicCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionPrac exception = new ExceptionPrac();
            //exception.GetFile();
            InnerException innerException = new InnerException();
            innerException.Divide();
        }

        public void Create()
        {
            Console.WriteLine("Enter Student Name:");
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