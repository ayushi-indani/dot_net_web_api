using dot_net_web_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_web_api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        [Route("api/Student/GetStudents")]
        public object GetStudents()
        {
            var studentList = _student.GetStudentList();
            return studentList;
        }
    }
}
