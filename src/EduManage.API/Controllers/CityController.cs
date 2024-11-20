using EduManage.Application.UseCases.City.Commands;
using EduManage.Application.UseCases.City.Queries;
using EduManage.Application.UseCases.Students_Subjects.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EduManage.API.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class CityController : ControllerBase
{
	private readonly IMediator _mediator;

	public CityController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async ValueTask<IActionResult> GetAllCities()
	{
		var cities = await _mediator.Send(new GetCityCommand());
		return Ok(cities);
	}

	[HttpPost]
	public async ValueTask<bool> AddCity(PostCityCommand postCity)
	{
		var result = await _mediator.Send(postCity);
		return result;
	}

	[HttpPut]
	public async ValueTask<IActionResult> UpdateCity(PutCityCommand putCity)
	{
		var result = await _mediator.Send(putCity);
		return Ok(result);
	}

	[HttpDelete]
	public async ValueTask<IActionResult> DeleteCity(DeleteStudentSubjectsCommand deleteCity)
	{
		var result = await _mediator.Send(deleteCity);
		return Ok(result);
	}


}

