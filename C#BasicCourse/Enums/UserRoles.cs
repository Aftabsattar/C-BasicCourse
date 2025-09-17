using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace C_BasicCourse.Enums;

public class UserRoles
{
    public enum userRoles
    {
        Admin,
        Manager,
        Staff,
        Guest,
    }
    public void ChooseUserRole()
    {
        userRoles userRoles = new userRoles();
        Console.WriteLine("Please Select a number\n 1. for Admin \n 2. for Manager \n 3. for Staff \n 4. for Guest ");
        var role = Console.ReadLine();
        switch (role)
        {
            case "admin":
                Console.WriteLine($"{userRoles.Admin}Register Succefully");
                break;
            case "Manager":
                Console.WriteLine($"{userRoles.Manager} Register Succefully");
                break;
            case "Staff":
                Console.WriteLine($"{userRoles.Manager}  Register Succefullyly");
                break;
            case "Guest":
                Console.WriteLine($"{userRoles.Manager}  Register Succefullyly");
                break;
            default:
                Console.WriteLine("Invalid Inpput");
                break;
        }
    }
}
//1. Enums are enumerations.
//2. Enums are strongly typed constants.Hence, an explicit cast is needed to convert from enum type to an integral type and vice versa.Also,
//an enum of one type cannot be implicitly assigned to an enum of another type even though the underlying value of their members are the same.
//3. The default underlying type of an enum is int.
//4. The default value for first element is ZERO and gets incremented by 1.
//5. It is possible to customize the underlying type and values.
//6. Enums are value types.
//7. Enum keyowrd (all small letteres) is used to create enumerations, where as Enum class,
//contains static GetValues() and GetNames() methods which can be used to list Enum underlying type values and Names.
