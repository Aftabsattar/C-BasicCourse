/*Let us understand the need for Generics in C# with one example. 
 Let us create a simple program to check whether two integer numbers are equal or not.*/
// we can solve this example with many method like 
// 1.create a simple function that accept two num and return bool value if both are equel are not 
// 2.we can solve this problem with object data type that accept any type of data 
// 3.we can solve this example with generics 
// 4.we can solve this example with Method overloading 
namespace C_BasicCourse;


public class Generics
{
    //this method work only int type value 
    //public static bool AreEquel(int a , int b) 
    //{
    //    return a == b;
    //} 
    //---- this function accept any type of vlaue because 
    // Object type is the root data type that can 
    //contain a value of any data type, value type, reference type, user type or predefined  
    //public static bool AreEquel(object a, object b)
    //{
    //    return a == b;
    //}
    //++ how to solve this problem with c# generics
    public static bool AreEquel<T>(T a, T b)
    {
        return a.Equals(b);
    }
    // so we can pass any type of data to this function 
    //var NumberAreEql = Generics.AreEquel<string>("ABS", "ABS");
    //        if (NumberAreEql) Console.WriteLine("Both are Equal");
    //        else Console.WriteLine("Both are not Equal");
    //        Console.ReadLine();
    //var NumberAreEql = Generics.AreEquel<int>(1,2);
    //        if (NumberAreEql) Console.WriteLine("Both are Equal");
    //        else Console.WriteLine("Both are not Equal");
    //        Console.ReadLine();
}