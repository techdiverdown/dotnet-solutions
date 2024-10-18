using System;
using System.Linq;
using EFCSchoolSolution.Models;

namespace EFCSchoolSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                if (!context.Students.Any())
                {
                    // Add students
                    var student1 = new Student { Name = "Alice" };
                    var student2 = new Student { Name = "Bob" };

                    // Add courses
                    var course1 = new Course { Title = "Math" };
                    var course2 = new Course { Title = "Science" };

                    context.Students.AddRange(student1, student2);
                    context.Courses.AddRange(course1, course2);
                    context.SaveChanges();

                    // Add enrollments
                    var enrollment1 = new Enrollment { StudentId = student1.StudentId, CourseId = course1.CourseId };
                    var enrollment2 = new Enrollment { StudentId = student1.StudentId, CourseId = course2.CourseId };
                    var enrollment3 = new Enrollment { StudentId = student2.StudentId, CourseId = course1.CourseId };

                    context.Enrollments.AddRange(enrollment1, enrollment2, enrollment3);
                    context.SaveChanges();

                    Console.WriteLine("Data seeded successfully");
                }

                // Query and display students with their enrolled courses
                var students = context.Students
                    .Select(s => new
                    {
                        s.Name,
                        Courses = s.Enrollments.Select(e => e.Course.Title).ToList()
                    })
                    .ToList();

                foreach (var student in students)
                {
                    Console.WriteLine($"Student: {student.Name}, Courses: {string.Join(", ", student.Courses)}");
                }
            }
        }
    }
}