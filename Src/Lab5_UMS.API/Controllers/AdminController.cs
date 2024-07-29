using Lab5_UMS.Application.Request.Commands.Course;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Lab5_UMS.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AdminController: ControllerBase
{
    
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddCourse")]
        public async Task<ActionResult<long>> AddCourse([FromBody] AddCourseCommand request)
        {
            
            
            if (request == null)
            {
                return BadRequest("Invalid request.");
            }
            
            var command = new AddCourseCommand();
            command.Name = request.Name;
            command.MaxStudents = request.MaxStudents;
            command.EnrollmentStartDate = request.EnrollmentStartDate;
            command.EnrollmentEndDate = request.EnrollmentEndDate;

            var courseId = await _mediator.Send(command);
            return Ok(courseId);
        
    }
}