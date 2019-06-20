using System;
using Model;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data;
using System.Drawing;

namespace Cadastro
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSlavar_Click(object sender, EventArgs e)
        {

           // Veiculo veiculo = new Veiculo()
            Pessoa pessoa = new Pessoa()
            {
                Nome = txtnome.Text,
                SobreNome = txtSobrenome.Text,
                Cpf = txtcpf.Text,
                Rg = txtrg.Text,               
                Telefone = txttelefone.Text,
                Tipo = txtTipo.Text
            };

            if (new PessoaDB().Insert(pessoa))
            {
                lblmsg.Text = "Registro Inserido!";
                lblmsg.ForeColor = Color.Green;
                ReloadGrid();
            }
            else
            {
                lblmsg.Text = "Erro ao inserir registro";
                lblmsg.ForeColor = Color.Pink;
                ReloadGrid();
            }

        }

        private void ReloadGrid()
        {
            //GVPortaria.DataSource = new PessoaDB().All();
            //GVPortaria.DataBind();
        }

        

        //private void LoadCboVeiculo()
        //{

        //    cboVeiculo.DataSource = new VeiculoDB().All();
        //    cboVeiculo.DataTextField = "Descricao";
        //    cboVeiculo.DataValueField = "Id";
        //    cboVeiculo.DataBind();

        //}

       
    }
}