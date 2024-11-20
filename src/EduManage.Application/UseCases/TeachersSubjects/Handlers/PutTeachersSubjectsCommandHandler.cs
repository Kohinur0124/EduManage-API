using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.TeachersSubjects.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.TeachersSubjects.Handlers
{
	public class PutTeachersSubjectsCommandHandler :
		 IRequestHandler<PutTeachersSubjectsCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutTeachersSubjectsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutTeachersSubjectsCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.Teachers_Subjects_s.
					FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				res.SubjectId = request.SubjectId;
				res.TeacherId = request.TeacherId;
				res.LastUpdatedDate = DateTime.Now;


				_context.Teachers_Subjects_s.Update(res);

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
