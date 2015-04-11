using AutoMapper;
using EA.ProjetoEnsalamento.Domain.Entities;
using ProjetoEnsalamento.Application.ViewModels;

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
        }
    }
}