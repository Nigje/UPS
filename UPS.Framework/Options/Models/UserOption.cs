using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS.Framework.Options.Models
{
    public class UserOption
    {
        /// <summary>
        /// Authorization token in header.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// UserId.
        /// </summary>
        public long UserId { get; set; }
    }
}
