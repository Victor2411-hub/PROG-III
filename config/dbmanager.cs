using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Conexion
{
    private SqlConnection conexion;

    public Conexion()
    {
        string connectionString = @"Data Source=VICTOR\SQLEXPRESS;Initial Catalog=modelo;Integrated Security=True;";

        conexion = new SqlConnection(connectionString);
        try
        {
            conexion.Open();
            Console.WriteLine("Conexión exitosa a la base de datos.");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Ups, parece que falló en la conexión con la base de datos: " + ex.Message);
            Environment.Exit(1);
        }
    }

    public DataRow EjecutarConsulta(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, conexion);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
    }

    public void Cierre()
    {
        if (conexion != null && conexion.State == ConnectionState.Open)
        {
            conexion.Close();
            Console.WriteLine("Conexión cerrada.");
        }
    }

    public DataRow EjecutarConsultaSimpleFila(string sql, Dictionary<string, object> parametros)
    {
        using (SqlCommand cmd = new SqlCommand(sql, conexion))
        {
            foreach (var parametro in parametros)
            {
                cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }


    public int EjecutarConsultaRetornarID(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, conexion);
        cmd.ExecuteNonQuery();
        cmd.CommandText = "SELECT SCOPE_IDENTITY()";
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public string LimpiarCadena(string str)
    {
        str = str.Trim();
        return System.Security.SecurityElement.Escape(str);
    }

    public DataTable TablaP(string sql, Dictionary<string, object> parametros)
    {
        try
        {
            using (SqlCommand cmd = new SqlCommand(sql, conexion))
            {
                foreach (var parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar la consulta parametrizada: " + ex.Message);
            return null;
        }
    }

    public void EjecutarP(string sql, Dictionary<string, object> parametros)
    {
        try
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }

            using (SqlCommand cmd = new SqlCommand(sql, conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros correctamente
                foreach (var parametro in parametros)
                {
                    cmd.Parameters.Add(new SqlParameter(parametro.Key, parametro.Value ?? DBNull.Value));
                }

                // Ejecutar el comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Procedimiento ejecutado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show($"Error de SQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }





    public DataTable Tabla(string sql)
    {
        try
        {
            SqlCommand cmd = new SqlCommand(sql, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            return null;
        }
    }

    
}
