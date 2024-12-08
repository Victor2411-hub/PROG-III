using Prueba___BETA.mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba___BETA.consulta
{
    public partial class Con_catalogo : Form
    {
        public string ValorSeleccionado { get; private set; }
        public Con_catalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarCuentas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Con_catalogo_Load(object sender, EventArgs e)
        {
            txtbuscar.Focus();
        }

        private void Con_catalogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
            else if (e.KeyChar == 13 || e.KeyChar == 116)
            {
                buscarCuentas();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarCuentas()
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text) || txtbuscar.Text == "")
            {
                Conexion conexion = new Conexion();
                string sql = "SELECT Nro_Cta AS 'Número de Cuenta', Descripcion_Cta AS Descripción, CASE WHEN Tipo_Cta = 1 THEN 'General' ELSE 'Auxiliar' END AS Tipo, Nivel_Cta AS Nivel, Cta_Padre AS 'Cuenta Padre',Fecha_creacion_Cta 'Creado'  FROM catalogoC;";
                dataGridView1.DataSource = conexion.Tabla(sql);
                dataGridView1.Refresh();
            }
            else
            {
                Conexion conexion = new Conexion();
                string palabraClave = txtbuscar.Text.Trim(); // Limpia espacios al inicio y final
                string sql = $@"
        SELECT 
            Nro_Cta AS 'Número de Cuenta', 
            Descripcion_Cta AS Descripción, 
            CASE 
                WHEN Tipo_Cta = 1 THEN 'General' 
                ELSE 'Auxiliar' 
            END AS Tipo, 
            Nivel_Cta AS Nivel, 
            Cta_Padre AS 'Cuenta Padre' 
        FROM catalogoC
        WHERE 
            Nro_Cta LIKE '%{palabraClave}%' OR
            Descripcion_Cta LIKE '%{palabraClave}%' OR
            Cta_Padre LIKE '%{palabraClave}%';
    ";
                dataGridView1.DataSource = conexion.Tabla(sql);
                dataGridView1.Refresh();
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F5)
            {
                buscarCuentas();
            }
            else if (e.KeyCode == Keys.Down)
            {
                dataGridView1.Focus();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                ValorSeleccionado = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    ValorSeleccionado = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Con_catalogo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
    }
}
