using MediatR;

namespace EduManage.Application.UseCases.Subject.Commands
{
	public class PostSubjectCommand : IRequest<bool>
	{
		public string Name { get; set; }

		public int GradeLavel { get; set; }
	}
}
