using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace controleFinanceiro.Models
{
    public class Usuario
    {
        public int UsuarioId {get;set;}

        public string Nome {get;set;}

        [NotMapped]
        public IList<Financa> Financas {get;set;}
    }
}