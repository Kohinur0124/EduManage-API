using EduManage.Application.Abstraction;
using EduManage.Application.UseCases.Student.Commands;
using MediatR;

namespace EduManage.Application.UseCases.Student.Handlers
{
	public class PostStudentCommandHandler :
		IRequestHandler<PostStudentCommand, bool>
	{
		private readonly IApplicationDbContext _context;

		public PostStudentCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> Handle(PostStudentCommand request, CancellationToken cancellationToken)
		{
			try
			{
				var res = new Domain.Entities.Student
				{
					Name = request.Name,
					BirthDate = request.BirthDate,
					Gender = request.Gender,
					CurrentGradeLavel = request.CurrentGradeLavel,
					CityId = request.CityId,
					DepartmentId = request.DepartmentId,
					CreatedDate = DateTime.Now,

				};
				await _context.Students.AddAsync(res);
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
