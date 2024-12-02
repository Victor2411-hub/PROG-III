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
    public partial class Con_usuario : Form
    {
        public Con_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Con_usuario_Load(object sender, EventArgs e)
        {
            txtbuscar.Focus();
        }

        private void Con_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
            else if (e.KeyChar == 13 || e.KeyChar == 116) 
            {
                userselec();
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
            else if (e.KeyChar == 13 || e.KeyChar == 116)
            {
                userselec();
            }
        }

        private void userselec()
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text) || txtbuscar.Text == "")
            {
                Conexion conexion = new Conexion();
                string sql = "SELECT cod_user AS Código, nombre_usuario AS Nombres, apellidos_usuario AS Apellidos, login_usuario AS Usuario, email_usuario AS Correo, CASE WHEN nivel_Acceso = 0 THEN 'Administrador' WHEN nivel_Acceso = 1 THEN 'Empleado' ELSE 'Desconocido' END AS Tipo FROM usuarios;\r\n";
                dataGridView1.DataSource = conexion.Tabla(sql);
                dataGridView1.Refresh();
            }
            else
            {

            }
        }
    }
}
