using CommonBase.Extensions;
using EventManager.Contracts.Persistence.Events;
using System;

namespace EventManager.Logic.Entities.Events
{
    partial class Event : VersionEntity, IEvent
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Note { get; set; }

        public void CopyProperties(IEvent other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            RowVersion = other.RowVersion;
            From = other.From;
            To = other.To;
            Title = other.Title;
            Location = other.Location;
            Note = other.Note;
        }
    }
}
