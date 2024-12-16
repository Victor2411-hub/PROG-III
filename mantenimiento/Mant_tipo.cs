using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba___BETA.mantenimiento
{
    public partial class Mant_tipo : Form
    {
        public Mant_tipo()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            string sql = "SELECT id AS ID, descripcion AS DESCRIPCIÓN FROM tipo";
            dataGridView1.DataSource = conexion.Tabla(sql);
            dataGridView1.Refresh();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            cod.Clear();
            desc.Clear();
        }

        private void cod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(cod.Text))
                {
                    search();
                }
                else
                {
                    Conexion conexion = new Conexion();
                    string sql = "SELECT MAX(id) FROM tipo";
                    DataRow maxCod = conexion.EjecutarConsulta(sql);
                    conexion.Cierre();

                    if (maxCod != null && maxCod[0] != DBNull.Value)
                    {
                        limpiar_Click(sender, e);
                        cod.Text = (int.Parse(maxCod[0].ToString()) + 1).ToString();
                        desc.Focus();
                    }
                    else
                    {
                        limpiar_Click(sender, e);
                        cod.Text = "1"; 
                        desc.Focus();
                    }


                }
            }
        }

        private void search()
        {
            Conexion conexion = new Conexion();

            string sql = "SELECT * FROM tipo WHERE id = @codigo";
            var parametros = new Dictionary<string, object>
            {
                { "@codigo", cod.Text }
            };
            DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);
            conexion.Cierre();

            if (resultado != null)
            {
                desc.Text = resultado[1].ToString();
            }
        }

        private void Mant_tipo_Load(object sender, EventArgs e)
        {
            cod.Focus();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cod.Text) || string.IsNullOrWhiteSpace(desc.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();
                string sql = "SELECT * FROM tipo WHERE id = @codigo";
                var parametros = new Dictionary<string, object>
        {
            { "@codigo", cod.Text },
            {"@descripcion", desc.Text }
        };

                DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);

                int existe = 0; // Valor por defecto
                if (resultado != null && resultado["Cuenta"] != DBNull.Value)
                {
                    existe = Convert.ToInt32(resultado["Cuenta"]);
                }

                if (existe > 0)
                {
                    sql = @"
            UPDATE tipo
            SET descipcion = @descripcion
            WHERE id = @codigo";
                    conexion.EjecutarConsultaSimpleFila(sql, parametros);
                }
                else
                {
                    sql = @"
            INSERT INTO tipo (descripcion)
            VALUES (@descripcion)";
                    conexion.EjecutarConsultaSimpleFila(sql, parametros);
                }

                conexion.Cierre();
                limpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
