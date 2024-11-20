using MediatR;
namespace EduManage.Application.UseCases.Students_Subjects.Queries
{
	public class GetStudentSubjectsCommand : IRequest<List<Domain.Entities.Students_Subjects>>
	{
	}
}
