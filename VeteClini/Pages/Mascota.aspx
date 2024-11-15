<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mascota.aspx.cs" Inherits="VeteClini.Pages.Mascota" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Administrar Mascotas</title>
    <link type="text/css" rel="stylesheet" href="../Styles/EstilosFrm.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Administrar Mascotas</h2>

            <!-- Campos para agregar o actualizar los datos de la mascota -->
            <label for="txtNombre">Nombre:</label>
            <input type="text" id="txtNombre" runat="server"  />

            <label for="txtEspecie">Especie:</label>
            <input type="text" id="txtEspecie" runat="server"  />

            <label for="txtRaza">Raza:</label>
            <input type="text" id="txtRaza" runat="server"  />

            <label for="txtFechaNacimiento">Fecha de Nacimiento:</label>
            <input type="date" id="txtFechaNacimiento" runat="server"  />

            <label for="txtColor">Color:</label>
            <input type="text" id="txtColor" runat="server"  />

            <label for="txtPeso">Peso:</label>
            <input type="number" step="0.01" id="txtPeso" runat="server"  />

            <label for="txtDueñoID">ID del Dueño:</label>
            <input type="number" id="txtDueñoID" runat="server"  />

            <label for="txtAdicionadoPor">Adicionado Por:</label>
            <input type="text" id="txtAdicionadoPor" runat="server"  />

            <!-- Botón para agregar una nueva mascota -->
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Mascota" OnClick="AgregarMascota_Click" />

            <!-- Botón para actualizar una mascota existente -->
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Mascota" OnClick="ActualizarMascota_Click" />

            <!-- Campo para ingresar el ID de la mascota a eliminar -->
            <label for="txtMascotaIDEliminar">ID de la Mascota a Eliminar:</label>
            <input type="number" id="txtMascotaIDEliminar" runat="server"  />

            <!-- Botón para eliminar una mascota -->
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Mascota" OnClick="EliminarMascota_Click" />
            <br />
                
            <!-- Botón para redirigir a otra página -->
            <asp:Button ID="btnHistorialClinico" runat="server" Text="Historial Clinico" OnClick="HistorialClinico_Click" />
        </div>
    </form>
</body>
</html>