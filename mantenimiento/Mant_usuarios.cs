using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prueba___BETA.mantenimiento
{
    public partial class Mant_usuarios : Form
    {
        public string ValorSeleccionado { get; private set; } 

        public Mant_usuarios()
        {
            InitializeComponent();
        }


        private void Mantusuarios_Load(object sender, EventArgs e)
        {
            cod.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            consulta.Con_usuario form = new consulta.Con_usuario();
            form.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cod_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Mantusuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.Cierre();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            Conexion conexion = new Conexion();

            string sql;
            var parametros = new Dictionary<string, object>
    {
                { "@user", user.Text },
                { "@pass", pass.Text },
                { "@nombre", nombre.Text },
                { "@apellidos", apellidos.Text },
                { "@email", email.Text },
                { "@tipo", tipo.SelectedItem.ToString() == "Administrador" ? 0 : 1 }
            };

            if (string.IsNullOrWhiteSpace(cod.Text))
            {
                sql = "INSERT INTO usuarios (login_usuario, pass_usuario, nombre_usuario, apellidos_usuario, email_usuario, Nivel_Acceso) " +
                      "VALUES (@user, @pass, @nombre, @apellidos, @email, @tipo)";
            }
            else 
            {
                sql = "UPDATE usuarios SET login_usuario = @user, pass_usuario = @pass, nombre_usuario = @nombre, " +
                      "apellidos_usuario = @apellidos, email_usuario = @email, Nivel_Acceso = @tipo WHERE cod_user = @codigo";
                parametros.Add("@codigo", cod.Text); 
            }

            try
            {
                conexion.EjecutarConsultaSimpleFila(sql, parametros);

                if (string.IsNullOrWhiteSpace(cod.Text))
                {
                    MessageBox.Show("Usuario guardado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Usuario actualizado exitosamente.");
                }

                limpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la operación: " + ex.Message);
            }
            finally
            {
                conexion.Cierre();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(user.Text) ||
                string.IsNullOrWhiteSpace(pass.Text) ||
                string.IsNullOrWhiteSpace(nombre.Text) ||
                string.IsNullOrWhiteSpace(apellidos.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                tipo.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!email.Text.Contains("@"))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return false;
            }

            return true;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            cod.Clear();
            user.Clear();
            pass.Clear();
            nombre.Clear();
            apellidos.Clear();
            email.Clear();
            tipo.SelectedIndex = -1;
        }

        private void cod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F5)
            {
                consulta.Con_usuario consultaForm = new consulta.Con_usuario(); 

                if (consultaForm.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(consultaForm.ValorSeleccionado))
                    {
                        cod.Text = consultaForm.ValorSeleccionado; 
                        search(sender, e);
                    }
                }
            }
        }

        private void search(object sender, KeyEventArgs e)
        {
            Conexion conexion = new Conexion();

            string sql = "SELECT * FROM usuarios WHERE cod_user = @codigo";
            var parametros = new Dictionary<string, object>
        {
            { "@codigo", cod.Text }
        };
            DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);
            conexion.Cierre();

            if (resultado != null)
            {
                user.Text = resultado["login_usuario"].ToString();
                pass.Text = resultado["pass_usuario"].ToString();
                nombre.Text = resultado["nombre_usuario"].ToString();
                apellidos.Text = resultado["apellidos_usuario"].ToString();
                email.Text = resultado["email_usuario"].ToString();
                tipo.SelectedItem = resultado["Nivel_Acceso"].ToString() == "0" ? "Administrador" : "Empleado";
            }
            else
            {
                sql = "SELECT MAX(cod_user) FROM usuarios";
                DataRow maxCod = conexion.EjecutarConsulta(sql);
                conexion.Cierre();
                if (maxCod != null)
                {
                    limpiar_Click(sender, e);
                    cod.Text = (int.Parse(maxCod[0].ToString()) + 1).ToString();
                }
            }
        }
    }

}
