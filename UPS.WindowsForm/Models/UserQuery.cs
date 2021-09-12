using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UPS.WindowsForm.Models
{
    public class UserQuery
    {
        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }
        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "gender")]
        public string Gender { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "from_date")]
        public DateTime? FromDate { get; set; }

        [DataMember(Name = "to_date")]
        public DateTime? ToDate { get; set; }

        [DataMember(Name = "page_number")]
        public int? PageNumber { get; set; }

        [DataMember(Name = "page_size")]
        public int? PageSize { get; set; }

    }
}
