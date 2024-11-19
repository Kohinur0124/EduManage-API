namespace EduManage.Domain.Entities
{
	public class Subject
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int GradeLavel { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime? LastUpdatedDate { get; set; }
		public bool IsDeleted { get; set; } = false;

		public ICollection<Students_Subjects>? StudentsSubjects { get; set; }
		public ICollection<Teachers_Subjects>? TeachersSubjects { get; set; }
	}
}
