using MediatR;
namespace EduManage.Application.UseCases.City.Queries
{
	public class GetCityCommand : IRequest<List<Domain.Entities.City>>
	{
	}
}
