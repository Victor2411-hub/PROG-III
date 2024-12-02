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
    public partial class menu : Form
    {
        public string user;
        public menu()
        {

            InitializeComponent();
            StartTimer();
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            label1.Text = user;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento.Mant_usuarios form = new mantenimiento.Mant_usuarios();
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
            form.BringToFront();
            form.Left = (panel1.Width - form.Width) / 2;
            form.Top = (panel1.Height - form.Height) / 2;
        }

        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(timer_Tick);
            t.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bCierreDeFinDeAñoFiscaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
