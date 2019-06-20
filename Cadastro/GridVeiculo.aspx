<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridVeiculo.aspx.cs" Inherits="Cadastro.GridVeiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../Styles/Estilo.css" />
    <script src="../Bootstrap/jquery-2.0.3.min.js" type="text/javascript"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <div class="container">
        <div class="jumbotron">
            <form id="form2" runat="server">
                <div class="container">
                    <asp:Label ID="GridAutomovel" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#333333">Grid Automôvel:</asp:Label><br /><br />
                    <br />
                    <asp:GridView ID="GridVeiculos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField HeaderText="Cliente" />
                            <asp:BoundField HeaderText="CPF" />
                            <asp:BoundField HeaderText="Tipo" />
                            <asp:BoundField HeaderText="Placa" />
                            <asp:BoundField HeaderText="Modelo" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
