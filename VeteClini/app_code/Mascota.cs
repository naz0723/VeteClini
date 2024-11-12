using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace VeteClini.app_code
{
    public class Mascota
    {
        public static DatabaseHelper dh = new DatabaseHelper();

        /// <summary>
        /// Este método agrega una nueva mascota utilizando el procedimiento almacenado sp_CrearMascota.
        /// </summary>
        /// <param name="nombre">Nombre de la mascota.</param>
        /// <param name="especie">Especie de la mascota.</param>
        /// <param name="raza">Raza de la mascota.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la mascota.</param>
        /// <param name="color">Color de la mascota.</param>
        /// <param name="peso">Peso de la mascota.</param>
        /// <param name="duenoID">ID del dueño de la mascota.</param>
        /// <param name="adicionadoPor">Usuario que adiciona el registro.</param>
        /// <returns>Verdadero si el registro se insertó exitosamente, falso de lo contrario.</returns>
        public static bool AgregarMascota(string nombre, string especie, string raza, DateTime fechaNacimiento, string color, decimal peso, int duenoID, string adicionadoPor)
        {
            try
            {
                // Definir el nombre del procedimiento almacenado
                string query = "sp_CrearMascota";

                // Crear los parámetros requeridos por el procedimiento almacenado
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 50) { Value = nombre },
                new SqlParameter("@Especie", SqlDbType.NVarChar, 50) { Value = especie },
                new SqlParameter("@Raza", SqlDbType.NVarChar, 50) { Value = raza },
                new SqlParameter("@FechaNacimiento", SqlDbType.Date) { Value = fechaNacimiento },
                new SqlParameter("@Color", SqlDbType.NVarChar, 20) { Value = color },
                new SqlParameter("@Peso", SqlDbType.Decimal) { Value = peso },
                new SqlParameter("@DueñoID", SqlDbType.Int) { Value = duenoID },
                new SqlParameter("@AdicionadoPor", SqlDbType.NVarChar, 50) { Value = adicionadoPor }
                };

                // Ejecutar el procedimiento almacenado usando DatabaseHelper
                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);

                // Retornar verdadero si se afectó al menos una fila
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                dh.LogError(ex);
                return false;
            }
        }

        /// <summary>
        /// Este método actualiza la información de una mascota existente utilizando el procedimiento almacenado sp_ActualizarMascota.
        /// </summary>
        /// <param name="mascotaID">ID de la mascota a actualizar.</param>
        /// <param name="nombre">Nombre actualizado de la mascota.</param>
        /// <param name="especie">Especie actualizada de la mascota.</param>
        /// <param name="raza">Raza actualizada de la mascota.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento actualizada de la mascota.</param>
        /// <param name="color">Color actualizado de la mascota.</param>
        /// <param name="peso">Peso actualizado de la mascota.</param>
        /// <param name="modificadoPor">Usuario que modifica el registro.</param>
        /// <returns>Verdadero si el registro se actualizó exitosamente, falso de lo contrario.</returns>
        public static bool ActualizarMascota(int mascotaID, string nombre, string especie, string raza, DateTime fechaNacimiento, string color, decimal peso, string modificadoPor)
        {
            try
            {
                // Definir el nombre del procedimiento almacenado
                string query = "sp_ActualizarMascota";

                // Crear los parámetros requeridos por el procedimiento almacenado
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@MascotaID", SqlDbType.Int) { Value = mascotaID },
                new SqlParameter("@Nombre", SqlDbType.NVarChar, 50) { Value = nombre },
                new SqlParameter("@Especie", SqlDbType.NVarChar, 50) { Value = especie },
                new SqlParameter("@Raza", SqlDbType.NVarChar, 50) { Value = raza },
                new SqlParameter("@FechaNacimiento", SqlDbType.Date) { Value = fechaNacimiento },
                new SqlParameter("@Color", SqlDbType.NVarChar, 20) { Value = color },
                new SqlParameter("@Peso", SqlDbType.Decimal) { Value = peso },
                new SqlParameter("@ModificadoPor", SqlDbType.NVarChar, 50) { Value = modificadoPor }
                };

                // Ejecutar el procedimiento almacenado usando DatabaseHelper
                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);

                // Retornar verdadero si se afectó al menos una fila
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                dh.LogError(ex);
                return false;
            }
        }

        /// <summary>
        /// Este método elimina una mascota utilizando el procedimiento almacenado sp_EliminarMascota.
        /// </summary>
        /// <param name="mascotaID">ID de la mascota a eliminar.</param>
        /// <returns>Verdadero si el registro se eliminó exitosamente, falso de lo contrario.</returns>
        public static bool EliminarMascota(int mascotaID)
        {
            try
            {
                // Definir el nombre del procedimiento almacenado
                string query = "sp_EliminarMascota";

                // Crear los parámetros requeridos por el procedimiento almacenado
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@MascotaID", SqlDbType.Int) { Value = mascotaID }
                };

                // Ejecutar el procedimiento almacenado usando DatabaseHelper
                int rowsAffected = dh.ExecuteNonQuery(query, sqlParameters);

                // Retornar verdadero si se afectó al menos una fila
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra
                dh.LogError(ex);
                return false;
            }
        }
    }
}
    