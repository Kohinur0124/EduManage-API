using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Department.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.Department.Handlers
{
	public class DeleteDepartmentCommandHandler :
		IRequestHandler<DeleteDepartmentCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteDepartmentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.Departments.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				if (res == null)
				{
					return false;
				}
				res.LastUpdatedDate = DateTime.Now;
				res.IsDeleted = false;

				_context.Departments.Update(res);
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
