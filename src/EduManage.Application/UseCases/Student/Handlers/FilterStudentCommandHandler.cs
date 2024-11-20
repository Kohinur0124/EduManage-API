using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Student.Queries;
using EduManage.Application.UseCases.Teacher.Handlers;
using EduManage.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Student.Handlers
{
    public class FilterStudentCommandHandler :
		  IRequestHandler<FilterStudentCommand, List<Domain.Entities.Student>>
	{
		private readonly IApplicationDbContext _context;

		public FilterStudentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.Student>> Handle(FilterStudentCommand request, CancellationToken cancellationToken)
		{
			var student = await _context.Students.Where(x => x.IsDeleted == false).ToListAsync();
			var studentSubject = await _context.Students_Subjects_s.Where(x => x.IsDeleted == false).ToListAsync();

			if (request.Gender.HasValue)
			{
				student =  student.Where(x=>x.Gender== request.Gender).ToList();
			}

			if (request.Age.HasValue) 
			{
				student = student.Where(x=>request.Age == DateTime.Now.Year-x.BirthDate.Year).ToList();
			}

			if (request.DepartmentId.HasValue)
			{
				student = student.Where(x=>x.DepartmentId == request.DepartmentId).ToList();
			}

			if (request.CityId.HasValue)
			{
				student = student.Where(x => x.CityId == request.CityId).ToList();
			}
			if (request.Grade.HasValue) 
			{
				student = student.Where(x=>x.CurrentGradeLavel == request.Grade).ToList();
			}
			if(request.SubjectId.HasValue)
			{
				var studentIds = studentSubject.Where(x=>x.SubjectId == request.SubjectId).Select(x=>x.StudentId).ToList();

				student = student.Where(x=> studentIds.Any(y=> y==x.Id)).ToList();
			}
			if(request.ZodiacSign.HasValue) 
			{
				student = student.Where(x=> GetZodiacSign(x.BirthDate)==request.ZodiacSign).ToList();
			}
			var chunksize = 10;
			student = student.Take(chunksize).ToList();

			return student;

		}
		private ZodiacSignEnum GetZodiacSign(DateTime birthDate)
		{
			var month = birthDate.Month;
			var day = birthDate.Day;

			return month switch
			{
				1 => day <= 19 ? ZodiacSignEnum.Capricorn : ZodiacSignEnum.Aquarius,
				2 => day <= 18 ? ZodiacSignEnum.Aquarius : ZodiacSignEnum.Pisces,
				3 => day <= 20 ? ZodiacSignEnum.Pisces : ZodiacSignEnum.Aries,
				4 => day <= 19 ? ZodiacSignEnum.Aries : ZodiacSignEnum.Taurus,
				5 => day <= 20 ? ZodiacSignEnum.Taurus : ZodiacSignEnum.Gemini,
				6 => day <= 20 ? ZodiacSignEnum.Gemini : ZodiacSignEnum.Cancer,
				7 => day <= 22 ? ZodiacSignEnum.Cancer : ZodiacSignEnum.Leo,
				8 => day <= 22 ? ZodiacSignEnum.Leo : ZodiacSignEnum.Virgo,
				9 => day <= 22 ? ZodiacSignEnum.Virgo : ZodiacSignEnum.Libra,
				10 => day <= 22 ? ZodiacSignEnum.Libra : ZodiacSignEnum.Scorpio,
				11 => day <= 21 ? ZodiacSignEnum.Scorpio : ZodiacSignEnum.Sagittarius,
				12 => day <= 21 ? ZodiacSignEnum.Sagittarius : ZodiacSignEnum.Capricorn,
				_ => throw new ArgumentOutOfRangeException()
			};
		}

	}
}
