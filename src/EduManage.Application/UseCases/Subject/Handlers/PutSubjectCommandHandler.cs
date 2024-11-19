using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Subject.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Subject.Handlers
{
	public class PutSubjectCommandHandler :
		 IRequestHandler<PutSubjectCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutSubjectCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutSubjectCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.Subjects.
					FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted ==false);

				res.Name = request.Name;
				res.GradeLavel = request.GradeLavel;
				res.LastUpdatedDate = DateTime.Now;

				_context.Subjects.Update(res);

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
