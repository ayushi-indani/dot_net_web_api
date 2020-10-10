using dot_net_web_api.Data;
using dot_net_web_api.Services;
using dot_net_web_api.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace dot_net_web_api.Repository
{
    public class StudentRepository : IStudent
    {
        private readonly StudentEntities _entities;

        public StudentRepository(StudentEntities entities)
        {
            _entities = entities;
        }
        public List<StudentResponse> GetStudentList()
        {
            var studentList = _entities.Students
                .Select(x => new StudentResponse
                {
                    student_key = x.student_key,
                    student_name = x.student_name,
                    student_code = x.student_code
                }).ToList();

            return studentList;
        }
    }
}
