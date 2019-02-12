using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudAsincrono.Models;
using CrudAsincrono.Repositorio;
using CrudAsincrono.Interfaz;


namespace CrudAsincrono.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly IProfesor _service;

        public ProfesorController(IProfesor service)
        {
            _service = service;
        }
        

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Create(Profesor profesor)
        {
            if (ModelState.IsValid)
            {
                _service.Add(profesor);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(profesor);
            }

        }


        public IActionResult Details (int? Id)
        {
            if (_service.Get(Id)!=null) {

                return View(_service.Get(Id));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Edit(int? Id)
        {
            if (_service.Get(Id) != null)
            {

                return View(_service.Get(Id));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Eliminar(int? Id)
        {
            if (_service.Get(Id) != null)
            {

                return View(_service.Get(Id));
            }
            else
            {
                return NotFound();
            }

        }



    }
}