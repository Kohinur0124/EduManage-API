using EduManage.Application.UseCases.Department.Commands;
using EduManage.Application.UseCases.Department.Queries;
using EduManage.Application.UseCases.Student.Commands;
using EduManage.Application.UseCases.Student.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EduManage.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
	private readonly IMediator _mediator;

	public StudentController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllStudents()
	{
		var students = await _mediator.Send(new GetStudentCommand());
		return Ok(students);
	}

	[HttpPost]
	public async ValueTask<bool> AddStudent(PostStudentCommand postStudent)
	{
		var result = await _mediator.Send(postStudent);
		return result;
	}

	[HttpPut]
	public async ValueTask<IActionResult> UpdateStudent(PutStudentCommand putStudent)
	{
		var result = await _mediator.Send(putStudent);
		return Ok(result);
	}

	[HttpDelete]
	public async ValueTask<IActionResult> DeleteStudent(DeleteStudentCommand deleteStudent)
	{
		var result = await _mediator.Send(deleteStudent);
		return Ok(result);
	}


}
