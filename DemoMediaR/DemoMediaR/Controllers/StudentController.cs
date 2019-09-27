using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMediaR.MediatRServices;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoMediaR.Controllers
{
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
		private IMediator _mediator;

		public StudentController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public IActionResult CreateStudent(StudentCreateCommand studentCreateCommand)
		{
			var result = _mediator.Send(studentCreateCommand).Result;
			if (result < 0)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}

		[HttpPost]
		public IActionResult UpdateStudent(StudentCreateCommand studentCreateCommand)
		{
			var result = _mediator.Send(studentCreateCommand).Result;
			if (result < 0)
			{
				return BadRequest(result);
			}
			return Ok(result);
		}
	}
}