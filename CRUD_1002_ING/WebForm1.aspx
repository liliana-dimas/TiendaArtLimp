<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CRUD_1002_ING.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Inventario</title>
    <!-- Agregar Bootstrap desde el CDN -->
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <h2 class="text-center mb-4">Gestión de Inventario</h2>

                    <div class="form-group">
                        <label for="TextBox1">ID</label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Ingrese el ID"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="TextBox2">Nombre del Artículo</label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Ingrese el nombre del artículo"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="TextBox3">Precio</label>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Ingrese el precio"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="TextBox4">Existencias</label>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Ingrese la cantidad de existencias"></asp:TextBox>
                    </div>

                    <div class="text-center">
                        <asp:Label ID="LabelMensaje" runat="server" ForeColor="Red" CssClass="mb-3"></asp:Label>
                    </div>

                    <div class="text-center">
                        <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-primary mr-2" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Mostrar" CssClass="btn btn-secondary mr-2" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="Eliminar" CssClass="btn btn-danger mr-2" OnClick="Button3_Click" />
                        <asp:Button ID="Button4" runat="server" Text="Modificar" CssClass="btn btn-warning mr-2" OnClick="Button4_Click" />
                    </div>
                </div>
            </div>
        </div>

        <!-- Agregar scripts de Bootstrap -->
        <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.2/dist/umd/popper.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
