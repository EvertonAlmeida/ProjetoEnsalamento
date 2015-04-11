using System.Collections.Generic;

namespace EA.ProjetoEnsalamento.Application.Validation
{
    public class ValidationAppResult
    {
        private readonly List<ValidationAppError> _errors = new List<ValidationAppError>();

        public string Mensagem { get; set; }
        public bool IsValid
        {
            get { return _errors.Count == 0; }
            set
            {
                var b = value;
            }
        }

        public ICollection<ValidationAppError> Erros { get { return this._errors; } }
    }
}
