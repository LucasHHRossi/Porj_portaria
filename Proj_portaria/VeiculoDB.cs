using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using System.Data.SqlClient;

namespace Data
{
   public class VeiculoDB
    {
        private Conexao conexao;

        #region Métodos
        public bool Insert(Veiculo veiculo)
        {
            try
            {
                //Query de Inclusão de dados
                string sql = string.Format
                    ("insert into tb_veiculo (tipo,placa,modelo,fk_pessoa) values ('{0}','{1}','{2}','{3}')",
                    veiculo.Tipo, veiculo.Placa, veiculo.Modelo,veiculo.Fk_pessoa);

                //Abrir conexão para inclusão das informações
                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sql);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Veiculo> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT p.tipo, p.placa, p.modelo,p.fk_pessoa FROM tb_veiculo p ";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        public List<Veiculo> AllVeiculosCliente()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT p.tipo, p.placa, p.modelo,p.fk_pessoa FROM tb_veiculo p ";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Veiculo> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listVeiculo = new List<Veiculo>();

            while (retorno.Read())
            {
                var item = new Veiculo()
                {
                    IdVeiculo = Convert.ToInt32(retorno["idVeiculo"]),
                    Tipo = retorno["tipo"].ToString(),
                    Placa = retorno["placa"].ToString(),
                    Modelo = retorno["modelo"].ToString(),
                    Fk_pessoa = Convert.ToInt32(retorno["fk_pessoa"])
                };

                listVeiculo.Add(item);
            }
            return listVeiculo;
        }

        #endregion
    }
}