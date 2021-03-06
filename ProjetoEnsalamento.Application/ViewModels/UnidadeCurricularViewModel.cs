﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EA.ProjetoEnsalamento.Application.ViewModels
{
    public class UnidadeCurricularViewModel
    {
        public UnidadeCurricularViewModel()
        {
            UnidadeCurricularId = Guid.NewGuid();
        }

        [Key]
        public Guid UnidadeCurricularId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; } 
    }
}