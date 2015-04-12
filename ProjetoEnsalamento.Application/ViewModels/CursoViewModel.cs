using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EA.ProjetoEnsalamento.Application.ViewModels
{
    public class CursoViewModel
    {
        public CursoViewModel()
        {
            CursoId = Guid.NewGuid();
        }

        [Key]
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Número")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Número Fase")]
        public string NumeroFase { get; set; }

        [Required]
        [DisplayName("Modalidade")]
        public Guid ModalidadeId { get; set; }

        public virtual ModalidadeViewModel ModalidadeViewModel { get; set; }

    }
}