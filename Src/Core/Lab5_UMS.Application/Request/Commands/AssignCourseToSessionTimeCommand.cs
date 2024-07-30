using Lab5_UMS.Domain.Models;
using MediatR;

namespace Lab5_UMS.Application.Request.Commands;

public class AssignCourseToSessionTimeCommand: IRequest<TeacherPerCoursePerSessionTime>
{
    public long TeacherPerCourseId { get; set; }

    public long SessionTimeId { get; set; }
}