namespace EA.ProjetoEnsalamento.Domain.Interfaces.Validation
{
    public interface IRegra<in TEntity>
    {
        string MensagemErro { get; }
        bool Validar(TEntity entity);
    }
}