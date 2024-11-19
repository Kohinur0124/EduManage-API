namespace EduManage.Domain.Entities
{
	public class Students_Subjects
	{
		public int Id { get; set; }
		public int Mark { get; set; }

		public int StudentId { get; set; }
		public int SubjectId { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime? LastUpdatedDate { get; set; }
		public bool IsDeleted { get; set; } = false;

		public Student Student { get; set; }
		public Subject Subject { get; set; }
	}
}
