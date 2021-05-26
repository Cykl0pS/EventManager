using EventManager.Contracts.Persistence.Events;
using EventManager.Transfer.Models.Persistence.Events;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.WebApi.Controllers.Persistence
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class EventController : GenericController<IEvent, Event>
    {
    }
}
