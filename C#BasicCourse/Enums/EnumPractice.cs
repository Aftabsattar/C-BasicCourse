
using System.Security.Cryptography.X509Certificates;

namespace C_BasicCourse.Enums;

public class EnumPractice
{
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public void DispayDaysName()
    {
        Console.WriteLine("Enter a number from 1 to 7");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number) 
        {
            case 0:
              var sun = (Days)0;
                Console.WriteLine(sun);
                break;
            case 1:
                var mon = (Days)1;
                Console.WriteLine(mon);
                break;
            case 2:
                var tue = (Days)2;
                Console.WriteLine(tue); break;
            case 3:
                var Wed = (Days)4;
                Console.WriteLine(Wed);
                break;
            case 4:
                var thu = (Days)3;
                Console.WriteLine(thu);
                break;
            case 5:
                var fri = (Days)5;
                Console.WriteLine(fri); 
                break;
            case 6:
                var sat = (Days)6;
                Console.WriteLine(sat); 
                break;
            default:
                Console.WriteLine("invalid Input");
                break;
        }
    }
}