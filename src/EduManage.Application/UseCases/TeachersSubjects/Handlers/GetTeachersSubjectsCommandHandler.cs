using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.TeachersSubjects.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.TeachersSubjects.Handlers
{
	public class GetTeachersSubjectsCommandHandler :
		  IRequestHandler<GetTeachersSubjectsCommand, List<Domain.Entities.Teachers_Subjects>>
	{
		private readonly IApplicationDbContext _context;

		public GetTeachersSubjectsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Teachers_Subjects>> Handle(GetTeachersSubjectsCommand request, CancellationToken cancellationToken)
		{
			return await _context.Teachers_Subjects_s.Where(x => x.IsDeleted == false).ToListAsync();
		}
	}
}
