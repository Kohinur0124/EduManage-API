using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Department.Commands;
using MediatR;

namespace EduManage.Application.UseCases.Department.Handlers
{
	public class PostDepartmentCommandHandler :
		IRequestHandler<PostDepartmentCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostDepartmentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostDepartmentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Domain.Entities.Department
				{
					Name = request.Name,
					CreatedDate = DateTime.Now,

				};
				await _context.Departments.AddAsync(res);
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
