using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.BusinessModels.Entities;
using UPS.Framework.Models;
using UPS.Framework.Orm.EntityFrameworkCode;

namespace UPS.DB
{
    public class AppDBContext : UPSDBContext
    {
        public AppDBContext(DbContextOptions options, RequestContext requestContext) : base(options, requestContext)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
