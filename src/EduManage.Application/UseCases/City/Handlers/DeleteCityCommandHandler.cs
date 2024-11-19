using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.City.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace EduManage.Application.UseCases.City.Handlers
{
	public class DeleteCityCommandHandler :
		IRequestHandler<DeleteCityCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public DeleteCityCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = await _context.Cities.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				if (res == null)
				{
					return false;
				}
				res.IsDeleted = true;
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
