using MediatR;

namespace EduManage.Application.UseCases.Department.Commands
{
	public class PutDepartmentCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public string Name { get; set; }
	}
}
