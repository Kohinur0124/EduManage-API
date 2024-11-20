using MediatR;

namespace EduManage.Application.UseCases.Students_Subjects.Commands
{
	public class DeleteStudentSubjectsCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
