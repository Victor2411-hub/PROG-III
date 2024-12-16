using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Prueba___BETA.consulta
{
    public partial class Con_Transacciones : Form
    {
        public Con_Transacciones()
        {
            InitializeComponent();

            desde.Format = DateTimePickerFormat.Custom;
            desde.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            hasta.Format = DateTimePickerFormat.Custom;
            hasta.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            DateTime hoy = DateTime.Today;
            desde.Value = hoy;
            hasta.Value = hoy.AddDays(1).AddSeconds(-1);
        }

        private void Con_Transacciones_Load(object sender, EventArgs e)
        {
            documento.Focus();
        }

        private void documento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void buscar()
        {
            Conexion conexion = new Conexion();
            string sql;
            DataTable resultado;

            try
            {
                if (!string.IsNullOrWhiteSpace(documento.Text))
                {
                    sql = @"
                        SELECT
                            t.ID,
                            t.Nro_Doc AS Documento,
                            t.Valor_Debito_Total AS Debito,
                            t.Valor_Credito_Total AS Credito,
                            t.fecha_tran AS Fecha,
                            t.hechopor AS Usuario,
                            ti.descripcion AS Entrada
                        FROM 
                            Transacciones t
                        INNER JOIN 
                            tipo ti ON t.id_tipo = ti.id
                        WHERE 
                            t.fecha_tran BETWEEN @FechaDesde AND @FechaHasta
                            AND t.Nro_Doc LIKE @Documento
                        ORDER BY 
                            t.fecha_tran;
                    ";

                    var parametros = new Dictionary<string, object>
                    {
                        { "@FechaDesde", desde.Value },
                        { "@FechaHasta", hasta.Value },
                        { "@Documento", $"%{documento.Text.Trim()}%" }
                    };

                    resultado = conexion.TablaP(sql, parametros);
                }
                else
                {
                    sql = @"
                        SELECT
                            t.ID,
                            t.Nro_Doc AS Documento,
                            t.Valor_Debito_Total AS Debito,
                            t.Valor_Credito_Total AS Credito,
                            t.fecha_tran AS Fecha,
                            t.hechopor AS Usuario,
                            ti.descripcion AS Entrada
                        FROM 
                            Transacciones t
                        INNER JOIN 
                            tipo ti ON t.id_tipo = ti.id
                        WHERE 
                            t.fecha_tran BETWEEN @FechaDesde AND @FechaHasta
                        ORDER BY 
                            t.fecha_tran;
                    ";

                    var parametros = new Dictionary<string, object>
                    {
                        { "@FechaDesde", desde.Value },
                        { "@FechaHasta", hasta.Value }
                    };

                    resultado = conexion.TablaP(sql, parametros);
                }

                transacciones.DataSource = resultado;
                transacciones.Refresh();

                if (transacciones.Rows.Count > 0)
                {
                    transacciones.Rows[0].Selected = true;
                    CargarDetalle((int)transacciones.Rows[0].Cells["ID"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetalle(int transaccionID)
        {
            Conexion conexion = new Conexion();
            string sql = @"
                SELECT 
                    * 
                FROM 
                    Transacciones_Detalle 
                WHERE 
                    Transaccion_ID = @TransaccionID;
            ";

            var parametros = new Dictionary<string, object>
            {
                { "@TransaccionID", transaccionID }
            };

            string sqlnota = @"
                SELECT 
                    Comentario 
                FROM 
                    Transacciones 
                WHERE 
                    ID = @TransaccionID;
            ";

            var parametrosid = new Dictionary<string, object>
            {
                { "@TransaccionID", transaccionID }
            };

            try
            {
                DataTable detalleResultado = conexion.TablaP(sql, parametros);
                detalle.DataSource = detalleResultado;
                detalle.Refresh();
                DataRow dataRow = conexion.EjecutarConsultaSimpleFila(sqlnota, parametrosid);
                comentario.Text = dataRow["Comentario"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void transacciones_SelectionChanged(object sender, EventArgs e)
        {
            if (transacciones.SelectedRows.Count > 0)
            {
                int transaccionID = (int)transacciones.SelectedRows[0].Cells["ID"].Value;
                CargarDetalle(transaccionID);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
