using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS.Framework.DI
{
    /// <summary>
    /// Instance per request. Due to the Dependency Injection concept, we choose ScopedLifeTime.
    /// </summary>
    public interface IScopedLifetime
    {
        //Nothing.
    }
}
