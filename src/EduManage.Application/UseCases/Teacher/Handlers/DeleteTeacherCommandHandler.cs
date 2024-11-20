using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Teacher.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.Teacher.Handlers
{
	public class DeleteTeacherCommandHandler :
		IRequestHandler<DeleteTeacherCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteTeacherCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteTeacherCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				if (res == null)
				{
					return false;
				}
				res.IsDeleted = true;
				res.LastUpdatedDate = DateTime.Now;

				_context.Teachers.Update(res);

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
