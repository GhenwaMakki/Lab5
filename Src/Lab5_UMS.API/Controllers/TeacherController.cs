using Lab5_UMS.Application.Request.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Lab5_UMS.API.Controllers;

[ApiController]
[Route("teacher")]

public class TeacherController: ControllerBase
{
   private readonly IMediator _mediator;

   public TeacherController(IMediator mediator)
   {
      _mediator = mediator;
   }

   [HttpPost("Assign/teacher/per/course")]

   public async Task<ActionResult<long>> AssignCoursePerTeacher([FromBody] AssignTeacherPerCourseCommand request)
   {
      
      if (request == null)
      {
         return BadRequest("Invalid request.");
      }

      var command = new AssignTeacherPerCourseCommand();
      command.CourseId = request.CourseId;
      command.TeacherId = request.TeacherId;

      var id = await _mediator.Send(command);
      return Ok(id);
   }
}