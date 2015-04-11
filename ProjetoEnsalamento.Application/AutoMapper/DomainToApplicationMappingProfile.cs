using AutoMapper;
using EA.ProjetoEnsalamento.Application.Validation;
using EA.ProjetoEnsalamento.Domain.ValueObjects;

namespace EA.ProjetoEnsalamento.Application.AutoMapper
{
    public class DomainToApplicationMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToApplicationMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ValidationError, ValidationAppError>();
            Mapper.CreateMap<ValidationResult, ValidationAppResult>();
        }
    }
}
