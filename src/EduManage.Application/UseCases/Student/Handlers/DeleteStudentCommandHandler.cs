using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Student.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.Student.Handlers
{
	public class DeleteStudentCommandHandler :
		IRequestHandler<DeleteStudentCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteStudentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.Students.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				if (res == null)
				{
					return false;
				}
				res.LastUpdatedDate = DateTime.Now;
				res.IsDeleted = true;
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
