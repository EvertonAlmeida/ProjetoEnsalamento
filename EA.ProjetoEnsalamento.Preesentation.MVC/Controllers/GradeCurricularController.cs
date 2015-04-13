using System;
using System.Web.Mvc;
using EA.ProjetoEnsalamento.Application.Interfaces;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Preesentation.MVC.Controllers
{
    public class GradeCurricularController : Controller
    {
        private readonly IGradeCurricularAppService _gradeCurricularAppService;
        private readonly IFaseAppService _faseAppService;
        private readonly IUnidadeCurricularAppService _unidadeCurricularAppService;
        private readonly ICursoAppService _cursoAppService;

        public GradeCurricularController(IGradeCurricularAppService gradeCurricularAppService, IFaseAppService faseAppService, IUnidadeCurricularAppService unidadeCurricularAppService, ICursoAppService cursoAppService)
        {
            _gradeCurricularAppService = gradeCurricularAppService;
            _faseAppService = faseAppService;
            _unidadeCurricularAppService = unidadeCurricularAppService;
            _cursoAppService = cursoAppService;
        }

        // GET: GradeCurricular
        public ActionResult Index()
        {
            return View(_gradeCurricularAppService.GetAll());
        }

        // GET: GradeCurricular/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_gradeCurricularAppService.GetById(id));
        }

        // GET: GradeCurricular/Create
        public ActionResult Create()
        {
            ViewBag.FaseId = new SelectList(_faseAppService.GetAll(), "FaseId", "Descricao");
            ViewBag.UnidadeCurricularId = new SelectList(_unidadeCurricularAppService.GetAll(), "UnidadeCurricularId", "Nome");
            ViewBag.CursoId = new SelectList(_cursoAppService.GetAll(), "CursoId", "Nome");
            return View();
        }

        // POST: GradeCurricular/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GradeCurricularViewModel gradeCurricularViewModel)
        {
            if (ModelState.IsValid)
            {
                _gradeCurricularAppService.Add(gradeCurricularViewModel);

                return RedirectToAction("Index");
            }

            ViewBag.FaseId = new SelectList(_faseAppService.GetAll(), "FaseId", "Descricao");
            ViewBag.UnidadeCurricularId = new SelectList(_unidadeCurricularAppService.GetAll(), "UnidadeCurricularId", "Nome");
            ViewBag.CursoId = new SelectList(_cursoAppService.GetAll(), "CursoId", "Nome");

            return View(gradeCurricularViewModel);
        }

        // GET: GradeCurricular/Edit/5
        public ActionResult Edit(Guid id)
        {
            var gradeCurricularViewModel = _gradeCurricularAppService.GetById(id);
            ViewBag.FaseId = new SelectList(_faseAppService.GetAll(), "FaseId", "Descricao", gradeCurricularViewModel.FaseId);
            ViewBag.UnidadeCurricularId = new SelectList(_unidadeCurricularAppService.GetAll(), "UnidadeCurricularId", "Nome", gradeCurricularViewModel.UnidadeCurricularId);
            ViewBag.CursoId = new SelectList(_cursoAppService.GetAll(), "CursoId", "Nome", gradeCurricularViewModel.CursoId);
            return View(gradeCurricularViewModel);
        }

        // POST: GradeCurricular/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GradeCurricularViewModel gradeCurricularViewModel)
        {
            if (ModelState.IsValid)
            {
                _gradeCurricularAppService.Update(gradeCurricularViewModel);

                return RedirectToAction("Index");
            }
            ViewBag.FaseId = new SelectList(_faseAppService.GetAll(), "FaseId", "Descricao");
            ViewBag.UnidadeCurricularId = new SelectList(_unidadeCurricularAppService.GetAll(), "UnidadeCurricularId", "Nome");
            ViewBag.CursoId = new SelectList(_cursoAppService.GetAll(), "CursoId", "Nome");

            return View(gradeCurricularViewModel);
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_gradeCurricularAppService.GetById(id));
        }

        // POST: Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _gradeCurricularAppService.Remove(_gradeCurricularAppService.GetById(id));

            return RedirectToAction("Index");
        }
    }
}