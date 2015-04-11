using System;
using System.Web.Mvc;
using EA.ProjetoEnsalamento.Application.Interfaces;
using EA.ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Preesentation.MVC.Controllers
{
    public class ModalidadeController : Controller
    {
        private readonly IModalidadeAppService _modalidadeAppService;

        public ModalidadeController(IModalidadeAppService modalidadeAppService)
        {
            _modalidadeAppService = modalidadeAppService;
        }

        // GET: Modalidade
        public ActionResult Index()
        {
            return View(_modalidadeAppService.GetAll());
        }

        // GET: Modalidade/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_modalidadeAppService.GetById(id));
        }

        // GET: Modalidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modalidade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModalidadeViewModel modalidadeViewModel)
        {
            if (ModelState.IsValid)
            {
                _modalidadeAppService.Add(modalidadeViewModel);

                return RedirectToAction("Index");
            }
            return View(modalidadeViewModel);
        }

        // GET: Modalidade/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_modalidadeAppService.GetById(id));
        }

        // POST: Modalidade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModalidadeViewModel modalidadeViewModel)
        {
            if (ModelState.IsValid)
            {
                _modalidadeAppService.Update(modalidadeViewModel);

                return RedirectToAction("Index");
            }

            return View(modalidadeViewModel);
        }

        // GET: Modalidade/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_modalidadeAppService.GetById(id));
        }

        // POST: Modalidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _modalidadeAppService.Remove(_modalidadeAppService.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
