using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.Enums;

namespace UPS.BusinessModels.User
{
    public class UserModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public GenderEnum Gender { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
