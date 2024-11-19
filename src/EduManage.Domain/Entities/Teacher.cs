using EduManage.Domain.Enums;

namespace EduManage.Domain.Entities
{
	public class Teacher
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }
		public GenderEnum Gender { get; set; }

		public int CityId { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime? LastUpdatedDate { get; set; }
		public bool IsDeleted { get; set; } = false;

		public City City { get; set; }
		public ICollection<Teachers_Subjects>? TeachersSubjects { get; set; }
	}
}
