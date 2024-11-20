using MediatR;

namespace EduManage.Application.UseCases.City.Commands
{
	public class PutCityCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public string Name { get; set; }


	}
}
