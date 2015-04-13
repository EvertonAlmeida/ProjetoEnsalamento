using System;
using System.ComponentModel.DataAnnotations;

namespace EA.ProjetoEnsalamento.Application.ViewModels
{
    public class FaseViewModel
    {
        public FaseViewModel()
        {
            FaseId = Guid.NewGuid();
        }

        [Key]
        public Guid FaseId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }  
    }
}