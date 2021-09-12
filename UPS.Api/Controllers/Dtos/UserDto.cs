using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UPS.Enums;

namespace UPS.Api.Controllers.Dtos
{
    public class UserDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
