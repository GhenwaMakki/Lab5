namespace EnrollmentMicroservice.Modules;

public class Student
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}