namespace EduManage.Domain.Entities
{
	public class Teachers_Subjects
	{
		public int Id { get; set; }

		public int TeacherId { get; set; }
		public int SubjectId { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime? LastUpdatedDate { get; set; }
		public bool IsDeleted { get; set; } = false;

		public Teacher? Teacher { get; set; }
		public Subject? Subject { get; set; }
	}
}
