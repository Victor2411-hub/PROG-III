
namespace Prueba___BETA.mantenimiento
{
    partial class Mant_usuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guardar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cod = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.guardar);
            this.panel1.Controls.Add(this.limpiar);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.tipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.apellidos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cod);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 541);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guardar.ForeColor = System.Drawing.Color.Black;
            this.guardar.Location = new System.Drawing.Point(343, 485);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(121, 42);
            this.guardar.TabIndex = 19;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.Location = new System.Drawing.Point(186, 485);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(121, 42);
            this.limpiar.TabIndex = 18;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(17, 485);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 42);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tipo
            // 
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.tipo.Location = new System.Drawing.Point(153, 418);
            this.tipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(176, 33);
            this.tipo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(74, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo:";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email.Location = new System.Drawing.Point(153, 365);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(304, 30);
            this.email.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(51, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correo:";
            // 
            // apellidos
            // 
            this.apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.apellidos.Location = new System.Drawing.Point(153, 306);
            this.apellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(236, 30);
            this.apellidos.TabIndex = 10;
            this.apellidos.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellidos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombre.Location = new System.Drawing.Point(153, 254);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(236, 30);
            this.nombre.TabIndex = 8;
            this.nombre.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombres:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pass.Location = new System.Drawing.Point(153, 201);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(200, 30);
            this.pass.TabIndex = 6;
            this.pass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.user.Location = new System.Drawing.Point(153, 148);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(200, 30);
            this.user.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // cod
            // 
            this.cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cod.Location = new System.Drawing.Point(153, 91);
            this.cod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(139, 30);
            this.cod.TabIndex = 2;
            this.cod.TextChanged += new System.EventHandler(this.cod_TextChanged);
            this.cod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cod_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(55, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Código:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, -12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(876, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba___BETA.Properties.Resources.Blue_Modern_Financial_Services_Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento de Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Mant_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 541);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mant_usuarios";
            this.Text = "Mantusuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mantusuarios_FormClosing);
            this.Load += new System.EventHandler(this.Mantusuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.TextBox cod;
    }
}