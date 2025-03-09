using Crucero.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Crucero.Web.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IServiceReserva _serviceReserva;

        public ReservaController(IServiceReserva serviceReserva)
        {
            _serviceReserva = serviceReserva;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var collection = await _serviceReserva.ListAsync();
            return View(collection);
        }
        
        public async Task<ActionResult> DetalleReserva(int? id)
        {
            try
            {
                if (id == null)
                {
                    return RedirectToAction("Index");
                }
                var @object = await _serviceReserva.FindByIdAsync(id.Value);
                if (@object == null)
                {
                    throw new Exception("Reserva no existente");
                }
                return View(@object);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
