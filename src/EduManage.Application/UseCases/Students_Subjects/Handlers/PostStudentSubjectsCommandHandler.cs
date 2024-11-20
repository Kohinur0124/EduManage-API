using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Students_Subjects.Commands;
using MediatR;

namespace EduManage.Application.UseCases.Students_Subjects.Handlers
{
	public class PostStudentSubjectsCommandHandler :
		IRequestHandler<PostStudentSubjectsCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostStudentSubjectsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostStudentSubjectsCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Domain.Entities.Students_Subjects
				{
					StudentId = request.StudentId,
					SubjectId = request.SubjectId,
					Mark = request.Mark,
					CreatedDate = DateTime.Now,

				};
				await _context.Students_Subjects_s.AddAsync(res);
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
