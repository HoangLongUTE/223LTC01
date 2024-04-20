using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaiHoangLong_120123_CodeFirst.Models;

namespace CaiHoangLong_120123_CodeFirst.Data
{
    public class CaiHoangLong_120123_CodeFirstContext : DbContext
    {
        public CaiHoangLong_120123_CodeFirstContext (DbContextOptions<CaiHoangLong_120123_CodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<CaiHoangLong_120123_CodeFirst.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
