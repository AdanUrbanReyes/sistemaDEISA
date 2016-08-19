namespace SistemaDEISA.vista
{
    partial class UsuarioAccesaMenu_vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioAccesaMenu_vista));
            this.cuenta_comboBox = new System.Windows.Forms.ComboBox();
            this.cuenta_label = new System.Windows.Forms.Label();
            this.nombreCompleto_label = new System.Windows.Forms.Label();
            this.estatus_label = new System.Windows.Forms.Label();
            this.departamento_label = new System.Windows.Forms.Label();
            this.puesto_label = new System.Windows.Forms.Label();
            this.buscar_button = new System.Windows.Forms.Button();
            this.ejecutar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cuenta_comboBox
            // 
            this.cuenta_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cuenta_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuenta_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuenta_comboBox.FormattingEnabled = true;
            this.cuenta_comboBox.Location = new System.Drawing.Point(155, 22);
            this.cuenta_comboBox.MaxLength = 45;
            this.cuenta_comboBox.Name = "cuenta_comboBox";
            this.cuenta_comboBox.Size = new System.Drawing.Size(300, 25);
            this.cuenta_comboBox.TabIndex = 0;
            // 
            // cuenta_label
            // 
            this.cuenta_label.AutoSize = true;
            this.cuenta_label.Location = new System.Drawing.Point(88, 25);
            this.cuenta_label.Name = "cuenta_label";
            this.cuenta_label.Size = new System.Drawing.Size(61, 17);
            this.cuenta_label.TabIndex = 1;
            this.cuenta_label.Text = "Cuenta:";
            // 
            // nombreCompleto_label
            // 
            this.nombreCompleto_label.AutoSize = true;
            this.nombreCompleto_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.nombreCompleto_label.Location = new System.Drawing.Point(36, 67);
            this.nombreCompleto_label.Name = "nombreCompleto_label";
            this.nombreCompleto_label.Size = new System.Drawing.Size(203, 17);
            this.nombreCompleto_label.TabIndex = 2;
            this.nombreCompleto_label.Text = "Nombre completo del usuario";
            // 
            // estatus_label
            // 
            this.estatus_label.AutoSize = true;
            this.estatus_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.estatus_label.Location = new System.Drawing.Point(366, 67);
            this.estatus_label.Name = "estatus_label";
            this.estatus_label.Size = new System.Drawing.Size(52, 17);
            this.estatus_label.TabIndex = 3;
            this.estatus_label.Text = "Estatus";
            // 
            // departamento_label
            // 
            this.departamento_label.AutoSize = true;
            this.departamento_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.departamento_label.Location = new System.Drawing.Point(36, 93);
            this.departamento_label.Name = "departamento_label";
            this.departamento_label.Size = new System.Drawing.Size(105, 17);
            this.departamento_label.TabIndex = 4;
            this.departamento_label.Text = "Departamento";
            // 
            // puesto_label
            // 
            this.puesto_label.AutoSize = true;
            this.puesto_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.puesto_label.Location = new System.Drawing.Point(366, 93);
            this.puesto_label.Name = "puesto_label";
            this.puesto_label.Size = new System.Drawing.Size(51, 17);
            this.puesto_label.TabIndex = 5;
            this.puesto_label.Text = "Puesto";
            // 
            // buscar_button
            // 
            this.buscar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.buscar;
            this.buscar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar_button.Location = new System.Drawing.Point(25, 9);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(48, 48);
            this.buscar_button.TabIndex = 6;
            this.buscar_button.UseVisualStyleBackColor = true;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // ejecutar_button
            // 
            this.ejecutar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.hacer;
            this.ejecutar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ejecutar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ejecutar_button.Location = new System.Drawing.Point(407, 371);
            this.ejecutar_button.Name = "ejecutar_button";
            this.ejecutar_button.Size = new System.Drawing.Size(48, 48);
            this.ejecutar_button.TabIndex = 7;
            this.ejecutar_button.UseVisualStyleBackColor = true;
            // 
            // UsuarioAccesaMenu_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(484, 431);
            this.Controls.Add(this.ejecutar_button);
            this.Controls.Add(this.buscar_button);
            this.Controls.Add(this.puesto_label);
            this.Controls.Add(this.departamento_label);
            this.Controls.Add(this.estatus_label);
            this.Controls.Add(this.nombreCompleto_label);
            this.Controls.Add(this.cuenta_label);
            this.Controls.Add(this.cuenta_comboBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "UsuarioAccesaMenu_vista";
            this.Text = "Control de accesos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsuarioAccesaMenu_vista_FormClosed);
            this.Load += new System.EventHandler(this.UsuarioAccesaMenu_vista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cuenta_comboBox;
        private System.Windows.Forms.Label cuenta_label;
        private System.Windows.Forms.Label nombreCompleto_label;
        private System.Windows.Forms.Label estatus_label;
        private System.Windows.Forms.Label departamento_label;
        private System.Windows.Forms.Label puesto_label;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.Button ejecutar_button;
    }
}