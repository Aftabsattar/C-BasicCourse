/*
 abstract class
1. we can't create a instance of abstract class
2.abstract class member has may and may not body 
3.abstract class have 
  ->abstract and non-abstract method 
  ->abstract and non-abstract property
  ->constructer and destructer 
  1. abstract method implemented in child class using override keyword but normal member are automaticaly access by 
   child class object 
  2.if we change the the behavoiur of normal member of base class then we declared it virtual in base class 
    and override it virtual keyword  
 */
namespace C_BasicCourse;

public abstract class Abstract
{
    public abstract string Name { get; set; }
    //display method this is abstract methd 
    public abstract void Display();
   // non abstract method 
    public void Show()
    {
        Console.WriteLine("i have a body because i am not declared abstract method");
    }
}