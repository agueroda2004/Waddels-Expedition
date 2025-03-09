using Crucero.Application.DTOs;
using Crucero.Application.Services.Implementations;
using Crucero.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crucero.Web.Controllers
{
    public class CruceroController : Controller
    {
        private readonly IServiceCrucero _serviceCrucero;
        private readonly IServiceBarco _serviceBarco;

        public CruceroController(IServiceCrucero serviceCrucero, IServiceBarco serviceBarco)
        {
            this._serviceCrucero = serviceCrucero;
            this._serviceBarco = serviceBarco;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var collection = await _serviceCrucero.ListAsync();
            return View(collection);
        }
        // Obtener un crucero
        public async Task<ActionResult> DetalleCrucero(int? id)
        {
            try
            {
                if (id == null)
                {
                    return RedirectToAction("Index");
                }
                var @object = await _serviceCrucero.FindByIdAsync(id.Value);
                if (@object == null)
                {
                    throw new Exception("Crucero no existente");
                }
                return View(@object);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        // GET: LibroController/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.ListBarco = await _serviceBarco.ListAsync();
            //var categorias = await _serviceCategoria.ListAsync();
            //ViewBag.ListCategorias = new MultiSelectList(categorias, "IdCategoria", "Nombre");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CruceroDTO dto, IFormFile imageFile)
        {
            MemoryStream target = new MemoryStream();

            // Remove Foto from ModelState validation to avoid "required" error
            ModelState.Remove("Foto");

            if (dto.Foto == null)
            {
                if (imageFile != null)
                {
                    imageFile.OpenReadStream().CopyTo(target);
                    dto.Foto = target.ToArray();
                }
            }

            if (!ModelState.IsValid)
            {
                string errors = string.Join("; ", ModelState.Values
                                   .SelectMany(x => x.Errors)
                                   .Select(x => x.ErrorMessage));
                return BadRequest(errors);
            }

            await _serviceCrucero.AddAsync(dto);
            return RedirectToAction("Index");
        }


    }
}
