using EventManager.Contracts.Persistence.Events;
using EventManager.Logic.Contracts;
using EventManager.Logic.Entities.Events;

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
	}
}
