using Lab5_UMS.Application.Request.Commands.Course;
using Lab5_UMS.Domain.Models;
using Lab5_UMS.Persistence;
using MediatR;
using NpgsqlTypes;

namespace Lab5_UMS.Application.Request.Handlers;

public class AddCourseCommandHandler: IRequestHandler<AddCourseCommand,Course>
{
    private readonly UmsContext _context;

    public AddCourseCommandHandler(UmsContext context)
    {
        _context = context;
    }
    public async Task<Course> Handle(AddCourseCommand request, CancellationToken cancellationToken)
    {

        var course = new Course()
        {
            Name = request.Name,
            MaxStudentsNumber = request.MaxStudents,
            EnrolmentDateRange = new NpgsqlRange<DateOnly>(request.EnrollmentStartDate, request.EnrollmentEndDate)
        };

        var newCourse = await _context.Courses.AddAsync(course, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return newCourse.Entity;
    }
}