using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public Veiculo Veiculo { get; set; }
       // public Tipo Tipo { get; set; }

        #endregion
    }
}