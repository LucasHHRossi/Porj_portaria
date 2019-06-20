using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  
      public class Tipo
    {
        #region Propriedades

        public int id { get; set; }
        public string Descricao { get; set; }

        #endregion

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}

