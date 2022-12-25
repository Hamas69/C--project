using System;
namespace Hamas;
public abstract class Person
{
  public string Name;
  public int Age;

  public Person(string name, int age)
  {
    Name=name;
    Age=age;
  }
  public abstract void Print();

}
public class Student : Person
{
  public int Year;
  public float Gpa;

  public Student(string name, int age, int year, float gpa) :base(name,age)
  {
    Year=year;
    Gpa=gpa;

  } 
  public override void Print()
  {
    Console.WriteLine($"My name is{Name},my age is{Age}and my gpa is{Gpa}");
  }
}
public class Database
{
  private int _currentIndex;
  public Person[] People= new Person[50];


  public void AddStudent(Student student)
  {
      People[_currentIndex]=student;
      _currentIndex++;
  }
  
  public void AddStaff(Staff staff)
  {
      People[_currentIndex++]=staff;
  }
  public void PrintAll()
  {
    for(int i=0; i<=_currentIndex;i++)
    {
      People[i].Print();
    }
  }
  
}
public class Staff :Person
{
  public double Salary;
  public int JoinYear;
  public Staff(string name, int age, double salary, int joinYear):base(name,age)
  {
      Salary=salary;
      JoinYear=joinYear;
  }
  public override void Print()
  {
      Console.WriteLine($"My name is {Name},my age is {Age} and my salary is{Salary}");
  }
}

public class Program
{
 private static void Main()
 {
  
   var database=new Database ();
   
 while(true){
   Console.WriteLine("1.student 2.staff 3.print all");
   var option= int.Parse(Console.ReadLine());

   switch(option)
   {
    case 1:
     Console.Write(" Enter Name: ");
     var name=Console.ReadLine();

     Console.Write(" Enter Age: ");
     var age= int.Parse(Console.ReadLine());

     Console.Write(" Enter Year: ");
     var year= int.Parse(Console.ReadLine());

     Console.Write(" Enter Gpa: ");
     var gpa= Convert.ToSingle(Console.ReadLine());
     var student= new Student(name,age,year,gpa);

     database.AddStudent(student);
     break;
    case 2:
     Console.Write(" Enter Name: ");
     var name2=Console.ReadLine();

     Console.Write(" Enter Age: ");
     var age2= int.Parse(Console.ReadLine());

     Console.Write(" Enter Salary: ");
     var salary= Convert.ToDouble(Console.ReadLine());

     Console.Write(" Enter JoinYear: ");
     var joinYear= int.Parse(Console.ReadLine());
     var staff= new Staff(name2,age2,salary,joinYear); 
     database.AddStaff(staff);
     break;
    case 3:
     database.PrintAll();
     break;
    default:
     return;

     
   }

   }
  
   
   
 }
}


