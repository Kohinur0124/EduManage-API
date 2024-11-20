using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Student.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Student.Handlers
{
	public class GetTopStudentCommandHandler :
		  IRequestHandler<GetTopStudentCommand, List<Domain.Entities.Student>>
	{
		private readonly IApplicationDbContext _context;

		public GetTopStudentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Student>> Handle(GetTopStudentCommand request, CancellationToken cancellationToken)
		{
			var students = await _context.Students.
				SelectMany(x=>x.StudentsSubjects).
				Where(y=>y.SubjectId==request.SubjectId).
				OrderByDescending(x=>x.Mark).
				ThenBy(y=>y.Student.CurrentGradeLavel).
				ThenBy(y=> DateTime.Now.Year - y.Student.BirthDate.Year).
				Select(x=>x.Student).
				Take(10).
				ToListAsync(cancellationToken);

	

			return  students;

		}
	}
}
