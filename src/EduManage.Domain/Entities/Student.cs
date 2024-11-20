using EduManage.Domain.Enums;

namespace EduManage.Domain.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }
		public GenderEnum Gender { get; set; }
		public int CurrentGradeLavel { get; set; }

		public int CityId { get; set; }
		public int DepartmentId { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime? LastUpdatedDate { get; set; }
		public bool IsDeleted { get; set; } = false;

		public City City { get; set; }
		public Department Department { get; set; }
		public ICollection<Students_Subjects> StudentsSubjects { get; set; }
	}
}
