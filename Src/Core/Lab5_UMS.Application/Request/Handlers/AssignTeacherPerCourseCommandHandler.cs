using Lab5_UMS.Application.Request.Commands;
using Lab5_UMS.Domain.Models;
using Lab5_UMS.Persistence;
using MediatR;

namespace Lab5_UMS.Application.Request.Handlers;

public class AssignTeacherPerCourseCommandHandler: IRequestHandler<AssignTeacherPerCourseCommand, TeacherPerCourse>
{
    private readonly UmsContext _context;

    public AssignTeacherPerCourseCommandHandler(UmsContext context)
    {
        _context = context;
    }
    
    public async Task<TeacherPerCourse> Handle(AssignTeacherPerCourseCommand request, CancellationToken cancellationToken)
    {
        var coursePreTeacher = new TeacherPerCourse()
        {
            TeacherId = request.TeacherId,
            CourseId = request.CourseId
        };

        var newAssignment = await _context.TeacherPerCourses.AddAsync(coursePreTeacher, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        
        return newAssignment.Entity;
    }
}