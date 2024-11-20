using EduManage.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.Abstraction
{
	public interface IApplicationDbContext
	{
		public DbSet<City> Cities { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Students_Subjects> Students_Subjects_s { get; set; }
		public DbSet<Teachers_Subjects> Teachers_Subjects_s { get; set; }

		public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
