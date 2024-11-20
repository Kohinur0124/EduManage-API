using MediatR;

namespace EduManage.Application.UseCases.City.Commands
{
	public class DeleteCityCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
