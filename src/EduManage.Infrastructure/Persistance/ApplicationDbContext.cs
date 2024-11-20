using EduManage.Application.Abstraction;
using EduManage.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EduManage.Infrastructure.Persistance
{
	public class ApplicationDbContext : DbContext, IApplicationDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		/*protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}*/

		public DbSet<City> Cities { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Students_Subjects> Students_Subjects_s { get; set; }
		public DbSet<Teachers_Subjects> Teachers_Subjects_s { get; set; }

		public delegate void DelSeedData(ModelBuilder modelBuilder);

		#region SeedData Subject
		public void SeedDataSubject(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Subject>().HasData(new List<Subject>()
			{
				new Subject()
				{
					Id = 1 ,
					Name = "Web dasturlash",
					GradeLavel = 7,
					CreatedDate = DateTime.Now,
				},
				new Subject()
				{
					Id = 2,
					Name = "Multimedia Dasturlash",
					GradeLavel = 7,
					CreatedDate = DateTime.Now,
				},
				new Subject()
				{
					Id = 3,
					Name = "Kompyuter ko'rish",
					GradeLavel = 7,
					CreatedDate = DateTime.Now,
				},
				new Subject()
				{
					Id = 4,
					Name = "SMM",
					GradeLavel = 7,
					CreatedDate = DateTime.Now,
				},
				new Subject()
				{
					Id = 5,
					Name = "3D texnalogiya",
					GradeLavel = 7,
					CreatedDate = DateTime.Now,
				},

			});
		}
		#endregion SeedData Subject

		#region SeedData Department
		public void SeedDataDepartment(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<Department>().HasData(new List<Department>
			{
				new Department()
				{
					Id= 1 ,
					Name = "Komputer injinering fakulteti" ,
					CreatedDate = DateTime.Now,

				},
				
			});
		}
		#endregion SeedData Department

		#region SeedData City
		public void SeedDataCity(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<City>().HasData(new List<City>
			{
				new City()
				{
					Id = 1,
					Name = "Toshkent shahri" ,
					CreatedDate = DateTime.Now,
				},
				new City()
				{
					Id = 2 ,
					Name = "Toshkent viloyati",
					CreatedDate = DateTime.Now,
				},
				new City()
				{
					Id = 3,
					Name = "Buxoro voloyati",
					CreatedDate = DateTime.Now,
				},
				new City()
				{
					Id = 4,
					Name = "Fargona viloyati",
					CreatedDate = DateTime.Now,
				}

			});
		}

		#endregion SeedData City

		#region SeedData Teacher
		public void SeedDataTeacher(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Teacher>().HasData(new List<Teacher>
			{
				new Teacher()
				{
					Id = 1,
					Name = "Sadikov Rustamjon" ,
					BirthDate = DateTime.Now,
					CityId = 1 ,
					Gender = Domain.Enums.GenderEnum.Male,
					CreatedDate = DateTime.Now,
				},
				new Teacher()
				{
					Id = 2,
					Name = "Nematov Abdugani" ,
					BirthDate = DateTime.Now,
					CityId = 2 ,
					Gender = Domain.Enums.GenderEnum.Male,
					CreatedDate = DateTime.Now,
				},
				new Teacher()
				{
					Id = 3,
					Name = "Artikova Muazzam" ,
					BirthDate = DateTime.Now,
					CityId = 3 ,
					Gender = Domain.Enums.GenderEnum.Famale,
					CreatedDate = DateTime.Now,
				},
				new Teacher()
				{		
					Id = 4,
					Name = "Abidova Shahnoza" ,
					BirthDate = DateTime.Now,
					CityId = 1 ,
					Gender = Domain.Enums.GenderEnum.Famale,
					CreatedDate = DateTime.Now,
				},

			});
		}

		#endregion SeedData Teacher

		#region SeedData Student
		public void SeedDataStudent(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>().HasData(new List<Student>
			{
				new Student()
				{
					Id = 1,
					Name = "Sevinch Xayriddinobva" ,
					BirthDate = DateTime.Now,
					CityId = 2 ,
					Gender = Domain.Enums.GenderEnum.Famale,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,

				},
				new Student()
				{
					Id = 2,
					Name = "Sabira Qurbonbekova" ,
					BirthDate = DateTime.Now,
					CityId = 2 ,
					Gender = Domain.Enums.GenderEnum.Famale,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},
				new Student()
				{
					Id = 3,
					Name = "Sanjar Toirjonov" ,
					BirthDate = DateTime.Now,
					CityId = 4 ,
					Gender = Domain.Enums.GenderEnum.Male,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},
				new Student()
				{
					Id = 4,
					Name = "Fayzullo Togonboyev" ,
					BirthDate = DateTime.Now,
					CityId = 4 ,
					Gender = Domain.Enums.GenderEnum.Male,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},
				new Student()
				{
					Id = 5,
					Name = "Quvonchbek Toychiyev" ,
					BirthDate = DateTime.Now,
					CityId = 4 ,
					Gender = Domain.Enums.GenderEnum.Male,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},
				new Student()
				{
					Id = 6,
					Name = "Azizbek Shodmonov" ,
					BirthDate = DateTime.Now,
					CityId = 3 ,
					Gender = Domain.Enums.GenderEnum.Male,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},
				new Student()
				{
					Id = 7,
					Name = "Alisher Amrullayev" ,
					BirthDate = DateTime.Now,
					CityId = 4 ,
					Gender = Domain.Enums.GenderEnum.Male,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},
				new Student()
				{
					Id = 8,
					Name = "Jasurbek Abdullayev" ,
					BirthDate = DateTime.Now,
					CityId = 4 ,
					Gender = Domain.Enums.GenderEnum.Male,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},
				new Student()
				{
					Id = 9,
					Name = "Jumagul Muhammadjonova" ,
					BirthDate = DateTime.Now,
					CityId = 4 ,
					Gender = Domain.Enums.GenderEnum.Famale,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},
				new Student()
				{
					Id = 10,
					Name = "Shahnoza Sherqoziyeva" ,
					BirthDate = DateTime.Now,
					CityId = 4 ,
					Gender = Domain.Enums.GenderEnum.Famale,
					CurrentGradeLavel = 7,
					DepartmentId = 1,
					CreatedDate = DateTime.Now,
				},

			});
		}

		#endregion SeedData Student




		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			DelSeedData delSeedData = new DelSeedData(SeedDataCity);
			delSeedData += SeedDataDepartment;
			delSeedData += SeedDataSubject;
			delSeedData += SeedDataStudent;
			delSeedData += SeedDataTeacher;


			delSeedData.Invoke(modelBuilder);

			base.OnModelCreating(modelBuilder);
		}

	}



}

