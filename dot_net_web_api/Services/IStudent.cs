using dot_net_web_api.ViewModel;
using System.Collections.Generic;

namespace dot_net_web_api.Services
{
    public interface IStudent
    {
        List<StudentResponse> GetStudentList();
    }
}
