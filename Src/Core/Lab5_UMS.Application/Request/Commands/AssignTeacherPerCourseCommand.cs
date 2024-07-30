using Lab5_UMS.Domain.Models;
using MediatR;

namespace Lab5_UMS.Application.Request.Commands;

public class AssignTeacherPerCourseCommand: IRequest<TeacherPerCourse>
{
    public long TeacherId { get; set; }

    public long CourseId { get; set; }
}