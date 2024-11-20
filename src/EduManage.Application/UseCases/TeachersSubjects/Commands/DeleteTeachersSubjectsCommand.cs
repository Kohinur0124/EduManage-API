using MediatR;

namespace EduManage.Application.UseCases.TeachersSubjects.Commands
{
	public class DeleteTeachersSubjectsCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
