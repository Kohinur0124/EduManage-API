using MediatR;

namespace EduManage.Application.UseCases.Subject.Queries
{
	public class GetSubjectCommand : IRequest<List<Domain.Entities.Subject>>
	{
	}
}
