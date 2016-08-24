namespace SistemaDEISA.vista
{
    partial class AdministracionDirecciones_vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionDirecciones_vista));
            this.codigoPostal_groupBox = new System.Windows.Forms.GroupBox();
            this.codigoPostal_label = new System.Windows.Forms.Label();
            this.direccion_groupBox = new System.Windows.Forms.GroupBox();
            this.id_label = new System.Windows.Forms.Label();
            this.buscar_button = new System.Windows.Forms.Button();
            this.calle_label = new System.Windows.Forms.Label();
            this.calle_textBox = new System.Windows.Forms.TextBox();
            this.guardar_button = new System.Windows.Forms.Button();
            this.numeroExterior_label = new System.Windows.Forms.Label();
            this.numeroExterior_textBox = new System.Windows.Forms.TextBox();
            this.estado_label = new System.Windows.Forms.Label();
            this.municipio_label = new System.Windows.Forms.Label();
            this.id_comboBox = new System.Windows.Forms.ComboBox();
            this.codigoPostal_comboBox = new System.Windows.Forms.ComboBox();
            this.estado_comboBox = new System.Windows.Forms.ComboBox();
            this.municipio_comboBox = new System.Windows.Forms.ComboBox();
            this.colonia_comboBox = new System.Windows.Forms.ComboBox();
            this.colonia_label = new System.Windows.Forms.Label();
            this.modificar_button = new System.Windows.Forms.Button();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.codigoPostal_groupBox.SuspendLayout();
            this.direccion_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoPostal_groupBox
            // 
            this.codigoPostal_groupBox.Controls.Add(this.colonia_label);
            this.codigoPostal_groupBox.Controls.Add(this.colonia_comboBox);
            this.codigoPostal_groupBox.Controls.Add(this.municipio_comboBox);
            this.codigoPostal_groupBox.Controls.Add(this.estado_comboBox);
            this.codigoPostal_groupBox.Controls.Add(this.codigoPostal_comboBox);
            this.codigoPostal_groupBox.Controls.Add(this.municipio_label);
            this.codigoPostal_groupBox.Controls.Add(this.estado_label);
            this.codigoPostal_groupBox.Controls.Add(this.codigoPostal_label);
            this.codigoPostal_groupBox.Location = new System.Drawing.Point(12, 152);
            this.codigoPostal_groupBox.Name = "codigoPostal_groupBox";
            this.codigoPostal_groupBox.Size = new System.Drawing.Size(460, 213);
            this.codigoPostal_groupBox.TabIndex = 0;
            this.codigoPostal_groupBox.TabStop = false;
            this.codigoPostal_groupBox.Text = "Codigo postal";
            // 
            // codigoPostal_label
            // 
            this.codigoPostal_label.AutoSize = true;
            this.codigoPostal_label.Location = new System.Drawing.Point(108, 43);
            this.codigoPostal_label.Name = "codigoPostal_label";
            this.codigoPostal_label.Size = new System.Drawing.Size(106, 17);
            this.codigoPostal_label.TabIndex = 0;
            this.codigoPostal_label.Text = "Codigo postal:";
            // 
            // direccion_groupBox
            // 
            this.direccion_groupBox.Controls.Add(this.id_comboBox);
            this.direccion_groupBox.Controls.Add(this.numeroExterior_textBox);
            this.direccion_groupBox.Controls.Add(this.numeroExterior_label);
            this.direccion_groupBox.Controls.Add(this.calle_textBox);
            this.direccion_groupBox.Controls.Add(this.calle_label);
            this.direccion_groupBox.Controls.Add(this.buscar_button);
            this.direccion_groupBox.Controls.Add(this.id_label);
            this.direccion_groupBox.Location = new System.Drawing.Point(12, 3);
            this.direccion_groupBox.Name = "direccion_groupBox";
            this.direccion_groupBox.Size = new System.Drawing.Size(460, 132);
            this.direccion_groupBox.TabIndex = 1;
            this.direccion_groupBox.TabStop = false;
            this.direccion_groupBox.Text = "Direccion";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(166, 36);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(25, 17);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "ID:";
            // 
            // buscar_button
            // 
            this.buscar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.buscar;
            this.buscar_button.Location = new System.Drawing.Point(112, 20);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(48, 48);
            this.buscar_button.TabIndex = 2;
            this.buscar_button.UseVisualStyleBackColor = true;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // calle_label
            // 
            this.calle_label.AutoSize = true;
            this.calle_label.Location = new System.Drawing.Point(6, 74);
            this.calle_label.Name = "calle_label";
            this.calle_label.Size = new System.Drawing.Size(46, 17);
            this.calle_label.TabIndex = 3;
            this.calle_label.Text = "Calle:";
            // 
            // calle_textBox
            // 
            this.calle_textBox.Location = new System.Drawing.Point(9, 94);
            this.calle_textBox.MaxLength = 50;
            this.calle_textBox.Name = "calle_textBox";
            this.calle_textBox.Size = new System.Drawing.Size(257, 23);
            this.calle_textBox.TabIndex = 4;
            // 
            // guardar_button
            // 
            this.guardar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.guardar;
            this.guardar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardar_button.Location = new System.Drawing.Point(299, 371);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(48, 48);
            this.guardar_button.TabIndex = 2;
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // numeroExterior_label
            // 
            this.numeroExterior_label.AutoSize = true;
            this.numeroExterior_label.Location = new System.Drawing.Point(284, 74);
            this.numeroExterior_label.Name = "numeroExterior_label";
            this.numeroExterior_label.Size = new System.Drawing.Size(115, 17);
            this.numeroExterior_label.TabIndex = 5;
            this.numeroExterior_label.Text = "Numero exterior:";
            // 
            // numeroExterior_textBox
            // 
            this.numeroExterior_textBox.Location = new System.Drawing.Point(287, 94);
            this.numeroExterior_textBox.MaxLength = 10;
            this.numeroExterior_textBox.Name = "numeroExterior_textBox";
            this.numeroExterior_textBox.Size = new System.Drawing.Size(142, 23);
            this.numeroExterior_textBox.TabIndex = 6;
            // 
            // estado_label
            // 
            this.estado_label.AutoSize = true;
            this.estado_label.Location = new System.Drawing.Point(55, 85);
            this.estado_label.Name = "estado_label";
            this.estado_label.Size = new System.Drawing.Size(56, 17);
            this.estado_label.TabIndex = 2;
            this.estado_label.Text = "Estado:";
            // 
            // municipio_label
            // 
            this.municipio_label.AutoSize = true;
            this.municipio_label.Location = new System.Drawing.Point(37, 125);
            this.municipio_label.Name = "municipio_label";
            this.municipio_label.Size = new System.Drawing.Size(74, 17);
            this.municipio_label.TabIndex = 4;
            this.municipio_label.Text = "Municipio:";
            // 
            // id_comboBox
            // 
            this.id_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.id_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.id_comboBox.FormattingEnabled = true;
            this.id_comboBox.Location = new System.Drawing.Point(197, 33);
            this.id_comboBox.MaxLength = 10;
            this.id_comboBox.Name = "id_comboBox";
            this.id_comboBox.Size = new System.Drawing.Size(129, 25);
            this.id_comboBox.TabIndex = 7;
            // 
            // codigoPostal_comboBox
            // 
            this.codigoPostal_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.codigoPostal_comboBox.FormattingEnabled = true;
            this.codigoPostal_comboBox.Location = new System.Drawing.Point(220, 40);
            this.codigoPostal_comboBox.MaxLength = 10;
            this.codigoPostal_comboBox.Name = "codigoPostal_comboBox";
            this.codigoPostal_comboBox.Size = new System.Drawing.Size(130, 25);
            this.codigoPostal_comboBox.TabIndex = 5;
            // 
            // estado_comboBox
            // 
            this.estado_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estado_comboBox.FormattingEnabled = true;
            this.estado_comboBox.Location = new System.Drawing.Point(117, 82);
            this.estado_comboBox.MaxLength = 30;
            this.estado_comboBox.Name = "estado_comboBox";
            this.estado_comboBox.Size = new System.Drawing.Size(267, 25);
            this.estado_comboBox.TabIndex = 6;
            // 
            // municipio_comboBox
            // 
            this.municipio_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.municipio_comboBox.FormattingEnabled = true;
            this.municipio_comboBox.Location = new System.Drawing.Point(117, 122);
            this.municipio_comboBox.MaxLength = 30;
            this.municipio_comboBox.Name = "municipio_comboBox";
            this.municipio_comboBox.Size = new System.Drawing.Size(267, 25);
            this.municipio_comboBox.TabIndex = 7;
            // 
            // colonia_comboBox
            // 
            this.colonia_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colonia_comboBox.FormattingEnabled = true;
            this.colonia_comboBox.Location = new System.Drawing.Point(117, 160);
            this.colonia_comboBox.MaxLength = 30;
            this.colonia_comboBox.Name = "colonia_comboBox";
            this.colonia_comboBox.Size = new System.Drawing.Size(267, 25);
            this.colonia_comboBox.TabIndex = 8;
            this.colonia_comboBox.SelectedIndexChanged += new System.EventHandler(this.colonia_comboBox_SelectedIndexChanged);
            // 
            // colonia_label
            // 
            this.colonia_label.AutoSize = true;
            this.colonia_label.Location = new System.Drawing.Point(47, 163);
            this.colonia_label.Name = "colonia_label";
            this.colonia_label.Size = new System.Drawing.Size(64, 17);
            this.colonia_label.TabIndex = 9;
            this.colonia_label.Text = "Colonia:";
            // 
            // modificar_button
            // 
            this.modificar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.modificar;
            this.modificar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modificar_button.Location = new System.Drawing.Point(353, 371);
            this.modificar_button.Name = "modificar_button";
            this.modificar_button.Size = new System.Drawing.Size(48, 48);
            this.modificar_button.TabIndex = 3;
            this.modificar_button.UseVisualStyleBackColor = true;
            this.modificar_button.Click += new System.EventHandler(this.modificar_button_Click);
            // 
            // eliminar_button
            // 
            this.eliminar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.eliminar;
            this.eliminar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar_button.Location = new System.Drawing.Point(407, 371);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(48, 48);
            this.eliminar_button.TabIndex = 4;
            this.eliminar_button.UseVisualStyleBackColor = true;
            // 
            // AdministracionDirecciones_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 431);
            this.Controls.Add(this.eliminar_button);
            this.Controls.Add(this.modificar_button);
            this.Controls.Add(this.guardar_button);
            this.Controls.Add(this.direccion_groupBox);
            this.Controls.Add(this.codigoPostal_groupBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AdministracionDirecciones_vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administracion Direcciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministracionDirecciones_vista_FormClosed);
            this.Load += new System.EventHandler(this.AdministracionDirecciones_vista_Load);
            this.codigoPostal_groupBox.ResumeLayout(false);
            this.codigoPostal_groupBox.PerformLayout();
            this.direccion_groupBox.ResumeLayout(false);
            this.direccion_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox codigoPostal_groupBox;
        private System.Windows.Forms.Label codigoPostal_label;
        private System.Windows.Forms.GroupBox direccion_groupBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox calle_textBox;
        private System.Windows.Forms.Label calle_label;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Label numeroExterior_label;
        private System.Windows.Forms.TextBox numeroExterior_textBox;
        private System.Windows.Forms.Label estado_label;
        private System.Windows.Forms.Label municipio_label;
        private System.Windows.Forms.ComboBox id_comboBox;
        private System.Windows.Forms.ComboBox codigoPostal_comboBox;
        private System.Windows.Forms.ComboBox estado_comboBox;
        private System.Windows.Forms.ComboBox municipio_comboBox;
        private System.Windows.Forms.Label colonia_label;
        private System.Windows.Forms.ComboBox colonia_comboBox;
        private System.Windows.Forms.Button modificar_button;
        private System.Windows.Forms.Button eliminar_button;
    }
}