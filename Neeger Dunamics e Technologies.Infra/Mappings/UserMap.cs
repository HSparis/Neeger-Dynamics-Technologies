using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Neeger_Dynamics_e_Technologies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neeger_Dynamics_e_Technologies.Data.Mappings
{
    public class UserMap: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(gs => gs.ID).IsRequired();

            builder.Property(gs => gs.Name).HasMaxLength(256).IsRequired();
        }

    }
}
