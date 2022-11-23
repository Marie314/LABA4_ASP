using HairdressingSalon.DAL.Autocomplete;
using HairdressingSalon.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairdressingSalon.DAL.Database.EntitiesConfiguration
{
    public class ServiceKindsConfiguration : IEntityTypeConfiguration<ServiceKind>
    {
        public void Configure(EntityTypeBuilder<ServiceKind> builder)
        {
            builder.HasData(DbAutocompleter.ServiceKinds);
        }
    }
}
