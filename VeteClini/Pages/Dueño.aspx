<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dueño.aspx.cs" Inherits="VeteClini.Pages.Dueño" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Gestión de Dueños</title>
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
    <h1>Gestión de Dueños</h1>

    <h2>Agregar Dueño</h2>
    <form id="formAgregar" runat="server">
        <div class="form-group">
            <label for="txtNombre">Nombre:</label>
            <input type="text" id="txtNombre" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtApellido">Apellido:</label>
            <input type="text" id="txtApellido" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtDireccion">Dirección:</label>
            <textarea id="txtDireccion" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="txtTelefono">Teléfono:</label>
            <input type="text" id="txtTelefono" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtEmail">Email:</label>
            <input type="text" id="txtEmail" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtIdentificacion">Identificación:</label>
            <input type="text" id="txtIdentificacion" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtAdicionadoPor">Adicionado Por:</label>
            <input type="text" id="txtAdicionadoPor" runat="server" />
        </div>
        <button type="button" onclick="agregarDueño()">Agregar Dueño</button>
    </form>

    <h2>Eliminar Dueño</h2>
    <form id="formEliminar" runat="server">
        <div class="form-group">
            <label for="txtDueñoIDEliminar">ID del Dueño:</label>
            <input type="text" id="txtDueñoIDEliminar" runat="server" />
        </div>
        <button type="button" onclick="eliminarDueño()">Eliminar Dueño</button>
    </form>

    <h2>Actualizar Dueño</h2>
    <form id="formActualizar" runat="server">
        <div class="form-group">
            <label for="txtDueñoIDActualizar">ID del Dueño:</label>
            <input type="text" id="txtDueñoIDActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtNombreActualizar">Nombre:</label>
            <input type="text" id="txtNombreActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtApellidoActualizar">Apellido:</label>
            <input type="text" id="txtApellidoActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtDireccionActualizar">Dirección:</label>
            <textarea id="txtDireccionActualizar" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="txtTelefonoActualizar">Teléfono:</label>
            <input type="text" id="txtTelefonoActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtEmailActualizar">Email:</label>
            <input type="text" id="txtEmailActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtIdentificacionActualizar">Identificación:</label>
            <input type="text" id="txtIdentificacionActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtModificadoPor">Modificado Por:</label>
            <input type="text" id="txtModificadoPor" runat="server" />
        </div>
        <button type="button" onclick="actualizarDueño()">Actualizar Dueño</button>
    </form>

   
</body>
</html>

