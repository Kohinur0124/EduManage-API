using MediatR;

namespace EduManage.Application.UseCases.Subject.Commands
{
	public class DeleteSubjectCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
