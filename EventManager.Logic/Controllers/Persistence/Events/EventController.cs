using EventManager.Contracts.Persistence.Events;
using EventManager.Logic.Contracts;
using EventManager.Logic.Entities.Events;
using System;
using System.Threading.Tasks;

namespace EventManager.Logic.Controllers.Persistence.Events
{
    class EventController : GenericPersistenceController<IEvent, Event>
    {
		public EventController(IContext context) : base(context)
		{
		}

		public EventController(ControllerObject other) : base(other)
		{
		}

		private void CheckEvent(IEvent item)
        {
			if (item.Title.Length > 256)
            {
				throw new Exception("Zu lang bro.");
            }
        }

		public override Task<IEvent> InsertAsync(IEvent entity)
        {
			CheckEvent(entity);

			return base.InsertAsync(entity);
        }

		public override Task<IEvent> UpdateAsync(IEvent entity)
		{
			CheckEvent(entity);

			return base.UpdateAsync(entity);
		}
	}
}
