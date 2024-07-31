namespace EnrollmentMicroservice.Modules;

public class Enrollment
{
    public long Id { get; set; }
    public long CourseId { get; set; }
    public long StudentId { get; set; }
    public Course Course { get; set; }
    public Student Student { get; set; }
}