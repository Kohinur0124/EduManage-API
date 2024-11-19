using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Student.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Student.Handlers
{
	public class GetStudentCommandHandler :
		  IRequestHandler<GetStudentCommand, List<Domain.Entities.Student>>
	{
		private readonly IApplicationDbContext _context;

		public GetStudentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Student>> Handle(GetStudentCommand request, CancellationToken cancellationToken)
		{
			return await _context.Students.Where(x => x.IsDeleted == false).ToListAsync();
		}
	}
}
