using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCodder.DataAccess.Data
{
    public class BestCodderCourseContext : DbContext
    {
        public BestCodderCourseContext(DbContextOptions<BestCodderCourseContext> options) 
            : base(options)
        { 
        }

        DbSet<Course> Courses { get; set; }
    }
}
