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
               button1.Focus();
            }
        }

        private void search()
        {

        }
    }
}
