using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.Enums;
using UPS.Framework.Orm.Models.Impl;

namespace UPS.BusinessModels.Entities
{
    /// <summary>
    /// User models in database.
    /// </summary>
    public class User : UPSEntity<long>
    {
        /// <summary>
        /// User first name.
        /// </summary>
        [MaxLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// User last name.
        /// </summary>
        [MaxLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// User email
        /// </summary>
        [MaxLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// User gender.
        /// </summary>
        public GenderEnum Gender { get; set; }

        /// <summary>
        /// User status.
        /// </summary>
        public StatusEnum Status { get; set; }
    }
}
