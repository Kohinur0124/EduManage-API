using EduManage.Domain.Enums;
using MediatR;

namespace EduManage.Application.UseCases.Student.Queries
{
	public class FilterStudentCommand : IRequest<List<Domain.Entities.Student>>
	{
		public GenderEnum? Gender { get; set; }

		public int? DepartmentId { get; set; }

		public int? Age { get; set; }

		public int? CityId { get; set; }

		public ZodiacSignEnum? ZodiacSign {  get; set; } 

		public int? Grade { get; set; }

		public int? SubjectId { get; set;}
	}
}
