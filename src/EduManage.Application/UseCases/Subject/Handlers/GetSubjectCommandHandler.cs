using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Subject.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Subject.Handlers
{
	public class GetSubjectCommandHandler :
		  IRequestHandler<GetSubjectCommand, List<Domain.Entities.Subject>>
	{
		private readonly IApplicationDbContext _context;

		public GetSubjectCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Subject>> Handle(GetSubjectCommand request, CancellationToken cancellationToken)
		{
			return await _context.Subjects.Where(x => x.IsDeleted == false).ToListAsync();
		}
	}
}
