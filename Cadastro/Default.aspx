<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cadastro.Default" %>

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
<body style="height: 467px">
    <div class="container">
        <div class="row">
            <div class="col-sm">
                <a href="veiculo.aspx"><button id="btnAvancar" type="button" class="btn btn-secondary">Avançar</button></a>
            </div>
        </div>
        <div class="jumbotron">
            <div class="modal-header text-center" style="background-color: #5078a0; color: #fff;">
                <h4 class="font-weight-bold">Unlimited Parking</h4>
                <img src="../img/logo.png" id="sizeImgLogo" />
            </div>
        </div>
    </div>
    <div class="container">
        <div class="jumbotron">
            <form id="form1" runat="server">
                <div class="container">
                    <asp:Label ID="CadPessoa" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#333333">Cadastrar Pessoa:</asp:Label><br />
                    <br />
                    <div class="row">
                        <div class="col-sm">
                            <div class="form-group">
                                <label for="InputNome">Nome:</label>
                                <asp:TextBox ID="txtnome" runat="server" class="form-control" placeholder="Digite o nome"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="InputCPF">CPF:</label>
                                <asp:TextBox ID="txtcpf" runat="server" class="form-control" placeholder="Digite o CPF"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="InputTipo">Tipo:</label>
                                <asp:TextBox ID="txtTipo" runat="server" class="form-control" placeholder="Digite o Tipo"></asp:TextBox>
                            </div>

                        </div>
                        <div class="col-sm">

                            <div class="form-group">
                                <label for="InputSobrenome">Sobrenome:</label>
                                <asp:TextBox ID="txtSobrenome" runat="server" class="form-control" placeholder="Digite o Sobrenome"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="InputRG">RG:</label>
                                <asp:TextBox ID="txtrg" runat="server" class="form-control" placeholder="Digite o RG"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="InputTelefone">Telefone:</label>
                                <asp:TextBox ID="txttelefone" runat="server" class="form-control" placeholder="Digite o Telefone"></asp:TextBox>
                            </div>

                            <asp:Button ID="btnSlavar" runat="server" OnClick="btnSlavar_Click" Text="Salvar" class="btn btn-info" />
                        </div>
                    </div>
                </div>
                <div>
                    <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    <br />
                    <asp:GridView ID="GVPortaria" runat="server" Width="451px">
                    </asp:GridView>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
