using EduManage.Application.UseCases.City.Commands;
using EduManage.Application.UseCases.City.Queries;
using EduManage.Application.UseCases.Student.Queries;
using EduManage.Application.UseCases.Subject.Commands;
using EduManage.Application.UseCases.Subject.Queries;
using EduManage.Application.UseCases.Teacher.Commands;
using EduManage.Application.UseCases.Teacher.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EduManage.API.Controllers;

[Route("[controller]")]
[ApiController]
public class TeacherController : ControllerBase
{
	private readonly IMediator _mediator;

	public TeacherController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllTeachers()
	{
		var teachers = await _mediator.Send(new GetTeacherCommand());
		return Ok(teachers);
	}

	[HttpPost]
	public async ValueTask<bool> AddTeacher(PostTeacherCommand postTeacher)
	{
		var result = await _mediator.Send(postTeacher);
		return result;
	}

	[HttpPut]
	public async ValueTask<IActionResult> UpdateTeacher(PutTeacherCommand putTeacher)
	{
		var result = await _mediator.Send(putTeacher);
		return Ok(result);
	}

	[HttpDelete]
	public async ValueTask<IActionResult> DeleteTeacher(DeleteTeacherCommand deleteTeacher)
	{
		var result = await _mediator.Send(deleteTeacher);
		return Ok(result);
	}

	[HttpGet("FilterTeacher")]
	public async ValueTask<IActionResult> FilterTeacher(FilterTeacherCommand filterTeacher)
	{
		var teachers = await _mediator.Send(filterTeacher);
		return Ok(teachers);
	}

}
