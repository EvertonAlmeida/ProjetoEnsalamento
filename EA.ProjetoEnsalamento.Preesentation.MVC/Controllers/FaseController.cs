using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EA.ProjetoEnsalamento.Application.Interfaces;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Preesentation.MVC.Controllers
{
    public class FaseController : Controller
    {

        private readonly IFaseAppService _faseAppService;

        public FaseController(IFaseAppService faseAppService)
        {
            _faseAppService = faseAppService;
        }

        // GET: Fase
        public ActionResult Index()
        {
            return View(_faseAppService.GetAll());
        }

        // GET: Fase/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_faseAppService.GetById(id));
        }

        // GET: Fase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fase/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FaseViewModel faseViewModel)
        {
            if (ModelState.IsValid)
            {
                _faseAppService.Add(faseViewModel);

                return RedirectToAction("Index");
            }
            return View(faseViewModel);
        }

        // GET: Fase/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_faseAppService.GetById(id));
        }

        // POST: Fase/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FaseViewModel faseViewModel)
        {
            if (ModelState.IsValid)
            {
                _faseAppService.Update(faseViewModel);

                return RedirectToAction("Index");
            }

            return View(faseViewModel);
        }

        // GET: Fase/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_faseAppService.GetById(id));
        }

        // POST: Fase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _faseAppService.Remove(_faseAppService.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
