using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Teacher.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Application.UseCases.Teacher.Handlers
{
	public class PutTeacherCommandHandler :
		 IRequestHandler<PutTeacherCommand, bool>
	{

		private readonly IApplicationDbContext _context;

		public PutTeacherCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PutTeacherCommand request, CancellationToken cancellationToken)
		{
			try
			{

				var res = await _context.Teachers.
					FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted == false);

				res.Name = request.Name;
				res.BirthDate = request.BirthDate;
				res.Gender = request.Gender;
				res.CityId = request.CityId;
				res.LastUpdatedDate = DateTime.Now;



				_context.Teachers.Update(res);

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
