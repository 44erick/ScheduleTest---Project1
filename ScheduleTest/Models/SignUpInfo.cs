using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// Model to assign the right validators for the sign up information
namespace ScheduleTest.Models
{
    public class SignUpInfo
    {
        [Key]
        [Required]
        public int GroupId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string GroupDay { get; set; }
        public string GroupTime { get; set; }
    }
}
