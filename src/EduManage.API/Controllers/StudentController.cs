using EduManage.Application.UseCases.City.Queries;
using EduManage.Application.UseCases.Department.Commands;
using EduManage.Application.UseCases.Department.Queries;
using EduManage.Application.UseCases.Student.Commands;
using EduManage.Application.UseCases.Student.Queries;
using EduManage.Application.UseCases.Students_Subjects.Commands;
using EduManage.Application.UseCases.Students_Subjects.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EduManage.API.Controllers;

[Route("[controller]/[action]")]
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

	[HttpGet]
	public async ValueTask<IActionResult> GetAllStudentsSubjects()
	{
		var studentsubjects = await _mediator.Send(new GetStudentSubjectsCommand());
		return Ok(studentsubjects);
	}

	[HttpPost]
	public async ValueTask<bool> AddStudentSubject(PostStudentSubjectsCommand postStudentSubject)
	{
		var result = await _mediator.Send(postStudentSubject);
		return result;
	}

	[HttpPut]
	public async ValueTask<IActionResult> UpdateStudentSubject(PutStudentSubjectsCommand putStudentSubject)
	{
		var result = await _mediator.Send(putStudentSubject);
		return Ok(result);
	}

	[HttpDelete]
	public async ValueTask<IActionResult> DeleteStudentSubject(DeleteStudentSubjectsCommand deleteStudentSubject)
	{
		var result = await _mediator.Send(deleteStudentSubject) ;
		return Ok(result);
	}


	[HttpGet]
	public async ValueTask<IActionResult> FilterStudent(FilterStudentCommand filterStudent)
	{
		var students = await _mediator.Send(filterStudent);
		return Ok(students);

	}

	[HttpGet]
	public async ValueTask<IActionResult> GetTopStudents(GetTopStudentCommand topStudent)
	{
		var students = await _mediator.Send(topStudent);
		return Ok(students);

	}

}
