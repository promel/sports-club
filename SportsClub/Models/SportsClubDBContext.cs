using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsClub.Models
{
    public class SportsClubDBContext: DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Sport> Sports{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=SportsClubDb;Integrated Security=True");
        }
    }
}
