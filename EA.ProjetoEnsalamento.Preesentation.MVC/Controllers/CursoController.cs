using System;
using System.Linq;
using System.Web.Mvc;
using EA.ProjetoEnsalamento.Application.Interfaces;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Preesentation.MVC.Controllers
{
    public class CursoController : Controller
    {
        private readonly ICursoAppService _cursoAppService;
        private readonly IModalidadeAppService _modalidadeAppService;

        public CursoController(ICursoAppService cursoAppService, IModalidadeAppService modalidadeAppService)
        {
            _cursoAppService = cursoAppService;
            _modalidadeAppService = modalidadeAppService;
        }

        // GET: Curso
        public ActionResult Index()
        {
            return View(_cursoAppService.GetAll());
        }

        // GET: Curso/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_cursoAppService.GetById(id));
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            ViewBag.ModalidadeId = new SelectList(_modalidadeAppService.GetAll(), "ModalidadeId", "Nome");
            return View();
        }

        // POST: Curso/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CursoViewModel cursoViewModel)
        {
            if (ModelState.IsValid)
            {
                _cursoAppService.Add(cursoViewModel);

                return RedirectToAction("Index");
            }
            ViewBag.ModalidadeId = new SelectList(_modalidadeAppService.GetAll(), "ModalidadeId", "Nome");
            return View(cursoViewModel);
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(Guid id)
        {
            var cursoViewModel = _cursoAppService.GetById(id);
            ViewBag.ModalidadeId = new SelectList(_modalidadeAppService.GetAll(), "ModalidadeId", "Nome",cursoViewModel.ModalidadeId);
            return View(cursoViewModel);
        }

        // POST: Curso/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CursoViewModel cursoViewModel)
        {
            if (ModelState.IsValid)
            {
                _cursoAppService.Update(cursoViewModel);

                return RedirectToAction("Index");
            }
            ViewBag.ModalidadeId = new SelectList(_modalidadeAppService.GetAll(), "ModalidadeId", "Nome");
            return View(cursoViewModel);
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_cursoAppService.GetById(id));
        }

        // POST: Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _cursoAppService.Remove(_cursoAppService.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
