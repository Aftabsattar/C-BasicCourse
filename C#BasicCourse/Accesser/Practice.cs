namespace C_BasicCourse.Accesser;

public class Practice
{
    private string FirstName { get; set; } = string.Empty; // this private member can be accessable in this class (practice) not accessable other class

}
 public class practice2:Practice
{
    public string LastName { get; set; }
    public void Display()
    {
        Practice practice = new Practice();
        Console.WriteLine("First name");
        //practice.FirstName = Console.ReadLine();// FirstName are inaccessable due to protection level
    }
}