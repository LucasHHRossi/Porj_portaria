using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Model;
using System.Data.SqlClient;

namespace Proj_portaria
{
   public class TipoDB
    {

        private Conexao conexao;

        public List<Tipo> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT id, Descricao FROM tb_tipoCarro";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Tipo> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listTipo = new List<Tipo>();

            while (retorno.Read())
            {
                var item = new Tipo()
                {
                    id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["Descricao"].ToString()
                };

                listTipo.Add(item);

            }

            return listTipo;
        }
    }

}
