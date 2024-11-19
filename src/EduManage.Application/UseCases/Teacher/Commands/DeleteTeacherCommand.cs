using MediatR;

namespace EduManage.Application.UseCases.Teacher.Commands
{
	public class DeleteTeacherCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
