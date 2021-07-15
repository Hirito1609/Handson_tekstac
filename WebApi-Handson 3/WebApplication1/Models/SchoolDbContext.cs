using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class SchoolDbContext : DbContext
    {
        public virtual DbSet<UserModel> UserModels { get; set; }
    }
}
