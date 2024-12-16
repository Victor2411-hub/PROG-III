using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba___BETA
{
    public partial class INGRESO : Form
    {
        public INGRESO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            string sql = "SELECT * FROM usuarios WHERE login_usuario = @usuario AND pass_usuario = @codigo";
            var parametros = new Dictionary<string, object>
            {
                { "@usuario", txtUser.Text },
                { "@codigo", txtPass.Text }
            };
            DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);

            if (resultado != null)
            {
                conexion.Cierre();
                this.Hide();
                menu menu = new menu();
                menu.user = txtUser.Text;
                menu.ShowDialog();
                this.Close();
            }else{
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void INGRESO_Load(object sender, EventArgs e)
        {

        }

        //Cuando cierre el form
        private void INGRESO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.Cierre();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresar_Click(sender, e);
            }
        }
    }
}
