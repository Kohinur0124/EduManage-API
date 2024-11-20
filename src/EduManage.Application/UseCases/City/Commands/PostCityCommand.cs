using MediatR;

namespace EduManage.Application.UseCases.City.Commands
{
	public class PostCityCommand : IRequest<bool>
	{
		public string Name { get; set; }



	}
}
