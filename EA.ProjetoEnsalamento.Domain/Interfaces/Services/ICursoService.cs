using EA.ProjetoEnsalamento.Domain.Entities;
using EA.ProjetoEnsalamento.Domain.ValueObjects;

namespace EA.ProjetoEnsalamento.Domain.Interfaces.Services
{
    public interface ICursoService :IServiceBase<Curso>
    {
        ValidationResult AdicionarCurso(Curso curso);
    }
}