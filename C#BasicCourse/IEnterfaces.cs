namespace C_BasicCourse;

public interface IEnterfaces
{
     void DiplyaResult();
}
public interface IEnterfaces2
{
    void DiplyaResult();
}

public class Car:IEnterfaces,IEnterfaces2
{
    public string? Name { get; set; }

    void IEnterfaces.DiplyaResult()
    {
        Console.WriteLine($"your Name From Interface:{Name}");
    }
     void IEnterfaces2.DiplyaResult()
    {
        Console.WriteLine($"your Name From Interface2:{Name}");
    }
}
//========
/*in this class we use simple interface and Explicit interface
scenario for Explicit interfaces: A class inherit from two interfces and both the interfaces have the same method name 
then we use Explicit interfaces.
 main method implementation
 Car car = new Car();
            car.Name = "Muhammad Aftab";
            ((IEnterfaces)car).DiplyaResult();
            ((IEnterfaces2)car).DiplyaResult();
 */