using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Subject.Commands;
using MediatR;

namespace EduManage.Application.UseCases.Subject.Handlers
{
	public class PostSubjectCommandHandler :
		IRequestHandler<PostSubjectCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostSubjectCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostSubjectCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Domain.Entities.Subject
				{
					Name = request.Name,
					GradeLavel = request.GradeLavel,
					CreatedDate = DateTime.Now
				};
				await _context.Subjects.AddAsync(res);
				await _context.SaveChangesAsync(cancellationToken);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
