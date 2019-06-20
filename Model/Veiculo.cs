using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Veiculo
    {
        #region Propriedades

        public int IdVeiculo { get; set; }
        public string Tipo { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public Int32 Fk_pessoa { get; set; }

        #endregion
        public override string ToString()
        {
            return this.Tipo;
        }
    }
}
