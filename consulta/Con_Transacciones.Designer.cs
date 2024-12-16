namespace Prueba___BETA.consulta
{
    partial class Con_Transacciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Con_Transacciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comentario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detalle = new System.Windows.Forms.DataGridView();
            this.hasta = new System.Windows.Forms.DateTimePicker();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.transacciones = new System.Windows.Forms.DataGridView();
            this.documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.comentario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.detalle);
            this.panel1.Controls.Add(this.hasta);
            this.panel1.Controls.Add(this.desde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.transacciones);
            this.panel1.Controls.Add(this.documento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 613);
            this.panel1.TabIndex = 2;
            // 
            // comentario
            // 
            this.comentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comentario.Location = new System.Drawing.Point(20, 418);
            this.comentario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comentario.Multiline = true;
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(272, 138);
            this.comentario.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nota:";
            // 
            // detalle
            // 
            this.detalle.AllowUserToAddRows = false;
            this.detalle.AllowUserToDeleteRows = false;
            this.detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.detalle.Location = new System.Drawing.Point(304, 418);
            this.detalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.RowHeadersWidth = 51;
            this.detalle.RowTemplate.Height = 24;
            this.detalle.Size = new System.Drawing.Size(369, 137);
            this.detalle.TabIndex = 9;
            // 
            // hasta
            // 
            this.hasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hasta.CustomFormat = "dd/MM/yyy";
            this.hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hasta.Location = new System.Drawing.Point(464, 112);
            this.hasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(210, 23);
            this.hasta.TabIndex = 8;
            // 
            // desde
            // 
            this.desde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.desde.CustomFormat = "";
            this.desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.desde.Location = new System.Drawing.Point(464, 72);
            this.desde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(210, 23);
            this.desde.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(399, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(399, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desde:";
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(295, 570);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 32);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // transacciones
            // 
            this.transacciones.AllowUserToAddRows = false;
            this.transacciones.AllowUserToDeleteRows = false;
            this.transacciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transacciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transacciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.transacciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transacciones.Location = new System.Drawing.Point(20, 159);
            this.transacciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transacciones.Name = "transacciones";
            this.transacciones.ReadOnly = true;
            this.transacciones.RowHeadersWidth = 51;
            this.transacciones.RowTemplate.Height = 24;
            this.transacciones.Size = new System.Drawing.Size(653, 231);
            this.transacciones.TabIndex = 3;
            this.transacciones.SelectionChanged += new System.EventHandler(this.transacciones_SelectionChanged);
            // 
            // documento
            // 
            this.documento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.documento.ForeColor = System.Drawing.Color.Black;
            this.documento.Location = new System.Drawing.Point(118, 66);
            this.documento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(257, 30);
            this.documento.TabIndex = 1;
            this.documento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.documento_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, -8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(703, 67);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba___BETA.Properties.Resources.Blue_Modern_Financial_Services_Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(9, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Consulta de Usuario";
            // 
            // Con_Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 613);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Con_Transacciones";
            this.Text = "Consulta de Transacciones";
            this.Load += new System.EventHandler(this.Con_Transacciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView transacciones;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hasta;
        private System.Windows.Forms.DataGridView detalle;
        private System.Windows.Forms.TextBox comentario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}