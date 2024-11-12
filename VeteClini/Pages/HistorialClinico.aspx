<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistorialClinico.aspx.cs" Inherits="VeteClini.Pages.HistorialClinico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Historial Clínico</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        label, input, textarea, button {
            margin-bottom: 10px;
            display: block;
        }
        .form-group {
            margin-bottom: 15px;
        }
    </style>
</head>
<body>
    <h1>Gestión de Historial Clínico</h1>

    <h2>Agregar Historial Clínico</h2>
    <form id="formAgregar" runat="server">
        <div class="form-group">
            <label for="txtFechaVisita">Fecha de Visita:</label>
            <input type="datetime-local" id="txtFechaVisita" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtSintomas">Síntomas:</label>
            <textarea id="txtSintomas" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="txtDiagnostico">Diagnóstico:</label>
            <textarea id="txtDiagnostico" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="txtTratamiento">Tratamiento:</label>
            <textarea id="txtTratamiento" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="txtVeterinario">Veterinario:</label>
            <input type="text" id="txtVeterinario" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtMascotaID">ID de Mascota:</label>
            <input type="text" id="txtMascotaID" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtAdicionadoPor">Adicionado Por:</label>
            <input type="text" id="txtAdicionadoPor" runat="server" />
        </div>
        <button type="button" onclick="agregarHistorialClinico()">Agregar Historial</button>
    </form>

    <h2>Eliminar Historial Clínico</h2>
    <form id="formEliminar" runat="server">
        <div class="form-group">
            <label for="txtHistorialIDEliminar">ID del Historial:</label>
            <input type="text" id="txtHistorialIDEliminar" runat="server" />
        </div>
        <button type="button" onclick="eliminarHistorialClinico()">Eliminar Historial</button>
    </form>

    <h2>Actualizar Historial Clínico</h2>
    <form id="formActualizar" runat="server">
        <div class="form-group">
            <label for="txtHistorialIDActualizar">ID del Historial:</label>
            <input type="text" id="txtHistorialIDActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtFechaVisitaActualizar">Fecha de Visita:</label>
            <input type="datetime-local" id="txtFechaVisitaActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtSintomasActualizar">Síntomas:</label>
            <textarea id="txtSintomasActualizar" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="txtDiagnosticoActualizar">Diagnóstico:</label>
            <textarea id="txtDiagnosticoActualizar" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="txtTratamientoActualizar">Tratamiento:</label>
            <textarea id="txtTratamientoActualizar" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="txtVeterinarioActualizar">Veterinario:</label>
            <input type="text" id="txtVeterinarioActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtMascotaIDActualizar">ID de Mascota:</label>
            <input type="text" id="txtMascotaIDActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtModificadoPor">Modificado Por:</label>
            <input type="text" id="txtModificadoPor" runat="server" />
        </div>
        <button type="button" onclick="actualizarHistorialClinico()">Actualizar Historial</button>
    </form>

   
</body>
</html>
