using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.City.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.City.Handlers
{
	public class GetCityCommandHandler :
		  IRequestHandler<GetCityCommand, List<Domain.Entities.City>>
	{
		private readonly IApplicationDbContext _context;

		public GetCityCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<Domain.Entities.City>> Handle(GetCityCommand request, CancellationToken cancellationToken)
		{
			return await _context.Cities.Where(x => x.IsDeleted == false).ToListAsync();
		}
	}
}
