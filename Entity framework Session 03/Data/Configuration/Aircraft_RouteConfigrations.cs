using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_framework_Session_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entity_framework_Session_03.Data.Configuration
{
    public class Aircraft_RouteConfigrations : IEntityTypeConfiguration<Aircraft_Route>
    {
        public void Configure(EntityTypeBuilder<Aircraft_Route> builder)
        {
            builder.HasKey(ar => new {ar.Route_Id,ar.AC_Id});

            builder.HasOne(ar=>ar.aircraft)
                .WithMany(aircraft=> aircraft.Air_Routes)
                .HasForeignKey(ar=>ar.AC_Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ar=>ar.route)
                .WithMany(r=>r.Routes_Aircraft)
                .HasForeignKey(ar=>ar.Route_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
