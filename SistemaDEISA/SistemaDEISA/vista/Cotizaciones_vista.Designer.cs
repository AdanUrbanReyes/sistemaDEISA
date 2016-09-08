namespace SistemaDEISA.vista
{
    partial class Cotizaciones_vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizaciones_vista));
            this.razonSocial_label = new System.Windows.Forms.Label();
            this.razonSocial_comboBox = new System.Windows.Forms.ComboBox();
            this.planta_label = new System.Windows.Forms.Label();
            this.planta_comboBox = new System.Windows.Forms.ComboBox();
            this.direccion_textBox = new System.Windows.Forms.TextBox();
            this.empresa_textBox = new System.Windows.Forms.TextBox();
            this.giro_textBox = new System.Windows.Forms.TextBox();
            this.rfc_label = new System.Windows.Forms.Label();
            this.proveedor_label = new System.Windows.Forms.Label();
            this.sae_label = new System.Windows.Forms.Label();
            this.fechaRealizacion_label = new System.Windows.Forms.Label();
            this.dirigirA_groupBox = new System.Windows.Forms.GroupBox();
            this.nombreDirigirA_label = new System.Windows.Forms.Label();
            this.puestoDirigirA_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dirigirA_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // razonSocial_label
            // 
            this.razonSocial_label.AutoSize = true;
            this.razonSocial_label.Location = new System.Drawing.Point(11, 32);
            this.razonSocial_label.Name = "razonSocial_label";
            this.razonSocial_label.Size = new System.Drawing.Size(93, 17);
            this.razonSocial_label.TabIndex = 1;
            this.razonSocial_label.Text = "Razon social:";
            // 
            // razonSocial_comboBox
            // 
            this.razonSocial_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.razonSocial_comboBox.FormattingEnabled = true;
            this.razonSocial_comboBox.Location = new System.Drawing.Point(110, 29);
            this.razonSocial_comboBox.Name = "razonSocial_comboBox";
            this.razonSocial_comboBox.Size = new System.Drawing.Size(612, 25);
            this.razonSocial_comboBox.TabIndex = 2;
            this.razonSocial_comboBox.Enter += new System.EventHandler(this.razonSocial_comboBox_Enter);
            this.razonSocial_comboBox.Leave += new System.EventHandler(this.razonSocial_comboBox_Leave);
            // 
            // planta_label
            // 
            this.planta_label.AutoSize = true;
            this.planta_label.Location = new System.Drawing.Point(50, 68);
            this.planta_label.Name = "planta_label";
            this.planta_label.Size = new System.Drawing.Size(54, 17);
            this.planta_label.TabIndex = 3;
            this.planta_label.Text = "Planta:";
            // 
            // planta_comboBox
            // 
            this.planta_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planta_comboBox.FormattingEnabled = true;
            this.planta_comboBox.Location = new System.Drawing.Point(110, 65);
            this.planta_comboBox.Name = "planta_comboBox";
            this.planta_comboBox.Size = new System.Drawing.Size(612, 25);
            this.planta_comboBox.TabIndex = 4;
            this.planta_comboBox.Enter += new System.EventHandler(this.planta_comboBox_Enter);
            this.planta_comboBox.Leave += new System.EventHandler(this.planta_comboBox_Leave);
            // 
            // direccion_textBox
            // 
            this.direccion_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(108)))));
            this.direccion_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(212)))), ((int)(((byte)(181)))));
            this.direccion_textBox.Location = new System.Drawing.Point(14, 154);
            this.direccion_textBox.Name = "direccion_textBox";
            this.direccion_textBox.ReadOnly = true;
            this.direccion_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.direccion_textBox.Size = new System.Drawing.Size(712, 23);
            this.direccion_textBox.TabIndex = 5;
            // 
            // empresa_textBox
            // 
            this.empresa_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(108)))));
            this.empresa_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(212)))), ((int)(((byte)(181)))));
            this.empresa_textBox.Location = new System.Drawing.Point(14, 96);
            this.empresa_textBox.Name = "empresa_textBox";
            this.empresa_textBox.ReadOnly = true;
            this.empresa_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.empresa_textBox.Size = new System.Drawing.Size(712, 23);
            this.empresa_textBox.TabIndex = 6;
            // 
            // giro_textBox
            // 
            this.giro_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(92)))), ((int)(((byte)(108)))));
            this.giro_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(212)))), ((int)(((byte)(181)))));
            this.giro_textBox.Location = new System.Drawing.Point(14, 125);
            this.giro_textBox.Name = "giro_textBox";
            this.giro_textBox.ReadOnly = true;
            this.giro_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.giro_textBox.Size = new System.Drawing.Size(712, 23);
            this.giro_textBox.TabIndex = 7;
            // 
            // rfc_label
            // 
            this.rfc_label.AutoSize = true;
            this.rfc_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.rfc_label.Location = new System.Drawing.Point(14, 180);
            this.rfc_label.Name = "rfc_label";
            this.rfc_label.Size = new System.Drawing.Size(230, 17);
            this.rfc_label.TabIndex = 8;
            this.rfc_label.Text = "Registro Federal del Contribuyente";
            // 
            // proveedor_label
            // 
            this.proveedor_label.AutoSize = true;
            this.proveedor_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.proveedor_label.Location = new System.Drawing.Point(250, 180);
            this.proveedor_label.Name = "proveedor_label";
            this.proveedor_label.Size = new System.Drawing.Size(75, 17);
            this.proveedor_label.TabIndex = 9;
            this.proveedor_label.Text = "Proveedor";
            // 
            // sae_label
            // 
            this.sae_label.AutoSize = true;
            this.sae_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.sae_label.Location = new System.Drawing.Point(331, 180);
            this.sae_label.Name = "sae_label";
            this.sae_label.Size = new System.Drawing.Size(30, 17);
            this.sae_label.TabIndex = 10;
            this.sae_label.Text = "SAE";
            // 
            // fechaRealizacion_label
            // 
            this.fechaRealizacion_label.AutoSize = true;
            this.fechaRealizacion_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(82)))), ((int)(((byte)(4)))));
            this.fechaRealizacion_label.Location = new System.Drawing.Point(486, 9);
            this.fechaRealizacion_label.Name = "fechaRealizacion_label";
            this.fechaRealizacion_label.Size = new System.Drawing.Size(121, 17);
            this.fechaRealizacion_label.TabIndex = 11;
            this.fechaRealizacion_label.Text = "Fecha realizacion";
            // 
            // dirigirA_groupBox
            // 
            this.dirigirA_groupBox.Controls.Add(this.textBox2);
            this.dirigirA_groupBox.Controls.Add(this.textBox1);
            this.dirigirA_groupBox.Controls.Add(this.puestoDirigirA_label);
            this.dirigirA_groupBox.Controls.Add(this.nombreDirigirA_label);
            this.dirigirA_groupBox.Location = new System.Drawing.Point(17, 201);
            this.dirigirA_groupBox.Name = "dirigirA_groupBox";
            this.dirigirA_groupBox.Size = new System.Drawing.Size(709, 71);
            this.dirigirA_groupBox.TabIndex = 12;
            this.dirigirA_groupBox.TabStop = false;
            this.dirigirA_groupBox.Text = "Dirigir A";
            // 
            // nombreDirigirA_label
            // 
            this.nombreDirigirA_label.AutoSize = true;
            this.nombreDirigirA_label.Location = new System.Drawing.Point(7, 23);
            this.nombreDirigirA_label.Name = "nombreDirigirA_label";
            this.nombreDirigirA_label.Size = new System.Drawing.Size(136, 17);
            this.nombreDirigirA_label.TabIndex = 0;
            this.nombreDirigirA_label.Text = "Nombre Completo:";
            // 
            // puestoDirigirA_label
            // 
            this.puestoDirigirA_label.AutoSize = true;
            this.puestoDirigirA_label.Location = new System.Drawing.Point(357, 19);
            this.puestoDirigirA_label.Name = "puestoDirigirA_label";
            this.puestoDirigirA_label.Size = new System.Drawing.Size(55, 17);
            this.puestoDirigirA_label.TabIndex = 1;
            this.puestoDirigirA_label.Text = "Puesto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(360, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 23);
            this.textBox2.TabIndex = 3;
            // 
            // Cotizaciones_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.dirigirA_groupBox);
            this.Controls.Add(this.fechaRealizacion_label);
            this.Controls.Add(this.sae_label);
            this.Controls.Add(this.proveedor_label);
            this.Controls.Add(this.rfc_label);
            this.Controls.Add(this.giro_textBox);
            this.Controls.Add(this.empresa_textBox);
            this.Controls.Add(this.direccion_textBox);
            this.Controls.Add(this.planta_comboBox);
            this.Controls.Add(this.planta_label);
            this.Controls.Add(this.razonSocial_comboBox);
            this.Controls.Add(this.razonSocial_label);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cotizaciones_vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cotizaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cotizaciones_vista_FormClosed);
            this.Load += new System.EventHandler(this.Cotizaciones_vista_Load);
            this.dirigirA_groupBox.ResumeLayout(false);
            this.dirigirA_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label razonSocial_label;
        private System.Windows.Forms.ComboBox razonSocial_comboBox;
        private System.Windows.Forms.Label planta_label;
        private System.Windows.Forms.ComboBox planta_comboBox;
        private System.Windows.Forms.TextBox direccion_textBox;
        private System.Windows.Forms.TextBox empresa_textBox;
        private System.Windows.Forms.TextBox giro_textBox;
        private System.Windows.Forms.Label rfc_label;
        private System.Windows.Forms.Label proveedor_label;
        private System.Windows.Forms.Label sae_label;
        private System.Windows.Forms.Label fechaRealizacion_label;
        private System.Windows.Forms.GroupBox dirigirA_groupBox;
        private System.Windows.Forms.Label nombreDirigirA_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label puestoDirigirA_label;
    }
}