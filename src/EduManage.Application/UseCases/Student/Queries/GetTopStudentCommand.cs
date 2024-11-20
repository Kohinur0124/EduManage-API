using MediatR;

namespace EduManage.Application.UseCases.Student.Queries
{
	public class GetTopStudentCommand : IRequest<List<Domain.Entities.Student>>
	{
		public int SubjectId { get; set; }
	}
}
