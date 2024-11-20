using MediatR;

namespace EduManage.Application.UseCases.TeachersSubjects.Commands
{
	public class PostTeachersSubjectsCommand : IRequest<bool>
	{
		public int TeacherId { get; set; }

		public int SubjectId { get; set; }

	}
}
