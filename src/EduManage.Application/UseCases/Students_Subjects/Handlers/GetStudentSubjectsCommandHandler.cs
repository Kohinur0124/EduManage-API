using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.City.Commands;
using EduManage.Application.UseCases.Students_Subjects.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.Students_Subjects.Handlers
{
	public class GetStudentSubjectsCommandHandler :
		  IRequestHandler<GetStudentSubjectsCommand, List<Domain.Entities.Students_Subjects>>
	{
		private readonly IApplicationDbContext _context;

		public GetStudentSubjectsCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Students_Subjects>> Handle(GetStudentSubjectsCommand request, CancellationToken cancellationToken)
		{
			return await _context.Students_Subjects_s.Where(x => x.IsDeleted == false).ToListAsync();
		}
	}
}
