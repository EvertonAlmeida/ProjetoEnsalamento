using AutoMapper;
using EA.ProjetoEnsalamento.Application.ViewModels;
using EA.ProjetoEnsalamento.Domain.Entities;

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
            Mapper.CreateMap<UnidadeCurricularViewModel, UnidadeCurricular>();
            Mapper.CreateMap<CursoViewModel, Curso>();
        }
    }
}