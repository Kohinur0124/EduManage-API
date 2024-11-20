using MediatR;

namespace EduManage.Application.UseCases.Students_Subjects.Commands
{
	public class PostStudentSubjectsCommand : IRequest<bool>
	{
		public int StudentId { get; set; }

		public int SubjectId { get; set; }

		public int Mark { get; set; }

	}
}
