<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistorialClinico.aspx.cs" Inherits="VeteClini.Pages.HistorialClinico" %>

<!DOCTYPE html>

<html lang="es">
<head runat="server">
    <meta charset="utf-8" />
    <title>Gestión de Historial Clínico</title>
    <link type="text/css" rel="stylesheet" href="../Styles/EstilosFrm.css" />
</head>
<body>
    <form id="form1" runat="server">
        <h2>Gestión de Historial Clínico</h2>
        
        <div>
            <label for="txtHistorialID">ID del Historial:</label>
            <asp:TextBox ID="txtHistorialID" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtFechaVisita">Fecha de Visita:</label>
            <asp:TextBox ID="txtFechaVisita" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div>
            <label for="txtSintomas">Síntomas:</label>
            <asp:TextBox ID="txtSintomas" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtDiagnostico">Diagnóstico:</label>
            <asp:TextBox ID="txtDiagnostico" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtTratamiento">Tratamiento:</label>
            <asp:TextBox ID="txtTratamiento" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtVeterinario">Veterinario:</label>
            <asp:TextBox ID="txtVeterinario" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtMascotaID">ID de la Mascota:</label>
            <asp:TextBox ID="txtMascotaID" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtAdicionadoPor">Añadido por:</label>
            <asp:TextBox ID="txtAdicionadoPor" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnAgregarHistorial" runat="server" Text="Agregar Historial" OnClick="AgregarHistorial_Click" />
            <asp:Button ID="btnActualizarHistorial" runat="server" Text="Actualizar Historial" OnClick="ActualizarHistorial_Click" />
            <asp:Button ID="btnEliminarHistorial" runat="server" Text="Eliminar Historial" OnClick="EliminarHistorial_Click" />
        </div>
                    <!-- Botón para redirigir a otra página -->
              <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Login_Click" />
            </div></div>
    </form></body></html>