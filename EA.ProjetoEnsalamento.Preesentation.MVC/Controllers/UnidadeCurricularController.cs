using EA.ProjetoEnsalamento.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Preesentation.MVC.Controllers
{
    public class UnidadeCurricularController : Controller
    {
        private readonly IUnidadeCurricularAppService _uinidadeCurricularAppService;

        public UnidadeCurricularController(IUnidadeCurricularAppService uinidadeCurricularAppService)
        {
            _uinidadeCurricularAppService = uinidadeCurricularAppService;
        }

        // GET: UnidadeCurricular
        public ActionResult Index()
        {
            return View(_uinidadeCurricularAppService.GetAll());
        }

        // GET: UnidadeCurricular/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_uinidadeCurricularAppService.GetById(id));
        }

        // GET: UnidadeCurricular/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidadeCurricular/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UnidadeCurricularViewModel unidadeCurricularViewModel)
        {
            if (ModelState.IsValid)
            {
                _uinidadeCurricularAppService.Add(unidadeCurricularViewModel);

                return RedirectToAction("Index");
            }
            return View(unidadeCurricularViewModel);
        }

        // GET: UnidadeCurricular/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_uinidadeCurricularAppService.GetById(id));
        }

        // POST: UnidadeCurricular/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UnidadeCurricularViewModel unidadeCurricularViewModel)
        {
            if (ModelState.IsValid)
            {
                _uinidadeCurricularAppService.Update(unidadeCurricularViewModel);

                return RedirectToAction("Index");
            }

            return View(unidadeCurricularViewModel);
        }

        // GET: Modalidade/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_uinidadeCurricularAppService.GetById(id));
        }

        // POST: Modalidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _uinidadeCurricularAppService.Remove(_uinidadeCurricularAppService.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
