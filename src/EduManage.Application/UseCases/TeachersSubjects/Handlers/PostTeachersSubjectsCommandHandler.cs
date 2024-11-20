using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.TeachersSubjects.Commands;
using MediatR;

namespace EduManage.Application.UseCases.TeachersSubjects.Handlers
{
	public class PostTeachersSubjectsCommandHandler :
		IRequestHandler<PostTeachersSubjectsCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostTeachersSubjectsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostTeachersSubjectsCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Domain.Entities.Teachers_Subjects
				{
					SubjectId = request.SubjectId,
					TeacherId = request.TeacherId,
					CreatedDate = DateTime.Now,

				};
				await _context.Teachers_Subjects_s.AddAsync(res);
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
