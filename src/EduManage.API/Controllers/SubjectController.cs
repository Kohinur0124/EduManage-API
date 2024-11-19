using EduManage.Application.UseCases.City.Commands;
using EduManage.Application.UseCases.City.Queries;
using EduManage.Application.UseCases.Subject.Commands;
using EduManage.Application.UseCases.Subject.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EduManage.API.Controllers;

[Route("api/[controller]")]
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
	public async ValueTask<IActionResult> DeleteCity(DeleteSubjectCommand deleteSubject)
	{
		var result = await _mediator.Send(deleteSubject);
		return Ok(result);
	}


}
