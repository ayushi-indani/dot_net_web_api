using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dot_net_web_api.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        public int student_key { get; set; }
        public string student_name { get; set; }
        public string student_code { get; set; }
    }
}
