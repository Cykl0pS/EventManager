using EventManager.Contracts.Client;
using EventManager.Contracts.Persistence.Events;
using EventManager.Logic.Controllers.Persistence.Events;

namespace EventManager.Logic
{
    partial class Factory
    {
        static partial void CreateController<C>(Contracts.IContext context, ref IControllerAccess<C> controller)
            where C : EventManager.Contracts.IIdentifiable
        {
            if (typeof(C) == typeof(IEvent))
            {
                controller = new EventController(context) as IControllerAccess<C>;
            }
        }

        static partial void CreateController<C>(Controllers.ControllerObject controllerObject, ref IControllerAccess<C> controller)
            where C : EventManager.Contracts.IIdentifiable
        {
            if (typeof(C) == typeof(IEvent))
            {
                controller = new EventController(controllerObject) as IControllerAccess<C>;
            }
        }
    }
}
