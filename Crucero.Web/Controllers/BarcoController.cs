using Crucero.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Crucero.Web.Controllers
{
    public class BarcoController : Controller
    {
        private readonly IServiceBarco _serviceBarco;

        public BarcoController(IServiceBarco _serviceBarco)
        {
            this._serviceBarco = _serviceBarco;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var collection = await _serviceBarco.ListAsync();
            return View(collection);
        }
        
        public async Task<ActionResult> DetalleBarco(int? id)
        {
            try
            {
                if (id == null)
                {
                    return RedirectToAction("Index");
                }
                var @object = await _serviceBarco.FindByIdAsync(id.Value);
                if (@object == null)
                {
                    throw new Exception("Barco no existente");
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
