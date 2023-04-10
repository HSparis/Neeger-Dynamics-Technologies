using Microsoft.EntityFrameworkCore;
using Neeger_Dynamics_e_Technologies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neeger_Dynamics_e_Technologies.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedDate(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { ID = Guid.Parse("c7dce21b-d207-4869-bf5f-08eb138bb919"), Name = "User Default", Email = "userdefault@neeger.com" }
                );

            return builder;
        }
    }
}
