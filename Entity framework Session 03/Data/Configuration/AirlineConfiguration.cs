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
    public class AirlineConfiguration : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            builder.HasMany(a => a.Aircrafts)
                .WithOne(ac => ac.Airline)
                .HasForeignKey(a=>a.AL_Id)
                .OnDelete(DeleteBehavior.Restrict);   
            
            builder.HasMany(a=>a.Employees)
                .WithOne(e=>e.Airline)
                .HasForeignKey(e=>e.AL_Id)
                .OnDelete(DeleteBehavior.Restrict); 

        }
    }
}
