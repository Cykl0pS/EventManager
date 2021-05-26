using EventManager.AspMvc.Models.Events;
using EventManager.Contracts.Persistence.Events;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.AspMvc.Controllers
{
    public class EventController : GenericModelController<IEvent, Event>
    {

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            var entity = await ctrl.CreateAsync().ConfigureAwait(false);

            return View(ToModel(entity));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Event model)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            await ctrl.InsertAsync(model).ConfigureAwait(false);
            await ctrl.SaveChangesAsync().ConfigureAwait(false);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

            return View(ToModel(entity));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Event model)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            var entity = await ctrl.GetByIdAsync(model.Id).ConfigureAwait(false);

            if (entity != null)
            {
                entity.From = model.From;
                entity.To = model.To;
                entity.Title = model.Title;
                entity.Location = model.Location;
                entity.Note = model.Note;

                await ctrl.UpdateAsync(entity).ConfigureAwait(false);
                await ctrl.SaveChangesAsync().ConfigureAwait(false);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();
            var entity = await ctrl.GetByIdAsync(id).ConfigureAwait(false);

            return View(ToModel(entity));
        }

        public async Task<IActionResult> DeleteEntity(int id)
        {
            using var ctrl = Logic.Factory.Create<IEvent>();

            await ctrl.DeleteAsync(id).ConfigureAwait(false);
            await ctrl.SaveChangesAsync().ConfigureAwait(false);

            return RedirectToAction("Index");
        }
    }
}
