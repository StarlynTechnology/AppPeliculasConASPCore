using Microsoft.AspNetCore.Mvc;

using CrudAplicacion.Datos;
using CrudAplicacion.Models;

namespace CrudAplicacion.Controllers
{
    public class MantenedorController : Controller
    {
        PeliculaDatos _PeliculaDatos = new PeliculaDatos();

        public IActionResult Listar()
        {
            // Mostrara la lista de contactos 
            var oLista = _PeliculaDatos.Listar();

            return View(oLista);
        }

        public IActionResult Guardar()
        {
            // Delvover la vista en la aplicacion
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(PeliculaModel oPelicula)
        {
            // Recibe el objeto para guardarlo en la BD

            if (!ModelState.IsValid)
                return View();

            var respuesta = _PeliculaDatos.Guardar(oPelicula);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
            
        }

        public IActionResult Editar(int IdPelicula)
        {
            var oPelicula = _PeliculaDatos.Obtener(IdPelicula);
            return View(oPelicula);
        }

        [HttpPost]
        public IActionResult Editar(PeliculaModel oPelicula)
        {
            if (!ModelState.IsValid)
                return View();

            var respuesta = _PeliculaDatos.Editar(oPelicula);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int IdPelicula)
        {
            var oPelicula = _PeliculaDatos.Obtener(IdPelicula);
            return View(oPelicula);
        }

        [HttpPost]
        public IActionResult Eliminar(PeliculaModel oPelicula)
        {
          
            var respuesta = _PeliculaDatos.Eliminar(oPelicula.IdPelicula);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

    }
}




