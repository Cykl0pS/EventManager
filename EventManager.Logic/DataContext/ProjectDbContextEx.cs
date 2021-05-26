
using EventManager.Contracts.Persistence.Events;
using EventManager.Logic.Entities.Events;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Logic.DataContext
{
    partial class ProjectDbContext
    {
        DbSet<Event> Events { get; set; }

        partial void GetDbSet<C, E>(ref DbSet<E> dbset) where E : class
        {
            if (typeof(C) == typeof(IEvent))
            {
                dbset = Events as DbSet<E>;
            }
        }

        partial void BeforeOnModelCreating(ModelBuilder modelBuilder, ref bool handled)
        {
            var eventBuilder = modelBuilder.Entity<Event>();

            eventBuilder.HasKey(p => p.Id);
            eventBuilder.Property(p => p.RowVersion).IsRowVersion();
            eventBuilder.Property(p => p.From).IsRequired();
            eventBuilder.Property(p => p.To).IsRequired();
            eventBuilder.Property(p => p.Title).IsRequired().HasMaxLength(256);
            eventBuilder.HasIndex(p => p.Title).IsUnique();
            eventBuilder.Property(p => p.Location).IsRequired().HasMaxLength(128);
            eventBuilder.Property(p => p.Note).HasMaxLength(2048);
        }
    }
}
