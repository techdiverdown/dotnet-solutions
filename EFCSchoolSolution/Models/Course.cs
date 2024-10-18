namespace EFCSchoolSolution.Models;

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
}
