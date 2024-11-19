using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Teacher.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Teacher.Handlers
{
	public class GetTeacherCommandHandler :
		  IRequestHandler<GetTeacherCommand, List<Domain.Entities.Teacher>>
	{
		private readonly IApplicationDbContext _context;

		public GetTeacherCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Teacher>> Handle(GetTeacherCommand request, CancellationToken cancellationToken)
		{
			return await _context.Teachers.Where(x => x.IsDeleted == false).ToListAsync();
		}
	}
}
