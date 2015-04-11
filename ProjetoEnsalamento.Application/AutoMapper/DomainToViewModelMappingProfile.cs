using AutoMapper;
using EA.ProjetoEnsalamento.Application.ViewModels;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Modalidade, ModalidadeViewModel>();
            Mapper.CreateMap<UnidadeCurricular, UnidadeCurricularViewModel>();
        }
    }
}