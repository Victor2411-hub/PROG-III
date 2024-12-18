
using System.Windows.Forms;

namespace Prueba___BETA
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPrinc = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.balanzaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPrinc.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 547);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Prueba___BETA.Properties.Resources.grande_espacio;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(883, 520);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 27);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba___BETA.Properties.Resources.icons8_user_96__2_;
            this.pictureBox1.Location = new System.Drawing.Point(19, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(832, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // menuPrinc
            // 
            this.menuPrinc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.menuPrinc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPrinc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuPrinc.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuPrinc.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuPrinc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuPrinc.Location = new System.Drawing.Point(0, 0);
            this.menuPrinc.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.menuPrinc.Name = "menuPrinc";
            this.menuPrinc.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.menuPrinc.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrinc.Size = new System.Drawing.Size(883, 41);
            this.menuPrinc.TabIndex = 0;
            this.menuPrinc.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.catálogoDeCuentaToolStripMenuItem,
            this.entradaDeDiarioToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(141, 25);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // catálogoDeCuentaToolStripMenuItem
            // 
            this.catálogoDeCuentaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.catálogoDeCuentaToolStripMenuItem.Name = "catálogoDeCuentaToolStripMenuItem";
            this.catálogoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.catálogoDeCuentaToolStripMenuItem.Text = "Catálogo de Cuenta";
            this.catálogoDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.catálogoDeCuentaToolStripMenuItem_Click);
            // 
            // entradaDeDiarioToolStripMenuItem
            // 
            this.entradaDeDiarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.entradaDeDiarioToolStripMenuItem.Name = "entradaDeDiarioToolStripMenuItem";
            this.entradaDeDiarioToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.entradaDeDiarioToolStripMenuItem.Text = "Entrada de Diario";
            this.entradaDeDiarioToolStripMenuItem.Click += new System.EventHandler(this.entradaDeDiarioToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem});
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.procesosToolStripMenuItem.Text = "Movimientos";
            this.procesosToolStripMenuItem.Click += new System.EventHandler(this.procesosToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreDiarioToolStripMenuItem});
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.consultasToolStripMenuItem.Text = "Procesos";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // cierreDiarioToolStripMenuItem
            // 
            this.cierreDiarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cierreDiarioToolStripMenuItem.Name = "cierreDiarioToolStripMenuItem";
            this.cierreDiarioToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cierreDiarioToolStripMenuItem.Text = "Cierre Diario";
            this.cierreDiarioToolStripMenuItem.Click += new System.EventHandler(this.cierreDiarioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogoDeCuentasToolStripMenuItem,
            this.transaccionesToolStripMenuItem1,
            this.balanzaGeneralToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.ayudaToolStripMenuItem.Text = "Consultas";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // catálogoDeCuentasToolStripMenuItem
            // 
            this.catálogoDeCuentasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.catálogoDeCuentasToolStripMenuItem.Name = "catálogoDeCuentasToolStripMenuItem";
            this.catálogoDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.catálogoDeCuentasToolStripMenuItem.Text = "Catálogo de Cuentas";
            this.catálogoDeCuentasToolStripMenuItem.Click += new System.EventHandler(this.catálogoDeCuentasToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem1
            // 
            this.transaccionesToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.transaccionesToolStripMenuItem1.Name = "transaccionesToolStripMenuItem1";
            this.transaccionesToolStripMenuItem1.Size = new System.Drawing.Size(217, 24);
            this.transaccionesToolStripMenuItem1.Text = "Transacciones";
            this.transaccionesToolStripMenuItem1.Click += new System.EventHandler(this.transaccionesToolStripMenuItem1_Click);
            // 
            // balanzaGeneralToolStripMenuItem
            // 
            this.balanzaGeneralToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.balanzaGeneralToolStripMenuItem.Name = "balanzaGeneralToolStripMenuItem";
            this.balanzaGeneralToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.balanzaGeneralToolStripMenuItem.Text = "Balanza General";
            this.balanzaGeneralToolStripMenuItem.Click += new System.EventHandler(this.balanzaGeneralToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuPrinc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 42);
            this.panel3.TabIndex = 1;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(883, 547);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menu";
            this.Text = "CONTALEON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPrinc.ResumeLayout(false);
            this.menuPrinc.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuPrinc;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ToolStripMenuItem catálogoDeCuentaToolStripMenuItem;
        private ToolStripMenuItem entradaDeDiarioToolStripMenuItem;
        private ToolStripMenuItem transaccionesToolStripMenuItem;
        private ToolStripMenuItem cierreDiarioToolStripMenuItem;
        private ToolStripMenuItem catálogoDeCuentasToolStripMenuItem;
        private ToolStripMenuItem transaccionesToolStripMenuItem1;
        private ToolStripMenuItem balanzaGeneralToolStripMenuItem;
        private Panel panel3;
        private PictureBox pictureBox2;
    }
}