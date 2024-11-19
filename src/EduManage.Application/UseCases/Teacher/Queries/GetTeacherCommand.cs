using MediatR;

namespace EduManage.Application.UseCases.Teacher.Queries
{
	public class GetTeacherCommand : IRequest<List<Domain.Entities.Teacher>>
	{
	}
}
