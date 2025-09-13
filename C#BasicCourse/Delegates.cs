namespace C_BasicCourse;

public class Delegates
{
    public delegate int CalculationDelegate(int a, int b);// we create a delegate 

    public int Add(int a, int b) { return a + b; }

    public int Multiply(int a, int b) { return a * b; }
    public static int Div(int a, int b) { return a / b; }

    public static int Sub(int a, int b) { return a - b; }

    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Salary { get; set; } =string.Empty;
    public int Experience { get; set; }


    public static void PromoteEmployee(List<Delegates> delegates)
    {
        foreach (Delegates del in delegates)
        {
            if (del.Experience > 5) { Console.WriteLine($"{del.Name} Promoted"); }
        }
    }
}
/* in this class we learn delegates : is hold address of method therefore we call it delegate*/
/* // this delegate implementation doing with static method 
            Delegates.CalculationDelegate calD = Delegates.Div;
            Console.WriteLine($"the Divsion of two number: {calD(20, 5)}");
            //delegates implemetation with instance method
            Delegates del = new Delegates();
            del.Add(10, 20);// this is instance method call because we create object of class Delegates
            del.Multiply(10, 20);
            Delegates.CalculationDelegate cal2 = del.Multiply; // this is the the actual use of delegates
            Console.WriteLine($"Using  Multiplication of two number: {cal2(2, 60)}");

            // create list of delegates
            List<Delegates> delegates = new List<Delegates>()
            {
                new Delegates(){ID=1,Name="John",Age=30,Salary="5000",Experience=6},
                new Delegates(){ID=2,Name="Jane",Age=25,Salary="4000",Experience=4},
                new Delegates(){ID=3,Name="Sam",Age=35,Salary="6000",Experience=7},
                new Delegates(){ID=4,Name="Sara",Age=28,Salary="4500",Experience=3},
            };
            Delegates.PromoteEmployee(delegates);
 */