using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba___BETA.transacciones
{
    public partial class diario : Form
    {
        public diario()
        {
            InitializeComponent();
        }

        public string usuario;

        public string ValorSeleccionado { get; private set; }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void diario_Load(object sender, EventArgs e)
        {
            cta.Focus();
        }

        private void cta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               search();
            }
            if (e.KeyCode == Keys.F5)
            {
                consulta.Con_catalogo consultaForm = new consulta.Con_catalogo();

                if (consultaForm.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(consultaForm.ValorSeleccionado))
                    {
                        search2(consultaForm.ValorSeleccionado);
                    }
                }
            }

        }

        private void search()
        {
            if (string.IsNullOrWhiteSpace(cta.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de cuenta válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conexion conexion = new Conexion();
                string sql = "SELECT * FROM catalogoC WHERE Nro_Cta = @Nro_Cta";
                var parametros = new Dictionary<string, object>
        {
            { "@Nro_Cta", cta.Text }
        };

                DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);
                conexion.Cierre();

                if (resultado != null)
                {

                    if (resultado["Nivel_Cta"].ToString() == "1") {
                        MessageBox.Show("No se puede añadir una cuenta principal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    cta.Clear();
                    cta_nombre.Text = resultado["Descripcion_Cta"].ToString();
                    dataGridView1.Rows.Add(resultado["Nro_Cta"], resultado["Descripcion_Cta"]);
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2];
                    dataGridView1.BeginEdit(true);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna cuenta con el número especificado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search2(string valor)
        { 

            try
            {
                Conexion conexion = new Conexion();
                string sql = "SELECT * FROM catalogoC WHERE ID = @Nro_Cta";
                var parametros = new Dictionary<string, object>
        {
            { "@Nro_Cta", valor}
        };

                DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);
                conexion.Cierre();

                if (resultado != null)
                {
                    cta.Clear();
                    cta_nombre.Text = resultado["Descripcion_Cta"].ToString();
                    dataGridView1.Rows.Add(resultado["Nro_Cta"], resultado["Descripcion_Cta"]);
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2];
                    dataGridView1.BeginEdit(true);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna cuenta con el número especificado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            double totalCredito = 0;
            double totalDebito = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null && double.TryParse(row.Cells[3].Value.ToString(), out double debito))
                {
                    totalDebito += debito;
                }

                if (row.Cells[3].Value != null && double.TryParse(row.Cells[2].Value.ToString(), out double credito))
                {
                    totalCredito += credito;
                }
            }

            credito.Text = totalCredito.ToString("N2");
            debito.Text = totalDebito.ToString("N2");
            total_c.Text = (totalCredito - totalDebito).ToString("N2");

            cta.Focus();
        }


        private void limpiar_Click(object sender, EventArgs e)
        {
            cta.Clear();
            cta_nombre.Clear();
            dataGridView1.Rows.Clear();
            credito.Clear();
            debito.Clear();
            total_c.Clear();
            cta.Focus();
            comentario.Clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void credito_TextChanged(object sender, EventArgs e)
        {

        }

        private void debito_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void cta_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double totalCredito = double.Parse(credito.Text);
                double totalDebito = double.Parse(debito.Text);

                if (totalCredito != totalDebito)
                {
                    MessageBox.Show("Los totales de crédito y débito no cuadran. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Conexion conexion = new Conexion();
                string anioActual = DateTime.Now.Year.ToString();
                string sqlUltimoDoc = $"SELECT MAX(Nro_Doc) AS UltimoDoc FROM Transacciones WHERE Nro_Doc LIKE '{anioActual}%'";

                DataRow resultado = conexion.EjecutarConsulta(sqlUltimoDoc);
                string ultimoDoc = (resultado != null && resultado["UltimoDoc"] != DBNull.Value)
                    ? resultado["UltimoDoc"].ToString()
                    : $"{anioActual}000000";

                long numeroSerial = long.Parse(ultimoDoc.Substring(4)) + 1;
                string nroDocGenerado = $"{anioActual}{numeroSerial:D6}";

                string sqlTransaccion = @"
    INSERT INTO Transacciones (Valor_Debito_Total, Valor_Credito_Total, Nro_Doc,Comentario,hechopor)
    VALUES (@Valor_Debito_Total, @Valor_Credito_Total, @Nro_Doc,@comentario,@usuario);";

                var parametrosTransaccion = new Dictionary<string, object>
        {
            { "@Valor_Debito_Total", totalDebito },
            { "@Valor_Credito_Total", totalCredito },
            { "@Nro_Doc", nroDocGenerado },
            { "@comentario", comentario.Text },
                    { "@usuario", usuario }
        };

                conexion.EjecutarConsultaSimpleFila(sqlTransaccion, parametrosTransaccion);

                string sqlTransaccionID = "SELECT ID FROM Transacciones WHERE Nro_Doc = @Nro_Doc";
                var parametrosID = new Dictionary<string, object>
        {
            { "@Nro_Doc", nroDocGenerado }
        };

                DataRow transaccionIDRow = conexion.EjecutarConsultaSimpleFila(sqlTransaccionID, parametrosID);
                int transaccionIDFinal = transaccionIDRow != null && transaccionIDRow["ID"] != DBNull.Value ? (int)transaccionIDRow["ID"] : 0;

                string sqlDetalle = @"
    INSERT INTO Transacciones_Detalle 
    (Transaccion_ID, Secuencia_Doc, Cuenta_Contable, Valor_Debito, Valor_Credito,comentario)
    VALUES (@Transaccion_ID, @Secuencia_Doc, @Cuenta_Contable, @Valor_Debito, @Valor_Credito,@comentario);";

                int secuencia = 1;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string cuentaContable = row.Cells[0].Value?.ToString();
                    double valorDebito = row.Cells[2].Value != null ? double.Parse(row.Cells[2].Value.ToString()) : 0;
                    double valorCredito = row.Cells[3].Value != null ? double.Parse(row.Cells[3].Value.ToString()) : 0;
                    string comentario = row.Cells[4].Value?.ToString();

                    var parametrosDetalle = new Dictionary<string, object>
            {
                { "@Transaccion_ID", transaccionIDFinal },
                { "@Secuencia_Doc", secuencia++ },
                { "@Cuenta_Contable", cuentaContable },
                { "@Valor_Debito", valorDebito },
                { "@Valor_Credito", valorCredito },
                { "@comentario", comentario }
            };

                    conexion.EjecutarConsultaSimpleFila(sqlDetalle, parametrosDetalle);
                }

                conexion.Cierre();

                // Confirmación al usuario
                MessageBox.Show($"Transacción guardada exitosamente con el número de documento: {nroDocGenerado}.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el formulario
                limpiar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
            }

        }
    }
}
