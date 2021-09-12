using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UPS.Api.Controllers.Dtos
{

    public class UserQueryDto
    {
        [FromQuery(Name = "first_name")]
        public string FirstName { get; set; }
        [FromQuery(Name = "last_name")]
        public string LastName { get; set; }

        [FromQuery(Name = "email")]
        public string Email { get; set; }

        [FromQuery(Name = "gender")]
        public string Gender { get; set; }

        [FromQuery(Name = "status")]
        public string Status { get; set; }

        [FromQuery(Name = "from_date")]
        public DateTime? FromDate { get; set; }

        [FromQuery(Name = "to_date")]
        public DateTime? ToDate { get; set; }

        [FromQuery(Name = "page_number")]
        public int? PageNumber { get; set; }

        [FromQuery(Name = "page_size")]
        public int? PageSize { get; set; }
    }
}
