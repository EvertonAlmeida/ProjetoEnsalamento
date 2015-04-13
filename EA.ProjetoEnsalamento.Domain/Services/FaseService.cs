using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;
using EA.ProjetoEnsalamento.Domain.Interfaces.Services;

namespace EA.ProjetoEnsalamento.Domain.Services
{
    public class FaseService : ServiceBase<Fase>, IFaseService
    {
        private readonly IFaseReadOnlyRepository _faseReadOnlyRepository;
        private readonly IFaseRepository _faseRepository;

        public FaseService(IFaseReadOnlyRepository faseReadOnlyRepository, IFaseRepository faseRepository) 
            : base(faseRepository)
        {
            _faseReadOnlyRepository = faseReadOnlyRepository;
            _faseRepository = faseRepository;
        }

        public override IEnumerable<Fase> GetAll()
        {
            return _faseReadOnlyRepository.GetAll();
        }

        public override Fase GetById(Guid id)
        {
            return _faseReadOnlyRepository.GetById(id);
        }
    }
}