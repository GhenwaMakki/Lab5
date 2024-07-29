using MediatR;

namespace Lab5_UMS.Application.Request.Commands.Course;

public class AddCourseCommand: IRequest<Domain.Models.Course>
{
    public string Name { get; set; }
    public int MaxStudents { get; set; }
    public DateOnly EnrollmentStartDate { get; set; }
    public DateOnly EnrollmentEndDate { get; set; }
    
}