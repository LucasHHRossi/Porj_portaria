<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="veiculo.aspx.cs" Inherits="Cadastro.veiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../Styles/Estilo.css" />
    <script src="../Bootstrap/jquery-2.0.3.min.js" type="text/javascript"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <div class="container">
         <a href="Default.aspx"><button id="btnVoltar" type="button" class="btn btn-secondary">Voltar</button></a>
        <div class="jumbotron">
            <div class="modal-header text-center" style="background-color: #5078a0; color: #fff;">
                <h4 class="font-weight-bold">Unlimited Parking</h4>
                <img src="../img/logo.png" id="sizeImgLogo" />
            </div>
        </div>
    </div>
    <div class="container">
        <div class="jumbotron">
            <form id="form2" runat="server">
                <div class="container">
                    <asp:Label ID="CadAutomovel" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#333333">Cadastrar Automôvel:</asp:Label><br /><br />
                    <div class="form-group">
                        <label for="InputCPFDono">CPF do Cliente:</label>
                        <asp:DropDownList ID="ddlCpfCliente" runat="server" class="form-control" placeholder="Digite o CPF do Cliente"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="InputModelo">Modelo do Carro:</label>
                        <asp:TextBox ID="txtModelo" runat="server" class="form-control" placeholder="Digite o Modelo do Carro"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="InputPlaca">Placa do Carro:</label>
                        <asp:TextBox ID="txtPlaca" runat="server" class="form-control" placeholder="Digite a Placa do Carro"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="InputTipo">Tipo do Carro:</label>
                        <asp:DropDownList ID="dllTipoCarro" runat="server" class="form-control" placeholder="Digite o Tipo do Carro"></asp:DropDownList>
                    </div>

                    <asp:Button ID="btnSlavar" runat="server" OnClick="btnSlavar_Click" Text="Salvar" class="btn btn-info" /><br />
                    <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    <br />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
