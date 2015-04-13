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
            
            Mapper.CreateMap<Curso, CursoViewModel>()
                .ForMember(dest => dest.ModalidadeViewModel, opt => opt.MapFrom(src => src.Modalidade));

            Mapper.CreateMap<Fase, FaseViewModel>();

            Mapper.CreateMap<GradeCurricular, GradeCurricularViewModel>()
            .ForMember(dest => dest.Fase, opt => opt.MapFrom(src => src.Fase))
            .ForMember(dest => dest.UnidadeCurricular, opt => opt.MapFrom(src => src.UnidadeCurricular))
            .ForMember(dest => dest.Curso, opt => opt.MapFrom(src => src.Curso));
        }
    }
}