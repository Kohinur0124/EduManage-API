using EduManage.Domain.Enums;
using MediatR;

namespace EduManage.Application.UseCases.Teacher.Commands
{
	public class PutTeacherCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime BirthDate { get; set; }

		public GenderEnum Gender { get; set; }

		public int CityId { get; set; }


	}
}
