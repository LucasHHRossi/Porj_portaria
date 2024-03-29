﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Data


    
{
    public class PessoaDB
    {
        private Conexao conexao;

        #region Métodos
        public bool Insert(Pessoa pessoa)
        {
            try
            {
                //Query de Inclusão de dados
                string sql = string.Format
                    ("insert into tb_Pessoa (nome,sobreNome,tipo,Rg,cpf,telefone) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    pessoa.Nome, pessoa.SobreNome, pessoa.Tipo, pessoa.Rg, pessoa.Cpf, pessoa.Telefone);

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

        public List<Pessoa> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT p.id, p.Nome,p.sobreNome,p.Tipo,p.Rg,p.cpf,p.Telefone FROM tb_Pessoa p";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Pessoa> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listPessoa = new List<Pessoa>();

            while (retorno.Read())
            {
                var item = new Pessoa()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Nome = retorno["nome"].ToString(),
                    SobreNome = retorno["sobreNome"].ToString(),
                    Tipo = retorno["Tipo"].ToString(),
                    Rg = retorno["Rg"].ToString(),
                    Cpf = retorno["cpf"].ToString(),
                    Telefone = retorno["telefone"].ToString()

                    //Cidade = new Cidade() { Descricao = retorno["Descricao"].ToString() }
                };

                listPessoa.Add(item);
            }
            return listPessoa;
        }

        #endregion
    }
}

