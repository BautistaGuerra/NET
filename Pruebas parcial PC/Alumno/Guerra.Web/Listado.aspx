<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Guerra.Web.Listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="gridViewPanel" runat="server">
            <asp:GridView ID="dgvAlumnos" runat="server" AutoGenerateColumns = "False" Height="130px" Width="527px">
                <Columns>

                    <asp:BoundField DataField="ApellidoNombre" HeaderText="Apellido Nombre" />
                    <asp:BoundField DataField="Dni" HeaderText="Dni" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha nacimiento" />
                    <asp:BoundField DataField="Nota Promedio" HeaderText="Nota promedio" />

                </Columns>
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
