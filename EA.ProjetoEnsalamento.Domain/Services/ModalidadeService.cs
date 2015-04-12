using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;
using EA.ProjetoEnsalamento.Domain.Interfaces.Services;

namespace EA.ProjetoEnsalamento.Domain.Services
{
    public class ModalidadeService : ServiceBase<Modalidade>, IModalidadeService
    {
        private readonly IModalidadeReadOnlyRepository _modalidadeReadOnlyRepository;
        private readonly IModalidadeRepository _modalidadeRepository;

        public ModalidadeService(IModalidadeReadOnlyRepository modalidadeReadOnlyRepository, IModalidadeRepository modalidadeRepository)
            : base(modalidadeRepository)
        {
            _modalidadeReadOnlyRepository = modalidadeReadOnlyRepository;
            _modalidadeRepository = modalidadeRepository;
        }

        public override IEnumerable<Modalidade> GetAll()
        {
            return _modalidadeReadOnlyRepository.GetAll();
        }

        public override Modalidade GetById(Guid id)
        {
            return _modalidadeReadOnlyRepository.GetById(id);
        }
    }
}