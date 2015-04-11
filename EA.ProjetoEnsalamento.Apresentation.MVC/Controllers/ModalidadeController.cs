using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EA.ProjetoEnsalamento.Application.Interfaces;
using ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Apresentation.MVC.Controllers
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

        // GET: Fornecedores/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_modalidadeAppService.GetById(id));
        }

        // GET: Fornecedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModalidadeViewModel modalidade)
        {
            if (ModelState.IsValid)
            {
                _modalidadeAppService.Add(modalidade);

                return RedirectToAction("Index");
            }

            return View(modalidade);
        }

        // GET: Fornecedores/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_modalidadeAppService.GetById(id));
        }

        // POST: Fornecedores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModalidadeViewModel modalidade)
        {
            if (ModelState.IsValid)
            {
                _modalidadeAppService.Update(modalidade);

                return RedirectToAction("Index");
            }

            return View(modalidade);
        }

        // GET: Fornecedores/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_modalidadeAppService.GetById(id));
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _modalidadeAppService.Remove(_modalidadeAppService.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
