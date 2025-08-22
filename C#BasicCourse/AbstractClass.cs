/* AbstractClass : this class iherited from{Abstract} base calss 
   when class is inherited from abstract base class all member of base class is override in chilld class
 */
namespace C_BasicCourse;

public class AbstractClass : Abstract
{
    public override string? Name { get; set; } 

    public override void Display()
    {
        Console.WriteLine("i am abstract method, i am inheritred from Abstract base class");
        Console.WriteLine($"Name is:{Name}");
    }
}