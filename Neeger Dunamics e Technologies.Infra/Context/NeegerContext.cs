using Microsoft.EntityFrameworkCore;
using Neeger_Dynamics_e_Technologies.Data.Extensions;
using Neeger_Dynamics_e_Technologies.Data.Mappings;
using Neeger_Dynamics_e_Technologies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neeger_Dynamics_e_Technologies.Data.Context
{
    public class NeegerContext: DbContext
    {
        public NeegerContext(DbContextOptions<NeegerContext> option) : base(option)
        {
        
        }


        #region DB Settings

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedDate();

            base.OnModelCreating(modelBuilder);
        }
    }
}
