using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using prueba.Models;
using prueba.Models.ViewModels;

namespace prueba.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult estudiante()

        {
            List<vmestudiante> lst;
            using (colegioEntities1 db = new colegioEntities1())
            {
                lst = (from d in db.estudiante
                       select new vmestudiante
                       {
                           idestudiante = d.idestudiante,
                           dni = d.dni,
                           nombre = d.nombre,
                           ape_pat = d.ape_pat,
                           ape_mat = d.ape_mat,
                           direccion = d.direccion,
                           celular = d.celular,
                           correo = d.correo,
                           fec_nac = (DateTime)d.fec_nac,

                       }).ToList();


            }

            return View(lst);
        }

        public ActionResult NuevoEstudiante()
        {
            return View();

        }
        [HttpPost]
        public ActionResult NuevoEstudiante(vmestudiante model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (colegioEntities1 db = new colegioEntities1())

                    {
                        var otabla = new estudiante();

                        otabla.idestudiante = model.idestudiante;
                        otabla.dni = model.dni;
                        otabla.nombre = model.nombre;
                        otabla.ape_pat = model.ape_pat;
                        otabla.ape_mat = model.ape_mat;
                        otabla.direccion = model.direccion;
                        otabla.celular = model.celular;
                        otabla.correo = model.correo;
                        otabla.fec_nac = model.fec_nac;

                    }

                    return Redirect("~/estudiante/estudiante");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
   
