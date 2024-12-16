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
    public partial class Con_Balanza : Form
    {
        public Con_Balanza()
        {
            InitializeComponent();
        }
        /* sql balanza:
                    SELECT 
                C.Grupo_Cta AS Categoria, 
                CASE 
                    WHEN C.Grupo_Cta = 1 THEN 'Activos'
                    WHEN C.Grupo_Cta = 2 THEN 'Pasivos'
                    WHEN C.Grupo_Cta = 3 THEN 'Capital'
                    WHEN C.Grupo_Cta = 4 THEN 'Ingresos'
                    WHEN C.Grupo_Cta = 5 THEN 'Gastos'
                    ELSE 'Otros'
                END AS DescripcionCategoria,
                SUM(C.Debito_Acum_Cta) AS TotalDebito,
                SUM(C.Credito_Acum_Cta) AS TotalCredito,
                SUM(C.Balance_Cta) AS Balance
            FROM catalogoC C
            WHERE C.Tipo_Cta = 1 -- Solo cuentas generales
            GROUP BY C.Grupo_Cta
            ORDER BY C.Grupo_Cta;
       */
        private void Con_Balanza_Load(object sender, EventArgs e)
        {

        }
    }
}
