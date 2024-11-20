using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Student.Queries;
using EduManage.Application.UseCases.Teacher.Queries;
using EduManage.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Teacher.Handlers
{
	public class FilterTeacherCommandHandler :
		  IRequestHandler<FilterTeacherCommand, List<Domain.Entities.Teacher>>
	{
		private readonly IApplicationDbContext _context;

		public FilterTeacherCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Teacher>> Handle(FilterTeacherCommand request, CancellationToken cancellationToken)
		{
			var teachers = await _context.Teachers.Where(x => x.IsDeleted == false).ToListAsync();
			var TeacherSubject = await _context.Teachers_Subjects_s.Where(x => x.IsDeleted == false).ToListAsync();

			if (request.Gender.HasValue)
			{
				teachers = teachers.Where(x => x.Gender == request.Gender).ToList();
			}

			if (request.Age.HasValue)
			{
				teachers = teachers.Where(x => request.Age == DateTime.Now.Year - x.BirthDate.Year).ToList();
			}

			if (request.SubjectId.HasValue)
			{
				var teachersId = TeacherSubject.Where(x => x.SubjectId == request.SubjectId).Select(x => x.TeacherId).ToList();

				teachers = teachers.Where(x => teachersId.Any(y => y == x.Id)).ToList();
			}
			
			var chunksize = 10;
			teachers = teachers.Take(chunksize).ToList();

			return teachers;

		}
		

	}
}
