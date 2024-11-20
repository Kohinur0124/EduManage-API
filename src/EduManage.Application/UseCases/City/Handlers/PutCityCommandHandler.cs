using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.City.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.City.Handlers
{
	public class PutCityCommandHandler :
		 IRequestHandler<PutCityCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutCityCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutCityCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.Cities.
					FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted==false);

				res.Name = request.Name;
				res.LastUpdatedDate = DateTime.Now;


				_context.Cities.Update(res);

				await _context.SaveChangesAsync(cancellationToken);
				return true;

			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
