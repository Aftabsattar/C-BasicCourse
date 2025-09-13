namespace C_BasicCourse.ExceptionHandling;

public class InnerException
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
    public void Divide()
    {
        try
        {
            Console.WriteLine("Enter First Number:");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            int Result = FirstNumber / SecondNumber;
            Console.WriteLine("Result is: " + Result);
        }
        catch(Exception ex)
        {
            var filepath = @"I:\7 sem notes\log.txt";
            if (File.Exists(filepath))
            {
                StreamWriter log = new StreamWriter(filepath);
                log.WriteLine(ex.Message + " " + DateTime.Now);
                log.WriteLine(ex.GetType().Name);
                log.Close();
                Console.WriteLine("Something went wrong please try again later");
            }
            else 
            {
                throw new FileNotFoundException(filepath + "Log file not found", ex);
            }
        }
    }
}