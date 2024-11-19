using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Subject.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.Subject.Handlers
{
	public class DeleteSubjectCommandHandler :
		IRequestHandler<DeleteSubjectCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteSubjectCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.Subjects.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				if (res == null)
				{
					return false;
				}
				res.LastUpdatedDate = DateTime.Now;
				res.IsDeleted = true;
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
