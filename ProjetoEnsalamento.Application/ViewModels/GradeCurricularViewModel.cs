using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EA.ProjetoEnsalamento.Domain.Entities;

namespace EA.ProjetoEnsalamento.Application.ViewModels
{
    public class GradeCurricularViewModel
    {
        public GradeCurricularViewModel()
        {
            GradeCurricularId = Guid.NewGuid();
        }

        [Key]
        public Guid GradeCurricularId { get; set; }
        [Required]
        [DisplayName("Fase")]
        public Guid FaseId { get; set; }
        public virtual Fase Fase { get; set; }
        [Required]
        [DisplayName("Unidade Curricular")]
        public Guid UnidadeCurricularId { get; set; }
        public virtual UnidadeCurricular UnidadeCurricular { get; set; }

        [Required]
        [DisplayName("Curso")]
        public Guid CursoId { get; set; }
        public virtual Curso Curso { get; set; }

        [Required]
        [Range(1, 300, ErrorMessage = "Informe um número entre {0} e {1}")]
        public virtual int CargaHoraria { get; set; } 
    }
}