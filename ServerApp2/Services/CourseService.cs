// CourseService.cs
using ServerApp2.Data;
using ServerApp2.Models;

public class CourseService
{
    private readonly ApplicationDbContext _context;

    public CourseService(ApplicationDbContext context) => _context = context;

    public List<Course> GetAllCourses()
    {
        return _context.Courses.ToList();
    }

    public Course? GetCourseById(Guid courseId)
    {
        return _context.Courses.FirstOrDefault(c => c.Id == courseId);
    }

    public void AddCourse(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
    }

    public void UpdateCourse(Course updatedCourse)
    {
        var existingCourse = _context.Courses.Find(updatedCourse.Id);

        if (existingCourse != null)
        {
            existingCourse.Name = updatedCourse.Name;
            existingCourse.Description = updatedCourse.Description;
            // Update other properties as needed
            _context.SaveChanges();
        }
    }

    public void DeleteCourse(Guid courseId)
    {
        var courseToDelete = _context.Courses.Find(courseId);

        if (courseToDelete != null)
        {
            _context.Courses.Remove(courseToDelete);
            _context.SaveChanges();
        }
    }
}
