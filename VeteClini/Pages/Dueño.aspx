<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dueño.aspx.cs" Inherits="VeteClini.Pages.Dueño" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gestión de Dueños</title>
    <link type="text/css" rel="stylesheet" href="../Styles/EstilosFrm.css" />
</head>
<body>
    <form id="formDueño" runat="server">
        <div class="container">
            <h2>Gestión de Dueños</h2>

            <!-- Formulario para agregar un dueño -->
            <div class="form-section">
                <h3>Agregar Dueño</h3>
                <label for="txtNombre">Nombre:</label>
                <input type="text" id="txtNombre" runat="server" required />
                
                <label for="txtApellido">Apellido:</label>
                <input type="text" id="txtApellido" runat="server" required />

                <label for="txtDireccion">Dirección:</label>
                <input type="text" id="txtDireccion" runat="server" required />

                <label for="txtTelefono">Teléfono:</label>
                <input type="text" id="txtTelefono" runat="server" required />

                <label for="txtEmail">Correo Electrónico:</label>
                <input type="email" id="txtEmail" runat="server" required />

                <label for="txtIdentificacion">Identificación:</label>
                <input type="text" id="txtIdentificacion" runat="server" required />

                <label for="txtAdicionadoPor">Añadido por:</label>
                <input type="text" id="txtAdicionadoPor" runat="server" required />

                <asp:Button ID="btnAgregar" runat="server" Text="Agregar Dueño" OnClick="AgregarDueño_Click" />
            </div>
            <!-- Formulario para eliminar un dueño -->
            <div class="form-section">
                <h3>Eliminar Dueño</h3>
                <label for="txtDueñoIDEliminar">ID del Dueño:</label>
                <input type="text" id="txtDueñoIDEliminar" runat="server"  />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Dueño" OnClick="EliminarDueño_Click" />
            </div>
            <!-- Formulario para actualizar un dueño -->
            <div class="form-section">
                <h3>Actualizar Dueño</h3>
                <label for="txtDueñoIDActualizar">ID del Dueño:</label>
                <input type="text" id="txtDueñoIDActualizar" runat="server"  />
                
                <label for="txtNombreActualizar">Nuevo Nombre:</label>
                <input type="text" id="txtNombreActualizar" runat="server"  />

                <label for="txtApellidoActualizar">Nuevo Apellido:</label>
                <input type="text" id="txtApellidoActualizar" runat="server"  />

                <label for="txtDireccionActualizar">Nueva Dirección:</label>
                <input type="text" id="txtDireccionActualizar" runat="server"  />

                <label for="txtTelefonoActualizar">Nuevo Teléfono:</label>
                <input type="text" id="txtTelefonoActualizar" runat="server"  />

                <label for="txtEmailActualizar">Nuevo Correo Electrónico:</label>
                <input type="email" id="txtEmailActualizar" runat="server"  />

                <label for="txtIdentificacionActualizar">Nueva Identificación:</label>
                <input type="text" id="txtIdentificacionActualizar" runat="server"  />

                <label for="txtModificadoPor">Modificado por:</label>
                <input type="text" id="txtModificadoPor" runat="server"  />

                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Dueño" OnClick="ActualizarDueño_Click" />
            </div>
            <!-- Botón para redirigir a otra página -->
            <div class="form-section">
                <asp:Button ID="btnMascota" runat="server" Text="Gestion Mascota" OnClick="Mascotas_Click" />
            </div> </div>
    </form></body>
</html>