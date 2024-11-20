using MediatR;
namespace EduManage.Application.UseCases.TeachersSubjects.Queries
{
	public class GetTeachersSubjectsCommand : IRequest<List<Domain.Entities.Teachers_Subjects>>
	{
	}
}
