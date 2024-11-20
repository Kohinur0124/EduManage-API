using MediatR;

namespace EduManage.Application.UseCases.TeachersSubjects.Commands
{
	public class PutTeachersSubjectsCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public int TeacherId { get; set; }

		public int SubjectId { get; set; }

	}
}
