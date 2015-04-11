using System;
using System.Collections.Generic;
using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository;
using EA.ProjetoEnsalamento.Domain.Interfaces.Repository.ReadOnly;
using EA.ProjetoEnsalamento.Domain.Interfaces.Services;

namespace EA.ProjetoEnsalamento.Domain.Services
{
    public class UnidadeCurricularService : ServiceBase<UnidadeCurricular>, IUnidadeCurricularService
    {
         private readonly IUnidadeCurricularReadOnlyRepository _unidadeCurricularReadOnlyRepository;
         private readonly IUnidadeCurricularRepository _unidadeCurricularRepository;

        public UnidadeCurricularService(IUnidadeCurricularReadOnlyRepository unidadeCurricularReadOnlyRepository, IUnidadeCurricularRepository unidadeCurricularRepository) 
            : base(unidadeCurricularRepository)
        {
            _unidadeCurricularReadOnlyRepository = unidadeCurricularReadOnlyRepository;
            _unidadeCurricularRepository = unidadeCurricularRepository;
        }

        public IEnumerable<UnidadeCurricular> GetAll()
        {
            return _unidadeCurricularReadOnlyRepository.GetAll();
        }

        public UnidadeCurricular GetById(Guid id)
        {
            return _unidadeCurricularReadOnlyRepository.GetById(id);
        } 
    }
}