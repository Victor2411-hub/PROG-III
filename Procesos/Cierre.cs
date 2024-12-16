using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba___BETA.Procesos
{
    public partial class Cierre : Form
    {
        public Cierre()
        {
            InitializeComponent();
        }

        private void Cierre_Load(object sender, EventArgs e)
        {
            desde.Format = DateTimePickerFormat.Custom;
            desde.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            hasta.Format = DateTimePickerFormat.Custom;
            hasta.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            DateTime hoy = DateTime.Today;
            desde.Value = hoy;
            hasta.Value = hoy.AddDays(1).AddSeconds(-1);
        }

        private void recalcular_Click(object sender, EventArgs e)
        {
            if (desde.Value > hasta.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql= "dbo.RecalcularBalances";
            Conexion conexion = new Conexion();
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@FechaDesde", desde.Value },   
                { "@FechaHasta", hasta.Value }
            };

            conexion.EjecutarP(sql, parametros);
            conexion.Cierre();

            MessageBox.Show("Se ha recalculado");
        }
    }
}
