using MediatR;

namespace EduManage.Application.UseCases.Student.Queries
{
	public class GetStudentCommand : IRequest<List<Domain.Entities.Student>>
	{
	}
}
