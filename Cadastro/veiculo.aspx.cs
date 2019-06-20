using Data;
using Model;
using Proj_portaria;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cadastro
{
    public partial class veiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarListaDrop();
            }
        }

        private void carregarListaDrop()
        {
            dllTipoCarro.DataSource = new TipoDB().All();
            dllTipoCarro.DataValueField = "id";
            dllTipoCarro.DataTextField = "Descricao";
            dllTipoCarro.DataBind();
            dllTipoCarro.Items.Insert(0, new ListItem("Selecione...", "0"));

            ddlCpfCliente.DataSource = new PessoaDB().All();
            ddlCpfCliente.DataValueField = "id";
            ddlCpfCliente.DataTextField = "Cpf";
            ddlCpfCliente.DataBind();
            ddlCpfCliente.Items.Insert(0, new ListItem("Selecione CPF...", "0"));
        }
        
        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnSlavar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo()
            {
                Tipo = dllTipoCarro.Text,
                Modelo = txtModelo.Text,
                Placa = txtPlaca.Text,
                Fk_pessoa = Convert.ToInt32(ddlCpfCliente.Text)
            };

            if (new VeiculoDB().Insert(veiculo))
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

    }
}
