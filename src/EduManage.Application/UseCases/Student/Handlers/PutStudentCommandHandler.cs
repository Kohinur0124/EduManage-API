using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Student.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Student.Handlers
{
	public class PutStudentCommandHandler :
		 IRequestHandler<PutStudentCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutStudentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutStudentCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.Students.
					FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				res.LastUpdatedDate = DateTime.Now;

				_context.Students.Update(res);

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
