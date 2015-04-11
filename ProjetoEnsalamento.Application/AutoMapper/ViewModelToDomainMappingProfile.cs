using AutoMapper;
using EA.ProjetoEnsalamento.Domain.Entities;
using ProjetoEnsalamento.Application.ViewModels;

namespace EA.ProjetoEnsalamento.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ModalidadeViewModel, Modalidade>();
        }
    }
}