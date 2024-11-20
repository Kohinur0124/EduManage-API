using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Teacher.Commands;
using MediatR;

namespace EduManage.Application.UseCases.Teacher.Handlers
{
	public class PostTeacherCommandHandler :
		IRequestHandler<PostTeacherCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostTeacherCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostTeacherCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Domain.Entities.Teacher
				{
					Name = request.Name,
					BirthDate = request.BirthDate,
					CityId = request.CityId,
					Gender = request.Gender,
					CreatedDate = DateTime.Now,

				};
				await _context.Teachers.AddAsync(res);
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
