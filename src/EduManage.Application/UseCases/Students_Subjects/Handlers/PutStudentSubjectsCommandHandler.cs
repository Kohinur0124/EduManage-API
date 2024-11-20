using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Students_Subjects.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Students_Subjects.Handlers
{
	public class PutStudentSubjectsCommandHandler :
		 IRequestHandler<PutStudentSubjectsCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutStudentSubjectsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutStudentSubjectsCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.Students_Subjects_s.
					FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				res.SubjectId = request.SubjectId;
				res.StudentId = request.StudentId;
				res.Mark = request.Mark;
				res.LastUpdatedDate = DateTime.Now;


				_context.Students_Subjects_s.Update(res);

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
