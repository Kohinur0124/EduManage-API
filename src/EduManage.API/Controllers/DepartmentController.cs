using EduManage.Application.UseCases.Department.Commands;
using EduManage.Application.UseCases.Department.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EduManage.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
	private readonly IMediator _mediator;

	public DepartmentController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllDepartments()
	{
		var departments = await _mediator.Send(new GetDepartmentCommand());
		return Ok(departments);
	}

	[HttpPost]
	public async ValueTask<bool> AddDepartments(PostDepartmentCommand postDepartment)
	{
		var result = await _mediator.Send(postDepartment);
		return result;
	}
	[HttpPut]

	public async ValueTask<IActionResult> UpdateDepartment(PutDepartmentCommand putDepartment)
	{
		var result = await _mediator.Send(putDepartment);
		return Ok(result);
	}

	[HttpDelete]

	public async ValueTask<IActionResult> DeleteDepartment(DeleteDepartmentCommand deleteDepartment)
	{
		var result = await _mediator.Send(deleteDepartment);
		return Ok(result);
	}


}
