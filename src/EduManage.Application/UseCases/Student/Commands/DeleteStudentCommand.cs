using MediatR;

namespace EduManage.Application.UseCases.Student.Commands
{
	public class DeleteStudentCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
