
using System;
public class GradeBookTest
{
    public static void Main(string[] argh)
    {
        GradeBook myGradeBook = new GradeBook();

        Console.WriteLine("Please enter the coursename:");
        string nameOfCourse = Console.ReadLine();
        Console.WriteLine();


        myGradeBook.DisplayMessage(nameOfCourse);
    }
}