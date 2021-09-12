using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.Enums;

namespace UPS.BusinessModels.User
{
    public class UserQueryModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public GenderEnum? Gender { get; set; }
        public StatusEnum? Status { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}
