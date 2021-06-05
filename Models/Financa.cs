using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace controleFinanceiro.Models
{
    public class Financa
    {
        public int FinancaId {get;set;}

        public float Valor {get;set;}
        public DateTime DataFinanca {get;set;}

        [ForeignKey("Modalidade")]
        public int ModalidadeId {get;set;}
        public Modalidade Modalidade {get;set;}

        [ForeignKey("Categoria")]
        public int CategoriaId {get;set;}
        public Categoria Categoria {get;set;}

        [ForeignKey("Tipo")]
        public int TipoId {get;set;}
        public Tipo Tipo {get;set;}
        [ForeignKey("Usuario")]
        public int UsuarioId {get;set;}
        public virtual Usuario Usuario {get;set;}
    }
}