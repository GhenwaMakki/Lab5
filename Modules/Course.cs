namespace EnrollmentMicroservice.Modules;

public class Course
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}