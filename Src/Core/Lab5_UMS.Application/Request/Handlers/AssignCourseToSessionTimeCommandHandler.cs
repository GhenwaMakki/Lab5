using Lab5_UMS.Application.Request.Commands;
using Lab5_UMS.Domain.Models;
using Lab5_UMS.Persistence;
using MediatR;

namespace Lab5_UMS.Application.Request.Handlers;

public class AssignCourseToSessionTimeCommandHandler: IRequestHandler<AssignCourseToSessionTimeCommand, TeacherPerCoursePerSessionTime>
{
    private readonly UmsContext _context;

    public AssignCourseToSessionTimeCommandHandler(UmsContext context)
    {
        _context = context;
    }

    public async Task<TeacherPerCoursePerSessionTime> Handle(AssignCourseToSessionTimeCommand request,
        CancellationToken cancellationToken)
    {

        var coursePerSessionTime = new TeacherPerCoursePerSessionTime()
        {
            TeacherPerCourseId = request.TeacherPerCourseId,
            SessionTimeId = request.SessionTimeId
        };

        var newTeacherCoursePerSession =
            await _context.TeacherPerCoursePerSessionTimes.AddAsync(coursePerSessionTime, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return newTeacherCoursePerSession.Entity;
    }
}