using System;
using StudentRecords;

namespace HelloCSharp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Order order = new Order(1, "John Doe", 100.00);
        order.ApplyDiscount(10);
        order.PrintSummary();

        Student student = new Student(1, "Alice");
        Course course = new Course("CS101", "Introduction to Computer Science");
        student.EnrollInCourse(course);

    
        foreach (var enrollment in student.Enrollments)
        {
            Console.WriteLine(enrollment.ToString());
        }
    }
}   