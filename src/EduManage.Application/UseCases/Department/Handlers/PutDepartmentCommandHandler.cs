using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Department.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Department.Handlers
{
	public class PutDepartmentCommandHandler :
		 IRequestHandler<PutDepartmentCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutDepartmentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutDepartmentCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.Departments.
					FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				res.Name = request.Name;
				res.LastUpdatedDate = DateTime.Now;

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
