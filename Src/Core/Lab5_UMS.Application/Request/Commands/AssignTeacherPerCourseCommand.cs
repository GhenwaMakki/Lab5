using MediatR;

namespace Lab5_UMS.Application.Request.Commands;

public class AssignTeacherPerCourseCommand: IRequest<long>
{
    public long TeacherId { get; set; }

    public long CourseId { get; set; }
}