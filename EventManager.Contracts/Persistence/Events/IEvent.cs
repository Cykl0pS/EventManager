using CommonBase.Attributes;
using System;

namespace EventManager.Contracts.Persistence.Events
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IEvent : IVersionable, ICopyable<IEvent>
    {
        [ContractPropertyInfo(Required = true)]
        public DateTime From { get; set; }

        [ContractPropertyInfo(Required = true)]
        public DateTime To { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 256, IsUnique = true)]
        public string Title { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 128)]
        public string Location { get; set; }

        [ContractPropertyInfo(MaxLength = 2048)]
        public string Note { get; set; }
    }
}
