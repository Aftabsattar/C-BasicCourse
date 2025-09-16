using C_BasicCourse.Enums;
namespace CSharpBasicCourse
{
    class Program
    {
        static void Main(string[] args)
        {
          EnumPractice  enumPractice = new EnumPractice();
            enumPractice.DispayDaysName();
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