using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Department.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Department.Handlers
{
	public class GetDepartmentCommandHandler :
		  IRequestHandler<GetDepartmentCommand, List<Domain.Entities.Department>>
	{
		private readonly IApplicationDbContext _context;

		public GetDepartmentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Department>> Handle(GetDepartmentCommand request, CancellationToken cancellationToken)
		{
			return await _context.Departments.Where(x => x.IsDeleted == false).ToListAsync();
		}
	}
}
