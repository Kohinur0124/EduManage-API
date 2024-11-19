namespace EduManage.Domain.Entities
{
	public class City
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime? LastUpdatedDate { get; set; }
		public bool IsDeleted { get; set; } = false;

		public ICollection<Student>? Students { get; set; }
		public ICollection<Teacher>? Teachers { get; set; }
	}
}
