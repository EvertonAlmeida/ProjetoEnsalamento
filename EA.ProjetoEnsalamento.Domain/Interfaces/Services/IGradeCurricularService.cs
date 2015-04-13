using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.ValueObjects;

namespace EA.ProjetoEnsalamento.Domain.Interfaces.Services
{
    public interface IGradeCurricularService : IServiceBase<GradeCurricular>
    {
        ValidationResult AdicionarGradeCurricular(GradeCurricular gradeCurricular);
    }
}