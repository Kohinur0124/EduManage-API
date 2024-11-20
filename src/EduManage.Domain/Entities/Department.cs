namespace EduManage.Domain.Entities
{
	public class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime? LastUpdatedDate { get; set; }
		public bool IsDeleted { get; set; } = false;

		public ICollection<Student> Students { get; set; }
	}
}
