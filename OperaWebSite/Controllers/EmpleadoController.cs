using Microsoft.AspNetCore.Mvc;
using OperaWebSite.Models;
using System.Linq;

namespace OperaWebSite.Controllers
{
    public class EmpleadoController : Controller
    {
        //inyección de dependencia
        private readonly OperaDBContext context;
        public EmpleadoController(OperaDBContext context)
        {
            this.context = context;
        }


        //Traer todos los empleados desde la DB y enviar una vista al cliente. La vista"index" recibe una colección de empleados "listado"
        //RUTA: /Empleado
        [HttpGet]
        public IActionResult Index()
        {
            var listado = context.Empleados.ToList();
            return View("Index", listado);
        }

        [HttpGet]
        public ActionResult Create()
        {
            //crear una instancia del empleado
            Empleado empleado = new Empleado();

            //a la vista "create" le enviamos la instancia creada en el paso anterior
            return View("Create", empleado);


        }


        // OTRA POST PARA RECIBIR DEL CLIENTE EL MODELO (NUEVO EMPLEADO) Y GUARDAR EN LA DB
        // RUTA: /Empleado/Create
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            //si las validaciones del modelo está ok -->True entonces guardamos en la db el nuevo empleado
            if (ModelState.IsValid)
            {
                //EF guardar en memoria
                context.Empleados.Add(empleado);
                //EF guardar en al DB -- INSERT INTO
                context.SaveChanges();
                //redireccionar a la acción "index"
                return RedirectToAction("Index");
            }

            //vuelve a la vista create 
            return View(empleado);
        }


        //Detalle
        // EL CLIENTE EN LA VISTA INDEX, SELECCIONA UN EMPLEADO PARA VISUALIZAR EL DETALLE
        // LINK RUTA: /EMPLEADO/DETAILS/ID -->/EMPLEADO/DETAILS/25
        [HttpGet]
        public ActionResult Details(int id)
        {
            //usamos EF para buscar el empleado por Id
            var empleado = context.Empleados.Find(id);

            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Detalle", empleado);
            }

        }

        //ELIMINAR UN EMPLEADO
        // UNA ACCIÓN POR GET--> QUE RECIBE EL ID DEL EMPLEADO QUE DEBE BUSCAR EN LA DB. SI EXISTE LO ENVIAMOS A LA VISTA "DELETE" Y PREGUNTAMOS SI DESEA ELIMINARLO.
        //RUTA: /EMPLEADO/DELETE/ID --->/EMPLEADO/DELETE/55
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var empleadoDelete = context.Empleados.Find(id);
            if (empleadoDelete == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", empleadoDelete);

            }

        }

        //UNA ACCIÓN POR POST-->CONFIRMA QUE DESEA ELIMINAR ENTOCES EJECUTAMOS EF PARA HACER UN DELETE FROM EN LA DB
        //RUTA /EMPLEADO/DELETE/ID
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var empleadoDelete = context.Empleados.Find(id);
            if (empleadoDelete == null)
            {
                return NotFound();
            }
            else
            {
                //marca deleted en memoria
                context.Empleados.Remove(empleadoDelete);
                //eliminar en la db
                context.SaveChanges();
                return RedirectToAction("Index");

            }
        }

        //EDITAR
        //UNA ACCIÓN QUE ENVIE AL CLIENTE UNA VISTA CON ELMODELO PARA EDITAR:GET
        //ruta /EMPLEADO/EDIT/ID -->/EMPLEADO/EDIT/50 
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var empleadoEdit = context.Empleados.Find(id);
            if (empleadoEdit == null)
            {
                return NotFound();
            }
            else
            {
                return View("Editar", empleadoEdit);
            }
        }

        // UNA ACCIÓN QUE ENVIE LAS MODIFICACIONES A LA DB -->UPDATE:POST
        //ruta /EMPLEADO/EDIT
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Empleado empleadoMoficado)
        {
            if (ModelState.IsValid)
            {
                context.Entry(empleadoMoficado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("Editar", empleadoMoficado);
            }
        }


    }
}
