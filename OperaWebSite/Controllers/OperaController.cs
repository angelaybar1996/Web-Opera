using Microsoft.AspNetCore.Mvc;
using OperaWebSite.Models;
using System.Linq;

namespace OperaWebSite.Controllers
{
    //RUTA
    //{CONTROLLER]
    // /OPERA esta ruta por defecto va a index
    public class OperaController : Controller
    {
        //inyeccion de dependencia
        private readonly OperaDBContext context;
        public OperaController(OperaDBContext context)
        {
            this.context = context;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Operas.ToList());
        }

        [HttpGet] //enviar al usuario la vista de carga de datos
        public ActionResult Create()
        {
            Opera opera = new Opera();
            return View(opera);
        }

        [HttpPost]// guardar en la DB
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                //EF insertar en la DB
                context.Operas.Add(opera);//memoria
                context.SaveChanges();//insertar en la DB

                // te envia a index
                return RedirectToAction("Index");
            }

            return View(opera);
        }

        //Detalle
        // EL CLIENTE EN LA VISTA INDEX, SELECCIONA UNA OPERA PARA VISUALIZAR EL DETALLE
        // LINK RUTA: /OPERA/DETAILS/ID
        [HttpGet]
        public ActionResult Details(int id)
        {
            //usamos EF para buscar la opera por Id
            var opera = context.Operas.Find(id);

            if (opera == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", opera);
            }

        }


        //ELIMINAR UNA OPERA
        // UNA ACCIÓN POR GET--> QUE RECIBE EL ID DE LA OPERA QUE DEBE BUSCAR EN LA DB. SI EXISTE LO ENVIAMOS A LA VISTA "DELETE" Y PREGUNTAMOS SI DESEA ELIMINARLO.
        //RUTA: /OPERA/DELETE/ID
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var operaDelete = context.Operas.Find(id);
            if (operaDelete == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", operaDelete);

            }

        }

        //UNA ACCIÓN POR POST-->CONFIRMA QUE DESEA ELIMINAR ENTOCES EJECUTAMOS EF PARA HACER UN DELETE FROM EN LA DB
        //RUTA /OPERA/DELETE/ID
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var operaDelete = context.Operas.Find(id);
            if (operaDelete == null)
            {
                return NotFound();
            }
            else
            {
                //marca deleted en memoria
                context.Operas.Remove(operaDelete);
                //eliminar en la db
                context.SaveChanges();
                return RedirectToAction("Index");

            }
        }

    }
}
