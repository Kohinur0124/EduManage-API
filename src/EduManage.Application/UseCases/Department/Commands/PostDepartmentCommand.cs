using MediatR;

namespace EduManage.Application.UseCases.Department.Commands
{
	public class PostDepartmentCommand : IRequest<bool>
	{
		public string Name { get; set; }
	}
}
