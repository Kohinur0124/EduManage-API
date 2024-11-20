using EduManage.Domain.Enums;
using MediatR;

namespace EduManage.Application.UseCases.Teacher.Queries
{
    public class FilterTeacherCommand : IRequest<List<Domain.Entities.Teacher>>
    {
        public GenderEnum? Gender { get; set; }

        public int? Age { get; set; }

        public int? SubjectId { get; set; }
    }
}
