using MediatR;

namespace EduManage.Application.UseCases.Students_Subjects.Commands
{
	public class PutStudentSubjectsCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public int StudentId { get; set; }

		public int SubjectId { get; set; }

		public int Mark { get; set; }


	}
}
