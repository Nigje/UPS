using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS.Framework.Options.Models
{
    /// <summary>
    /// Authorization in app.settings.
    /// </summary>
    public class AuthorizationOption : IOptionModel
    {
        public List<UserOption> Users { get; set; } = new List<UserOption>();
    }
}
