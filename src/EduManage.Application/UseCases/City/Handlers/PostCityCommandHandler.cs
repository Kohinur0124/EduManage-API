using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.City.Commands;
using MediatR;

namespace EduManage.Application.UseCases.City.Handlers
{
	public class PostCityCommandHandler :
		IRequestHandler<PostCityCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostCityCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostCityCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Domain.Entities.City
				{
					Name = request.Name,
					CreatedDate = DateTime.Now,

				};
				await _context.Cities.AddAsync(res);
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
