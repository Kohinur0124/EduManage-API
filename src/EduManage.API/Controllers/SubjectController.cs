using EduManage.Application.UseCases.City.Queries;
using EduManage.Application.UseCases.Subject.Commands;
using EduManage.Application.UseCases.Subject.Queries;
using EduManage.Application.UseCases.TeachersSubjects.Commands;
using EduManage.Application.UseCases.TeachersSubjects.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EduManage.API.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class SubjectController : ControllerBase
{
	private readonly IMediator _mediator;

	public SubjectController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllSubjects()
	{
		var subjects = await _mediator.Send(new GetSubjectCommand());
		return Ok(subjects);
	}

	[HttpPost]
	public async ValueTask<bool> AddSubject(PostSubjectCommand postSubject)
	{
		var result = await _mediator.Send(postSubject);
		return result;
	}

	[HttpPut]
	public async ValueTask<IActionResult> UpdateSubject(PutSubjectCommand putSubject)
	{
		var result = await _mediator.Send(putSubject);
		return Ok(result);
	}

	[HttpDelete]
	public async ValueTask<IActionResult> DeleteSubject(DeleteSubjectCommand deleteSubject)
	{
		var result = await _mediator.Send(deleteSubject);
		return Ok(result);
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllTeachersSubjects()
	{
		var subjects = await _mediator.Send(new GetTeachersSubjectsCommand());
		return Ok(subjects);
	}

	[HttpPost]
	public async ValueTask<bool> AddTeachersSubjects(PostTeachersSubjectsCommand postTeachersSubjects)
	{
		var result = await _mediator.Send(postTeachersSubjects);
		return result;
	}

	[HttpPut]
	public async ValueTask<IActionResult> UpdateTeachersSubjects(PutTeachersSubjectsCommand putTeachersSubjects)
	{
		var result = await _mediator.Send(putTeachersSubjects);
		return Ok(result);
	}

	[HttpDelete]
	public async ValueTask<IActionResult> DeleteTeachersSubjects(DeleteTeachersSubjectsCommand deleteTeachersSubjects)
	{
		var result = await _mediator.Send(deleteTeachersSubjects);
		return Ok(result);
	}


}
