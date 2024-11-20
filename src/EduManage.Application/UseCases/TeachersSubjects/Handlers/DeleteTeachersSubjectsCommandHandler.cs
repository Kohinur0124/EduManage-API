using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.TeachersSubjects.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.TeachersSubjects.Handlers
{
	public class DeleteTeachersSubjectsCommandHandler :
		IRequestHandler<DeleteTeachersSubjectsCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteTeachersSubjectsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteTeachersSubjectsCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.Teachers_Subjects_s.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				if (res == null)
				{
					return false;
				}
				res.IsDeleted = true;
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
