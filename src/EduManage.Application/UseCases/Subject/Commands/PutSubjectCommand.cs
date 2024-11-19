using MediatR;

namespace EduManage.Application.UseCases.Subject.Commands
{
	public class PutSubjectCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int GradeLavel { get; set; }
	}
}
