<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mascota.aspx.cs" Inherits="VeteClini.Pages.Mascota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Gestión de Mascotas</title>
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
    <h1>Gestión de Mascotas</h1>

    <h2>Agregar Mascota</h2>
    <form id="formAgregar" runat="server">
        <div class="form-group">
            <label for="txtNombre">Nombre:</label>
            <input type="text" id="txtNombre" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtEspecie">Especie:</label>
            <input type="text" id="txtEspecie" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtRaza">Raza:</label>
            <input type="text" id="txtRaza" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtFechaNacimiento">Fecha de Nacimiento:</label>
            <input type="date" id="txtFechaNacimiento" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtColor">Color:</label>
            <input type="text" id="txtColor" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtPeso">Peso:</label>
            <input type="number" id="txtPeso" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtDuenoID">ID del Dueño:</label>
            <input type="text" id="txtDuenoID" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtAdicionadoPor">Adicionado Por:</label>
            <input type="text" id="txtAdicionadoPor" runat="server" />
        </div>
        <button type="button" onclick="agregarMascota()">Agregar Mascota</button>
    </form>

    <h2>Eliminar Mascota</h2>
    <form id="formEliminar" runat="server">
        <div class="form-group">
            <label for="txtMascotaIDEliminar">ID de la Mascota:</label>
            <input type="text" id="txtMascotaIDEliminar" runat="server" />
        </div>
        <button type="button" onclick="eliminarMascota()">Eliminar Mascota</button>
    </form>

    <h2>Actualizar Mascota</h2>
    <form id="formActualizar" runat="server">
        <div class="form-group">
            <label for="txtMascotaIDActualizar">ID de la Mascota:</label>
            <input type="text" id="txtMascotaIDActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtNombreActualizar">Nombre:</label>
            <input type="text" id="txtNombreActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtEspecieActualizar">Especie:</label>
            <input type="text" id="txtEspecieActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtRazaActualizar">Raza:</label>
            <input type="text" id="txtRazaActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtFechaNacimientoActualizar">Fecha de Nacimiento:</label>
            <input type="date" id="txtFechaNacimientoActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtColorActualizar">Color:</label>
            <input type="text" id="txtColorActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtPesoActualizar">Peso:</label>
            <input type="number" id="txtPesoActualizar" runat="server" />
        </div>
        <div class="form-group">
            <label for="txtModificadoPor">Modificado Por:</label>
            <input type="text" id="txtModificadoPor" runat="server" />
        </div>
        <button type="button" onclick="actualizarMascota()">Actualizar Mascota</button>
    </form>

  
</body>
</html>
