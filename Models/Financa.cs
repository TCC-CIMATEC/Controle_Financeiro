using System;

namespace controleFinanceiro.Models
{
    public class Financa
    {
        public int Id {get;set;}

        public float Valor {get;set;}
        public DateTime DataFinanca {get;set;}
        public Modalidade Modalidade {get;set;}
        public Categoria Categoria {get;set;}
        public Tipo Tipo {get;set;}
        
        public Usuario Usuario {get;set;}
    }
}