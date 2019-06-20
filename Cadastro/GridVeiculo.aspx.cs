using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cadastro
{
    public partial class GridVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReloadGrid()
        {
            GridVeiculos.DataSource = new VeiculoDB().AllVeiculosCliente();
            GridVeiculos.DataBind();
        }
    }
}