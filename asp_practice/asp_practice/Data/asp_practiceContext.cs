using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice_POSR_MVC.Models;

namespace asp_practice.Models
{
    public class asp_practiceContext : DbContext
    {
        public asp_practiceContext (DbContextOptions<asp_practiceContext> options)
            : base(options)
        {
        }

        public DbSet<Practice_POSR_MVC.Models.Form> Form { get; set; }
    }
}
