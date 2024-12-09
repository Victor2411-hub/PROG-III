namespace Prueba___BETA.transacciones
{
    partial class diario
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
            this.cta_nombre = new System.Windows.Forms.TextBox();
            this.cta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.credito = new System.Windows.Forms.TextBox();
            this.debito = new System.Windows.Forms.TextBox();
            this.total_c = new System.Windows.Forms.TextBox();
            this.Nro_Cta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_Cta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.comentario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comentario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.total_c);
            this.panel1.Controls.Add(this.debito);
            this.panel1.Controls.Add(this.credito);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guardar);
            this.panel1.Controls.Add(this.limpiar);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.cta_nombre);
            this.panel1.Controls.Add(this.cta);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 639);
            this.panel1.TabIndex = 1;
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guardar.ForeColor = System.Drawing.Color.Black;
            this.guardar.Location = new System.Drawing.Point(645, 581);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(121, 42);
            this.guardar.TabIndex = 22;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.Location = new System.Drawing.Point(322, 581);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(121, 42);
            this.limpiar.TabIndex = 21;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(12, 581);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 42);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // cta_nombre
            // 
            this.cta_nombre.BackColor = System.Drawing.Color.LemonChiffon;
            this.cta_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cta_nombre.Enabled = false;
            this.cta_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cta_nombre.ForeColor = System.Drawing.Color.Black;
            this.cta_nombre.Location = new System.Drawing.Point(185, 88);
            this.cta_nombre.Name = "cta_nombre";
            this.cta_nombre.Size = new System.Drawing.Size(581, 34);
            this.cta_nombre.TabIndex = 3;
            this.cta_nombre.TextChanged += new System.EventHandler(this.cta_nombre_TextChanged);
            // 
            // cta
            // 
            this.cta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cta.ForeColor = System.Drawing.Color.Black;
            this.cta.Location = new System.Drawing.Point(23, 88);
            this.cta.Name = "cta";
            this.cta.Size = new System.Drawing.Size(156, 34);
            this.cta.TabIndex = 2;
            this.cta.TextChanged += new System.EventHandler(this.cta_TextChanged);
            this.cta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cta_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Cta,
            this.descripcion_Cta,
            this.Valor_Credito,
            this.Valor_Debito});
            this.dataGridView1.Location = new System.Drawing.Point(23, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 308);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Libro Diario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Crédito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Débito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total:";
            // 
            // credito
            // 
            this.credito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.credito.Enabled = false;
            this.credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.credito.ForeColor = System.Drawing.Color.Black;
            this.credito.Location = new System.Drawing.Point(609, 458);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(156, 26);
            this.credito.TabIndex = 26;
            this.credito.TextChanged += new System.EventHandler(this.credito_TextChanged);
            // 
            // debito
            // 
            this.debito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debito.Enabled = false;
            this.debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.debito.ForeColor = System.Drawing.Color.Black;
            this.debito.Location = new System.Drawing.Point(609, 497);
            this.debito.Name = "debito";
            this.debito.Size = new System.Drawing.Size(156, 26);
            this.debito.TabIndex = 27;
            this.debito.TextChanged += new System.EventHandler(this.debito_TextChanged);
            // 
            // total_c
            // 
            this.total_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_c.Enabled = false;
            this.total_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.total_c.ForeColor = System.Drawing.Color.Black;
            this.total_c.Location = new System.Drawing.Point(609, 536);
            this.total_c.Name = "total_c";
            this.total_c.Size = new System.Drawing.Size(156, 26);
            this.total_c.TabIndex = 28;
            this.total_c.TextChanged += new System.EventHandler(this.total_c_TextChanged);
            // 
            // Nro_Cta
            // 
            this.Nro_Cta.HeaderText = "N° de Cuenta";
            this.Nro_Cta.MinimumWidth = 6;
            this.Nro_Cta.Name = "Nro_Cta";
            // 
            // descripcion_Cta
            // 
            this.descripcion_Cta.HeaderText = "Descripción de Cuenta";
            this.descripcion_Cta.MinimumWidth = 6;
            this.descripcion_Cta.Name = "descripcion_Cta";
            // 
            // Valor_Credito
            // 
            this.Valor_Credito.HeaderText = "Crédito";
            this.Valor_Credito.MinimumWidth = 6;
            this.Valor_Credito.Name = "Valor_Credito";
            // 
            // Valor_Debito
            // 
            this.Valor_Debito.HeaderText = "Débito";
            this.Valor_Debito.MinimumWidth = 6;
            this.Valor_Debito.Name = "Valor_Debito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nota:";
            // 
            // comentario
            // 
            this.comentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comentario.Location = new System.Drawing.Point(23, 480);
            this.comentario.Multiline = true;
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(420, 82);
            this.comentario.TabIndex = 30;
            this.comentario.TextChanged += new System.EventHandler(this.comentario_TextChanged);
            // 
            // diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 639);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "diario";
            this.Text = "diario";
            this.Load += new System.EventHandler(this.diario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cta_nombre;
        private System.Windows.Forms.TextBox cta;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox total_c;
        private System.Windows.Forms.TextBox debito;
        private System.Windows.Forms.TextBox credito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comentario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Cta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_Cta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Debito;
    }
}