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
    public class FeedbacksConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.HasData(DbAutocompleter.Feedbacks);
        }
    }
}
