using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Prueba___BETA.mantenimiento
{
    public partial class Mant_catalogo : Form
    {
        public string ValorSeleccionado { get; private set; }

        public Mant_catalogo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            consulta.Con_catalogo form = new consulta.Con_catalogo();
            form.ShowDialog();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            consulta.Con_catalogo form = new consulta.Con_catalogo();
            form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            cod.Clear();
            codcuenta.Clear();
            desc.Clear();
            if (general.Checked)
            {
                general.Checked = false;
            }
            if (auxiliar.Checked)
            {
                auxiliar.Checked = false;
            }
            nivel.Clear();
            fecha.Value = DateTime.Now;
            Grupo.Clear();
            nombrec.Clear();
            cuentac.Clear();
        }

        private void codcuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(codcuenta.Text))
                {
                    buscarPorNroCta(codcuenta.Text);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de cuenta válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Down)
            {
                desc.Focus();
            }
        }

        private void buscarPorNroCta(string nroCta)
        {
            try
            {
                Conexion conexion = new Conexion();
                string sql = "SELECT * FROM catalogoC WHERE Nro_Cta = @Nro_Cta";
                var parametros = new Dictionary<string, object>
        {
            { "@Nro_Cta", nroCta }
        };

                DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);
                conexion.Cierre();

                if (resultado != null)
                {
                    cod.Text = resultado["ID"].ToString();
                    codcuenta.Text = resultado["Nro_Cta"].ToString();
                    desc.Text = resultado["Descripcion_Cta"].ToString();
                    general.Checked = resultado["Tipo_Cta"].ToString() == "True";
                    auxiliar.Checked = resultado["Tipo_Cta"].ToString() == "False";
                    nivel.Text = resultado["Nivel_Cta"].ToString();
                    cuentac.Text = resultado["Cta_Padre"].ToString();
                    Grupo.Text = obtenerNombreCuentaPrincipal(resultado["Cta_Padre"].ToString());
                    cuentac.Text = resultado["Cta_Padre"].ToString();
                    nombrec.Text = obtenerNombreCuentaPrincipal(resultado["Cta_Padre"].ToString());
                    fecha.Value = DateTime.Parse(resultado["Fecha_Creacion_Cta"].ToString());
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna cuenta con el número especificado. Se generará un nuevo registro.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    generarNuevoID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la cuenta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void generarNuevoID()
        {
            try
            {
                Conexion conexion = new Conexion();
                string sql = "SELECT MAX(ID) AS UltimoID FROM catalogoC";
                DataRow resultado = conexion.EjecutarConsulta(sql);
                conexion.Cierre();

                if (resultado != null && !string.IsNullOrEmpty(resultado["UltimoID"].ToString()))
                {
                    int nuevoID = int.Parse(resultado["UltimoID"].ToString()) + 1;
                    cod.Text = nuevoID.ToString();
                }
                else
                {
                    cod.Text = "1";
                }

                limpiar_Click(null, null);
                fecha.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar un nuevo ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void search(object sender, KeyEventArgs e)
        {
            Conexion conexion = new Conexion();

            string sql = "SELECT * FROM catalogoC WHERE ID = @codigo";
            var parametros = new Dictionary<string, object>
        {
            { "@codigo", cod.Text }
        };
            DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);
            conexion.Cierre();

            if (resultado != null)
            {
             codcuenta.Text = resultado["Nro_Cta"].ToString();
             desc.Text = resultado["Descripcion_Cta"].ToString();
                if (resultado["tipo_Cta"].ToString() == "True")
                {
                    general.Checked = true;
                }
                else
                {
                    auxiliar.Checked = true;
                }
                nivel.Text = resultado["nivel_Cta"].ToString();
                fecha.Value = DateTime.Parse(resultado["fecha_creacion_Cta"].ToString());
                Grupo.Text = obtenerNombreCuentaPrincipal(resultado["Cta_Padre"].ToString());
                cuentac.Text = resultado["Cta_Padre"].ToString();
                nombrec.Text = obtenerNombreCuentaPrincipal(resultado["Cta_Padre"].ToString());
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(string.IsNullOrWhiteSpace(cod.Text)))
                {

                    search(sender, e);
                }
                else
                {
                    Conexion conexion = new Conexion();
                    string sql = "SELECT MAX(ID) FROM catalogoC";
                    DataRow maxCod = conexion.EjecutarConsulta(sql);
                    conexion.Cierre();
                    if (maxCod != null)
                    {
                        limpiar_Click(sender, e);
                        cod.Text = (int.Parse(maxCod[0].ToString()) + 1).ToString();
                    }

                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F5)
            {
                consulta.Con_catalogo consultaForm = new consulta.Con_catalogo();

                if (consultaForm.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(consultaForm.ValorSeleccionado))
                    {
                        cod.Text = consultaForm.ValorSeleccionado;
                        search(sender, e);
                    }
                }
            }
            if(e.KeyCode  == Keys.Down)
            {
                codcuenta.Focus();
            }
        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void general_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void auxiliar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuentac_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombrec_TextChanged(object sender, EventArgs e)
        {

        }

        private string obtenerNombreCuentaPrincipal(string nroCtaPadre)
        {
            if (string.IsNullOrWhiteSpace(nroCtaPadre))
            {
                return ""; 
            }

            try
            {
                Conexion conexion = new Conexion();
                string sql = "SELECT Descripcion_Cta FROM catalogoC WHERE Nro_Cta = @Nro_Cta";
                var parametros = new Dictionary<string, object>
        {
            { "@Nro_Cta", nroCtaPadre }
        };

                DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);
                conexion.Cierre();

                if (resultado != null)
                {
                    return resultado["Descripcion_Cta"].ToString(); 
                }
                else
                {
                    return "Cuenta no encontrada";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el nombre de la cuenta principal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codcuenta.Text) || string.IsNullOrWhiteSpace(desc.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();
                string sql = "SELECT COUNT(*) AS Cuenta FROM catalogoC WHERE Nro_Cta = @Nro_Cta";
                var parametros = new Dictionary<string, object>
        {
            { "@Nro_Cta", codcuenta.Text }
        };

                DataRow resultado = conexion.EjecutarConsultaSimpleFila(sql, parametros);

                int existe = 0; // Valor por defecto
                if (resultado != null && resultado["Cuenta"] != DBNull.Value)
                {
                    existe = Convert.ToInt32(resultado["Cuenta"]);
                }

                string ctaPadre = obtenerCuentaPadre(codcuenta.Text);
                int nivelCuenta = calcularNivel(codcuenta.Text);
                string grupoCuenta = obtenerNombreCuentaPrincipal(ctaPadre);

                parametros.Clear();
                parametros["@Nro_Cta"] = codcuenta.Text;
                parametros["@Descripcion_Cta"] = desc.Text;
                parametros["@Tipo_Cta"] = general.Checked;
                parametros["@Nivel_Cta"] = nivelCuenta;
                parametros["@Cta_Padre"] = ctaPadre;
                parametros["@Grupo_Cta"] = ctaPadre;
                parametros["@Fecha_Creacion_Cta"] = fecha.Value;

                if (existe > 0)
                {
                    sql = @"
            UPDATE catalogoC
            SET Descripcion_Cta = @Descripcion_Cta,
                Tipo_Cta = @Tipo_Cta,
                Nivel_Cta = @Nivel_Cta,
                Cta_Padre = @Cta_Padre,
                Grupo_Cta = @Grupo_Cta,
                Fecha_Creacion_Cta = @Fecha_Creacion_Cta
            WHERE Nro_Cta = @Nro_Cta";
                    conexion.EjecutarConsultaSimpleFila(sql, parametros);
                }
                else
                {
                    sql = @"
            INSERT INTO catalogoC (Nro_Cta, Descripcion_Cta, Tipo_Cta, Nivel_Cta, Cta_Padre, Grupo_Cta, Fecha_Creacion_Cta)
            VALUES (@Nro_Cta, @Descripcion_Cta, @Tipo_Cta, @Nivel_Cta, @Cta_Padre, @Grupo_Cta, @Fecha_Creacion_Cta)";
                    conexion.EjecutarConsultaSimpleFila(sql, parametros);
                }

                conexion.Cierre();
                limpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la cuenta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string obtenerCuentaPadre(string nroCta)
        {
            if (string.IsNullOrWhiteSpace(nroCta))
                return "";

            
            string[] partes = nroCta.Split('.');
            return partes.Length > 0 ? partes[0] : "";
        }
        private int calcularNivel(string nroCta)
        {
            if (string.IsNullOrWhiteSpace(nroCta))
                return 0;

            return nroCta.Count(c => c == '.') + 1;
        }

        private void Mant_catalogo_Load(object sender, EventArgs e)
        {
            cod.Focus();
        }

        private void codcuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(desc.Text))
                {
                    general.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una descripción válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
