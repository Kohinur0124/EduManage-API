using EduManage.Application.Abstraction;
using EduManage.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EduManage.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			var con = configuration.GetConnectionString("Default");
			services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
			options.UseSqlServer(con));
			return services;
		}
	}
}
