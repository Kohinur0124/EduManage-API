using MediatR;

namespace EduManage.Application.UseCases.Department.Queries
{
	public class GetDepartmentCommand : IRequest<List<Domain.Entities.Department>>
	{
	}
}
