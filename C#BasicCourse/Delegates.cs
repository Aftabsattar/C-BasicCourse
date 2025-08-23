namespace C_BasicCourse;

public class Delegates
{
    public delegate int CalculationDelegate(int a, int b);// we create a delegate 

    public int Add(int a, int b) { return a + b; }

    public int Multiply(int a, int b) { return a * b; }
    public static int Div(int a, int b) { return a / b; }

    public static int Sub(int a, int b) { return a - b; }


}
/* in this class we learn delegates : is hold address of method therefore we call it delegate 
 */