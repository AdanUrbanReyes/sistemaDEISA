namespace SistemaDEISA.vista
{
    partial class AdministracionUsuarios_vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionUsuarios_vista));
            this.clave_label = new System.Windows.Forms.Label();
            this.cuenta_comboBox = new System.Windows.Forms.ComboBox();
            this.clave_textBox = new System.Windows.Forms.TextBox();
            this.nombres_textBox = new System.Windows.Forms.TextBox();
            this.agregar_button = new System.Windows.Forms.Button();
            this.modificar_button = new System.Windows.Forms.Button();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.nombres_label = new System.Windows.Forms.Label();
            this.primerApellido_label = new System.Windows.Forms.Label();
            this.segundoApellido_label = new System.Windows.Forms.Label();
            this.primerApellido_textBox = new System.Windows.Forms.TextBox();
            this.segundoApellido_textBox = new System.Windows.Forms.TextBox();
            this.estatus_comboBox = new System.Windows.Forms.ComboBox();
            this.estatus_label = new System.Windows.Forms.Label();
            this.inicio_label = new System.Windows.Forms.Label();
            this.fechaInicio_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departamento_label = new System.Windows.Forms.Label();
            this.departamento_comboBox = new System.Windows.Forms.ComboBox();
            this.puesto_label = new System.Windows.Forms.Label();
            this.puesto_comboBox = new System.Windows.Forms.ComboBox();
            this.buscar_button = new System.Windows.Forms.Button();
            this.cuenta_label = new System.Windows.Forms.Label();
            this.cargarFoto_button = new System.Windows.Forms.Button();
            this.imagenPerfil_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPerfil_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clave_label
            // 
            this.clave_label.AutoSize = true;
            this.clave_label.Location = new System.Drawing.Point(38, 66);
            this.clave_label.Name = "clave_label";
            this.clave_label.Size = new System.Drawing.Size(55, 17);
            this.clave_label.TabIndex = 0;
            this.clave_label.Text = "Clave: ";
            // 
            // cuenta_comboBox
            // 
            this.cuenta_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cuenta_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cuenta_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuenta_comboBox.FormattingEnabled = true;
            this.cuenta_comboBox.Location = new System.Drawing.Point(88, 27);
            this.cuenta_comboBox.MaxLength = 45;
            this.cuenta_comboBox.Name = "cuenta_comboBox";
            this.cuenta_comboBox.Size = new System.Drawing.Size(314, 25);
            this.cuenta_comboBox.TabIndex = 0;
            // 
            // clave_textBox
            // 
            this.clave_textBox.Location = new System.Drawing.Point(41, 86);
            this.clave_textBox.MaxLength = 45;
            this.clave_textBox.Name = "clave_textBox";
            this.clave_textBox.PasswordChar = '*';
            this.clave_textBox.Size = new System.Drawing.Size(185, 23);
            this.clave_textBox.TabIndex = 1;
            // 
            // nombres_textBox
            // 
            this.nombres_textBox.Location = new System.Drawing.Point(255, 86);
            this.nombres_textBox.MaxLength = 30;
            this.nombres_textBox.Name = "nombres_textBox";
            this.nombres_textBox.Size = new System.Drawing.Size(185, 23);
            this.nombres_textBox.TabIndex = 2;
            // 
            // agregar_button
            // 
            this.agregar_button.BackColor = System.Drawing.Color.Transparent;
            this.agregar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.guardar;
            this.agregar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregar_button.Location = new System.Drawing.Point(316, 369);
            this.agregar_button.Name = "agregar_button";
            this.agregar_button.Size = new System.Drawing.Size(48, 48);
            this.agregar_button.TabIndex = 10;
            this.agregar_button.UseVisualStyleBackColor = false;
            this.agregar_button.Click += new System.EventHandler(this.agregar_button_Click);
            // 
            // modificar_button
            // 
            this.modificar_button.BackColor = System.Drawing.Color.Transparent;
            this.modificar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.modificar;
            this.modificar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modificar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificar_button.Location = new System.Drawing.Point(370, 369);
            this.modificar_button.Name = "modificar_button";
            this.modificar_button.Size = new System.Drawing.Size(48, 48);
            this.modificar_button.TabIndex = 11;
            this.modificar_button.UseVisualStyleBackColor = false;
            this.modificar_button.Click += new System.EventHandler(this.modificar_button_Click);
            // 
            // eliminar_button
            // 
            this.eliminar_button.BackColor = System.Drawing.Color.Transparent;
            this.eliminar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.eliminar;
            this.eliminar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar_button.Location = new System.Drawing.Point(424, 369);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(48, 48);
            this.eliminar_button.TabIndex = 12;
            this.eliminar_button.UseVisualStyleBackColor = false;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // nombres_label
            // 
            this.nombres_label.AutoSize = true;
            this.nombres_label.Location = new System.Drawing.Point(252, 66);
            this.nombres_label.Name = "nombres_label";
            this.nombres_label.Size = new System.Drawing.Size(79, 17);
            this.nombres_label.TabIndex = 7;
            this.nombres_label.Text = "Nombre(s):";
            // 
            // primerApellido_label
            // 
            this.primerApellido_label.AutoSize = true;
            this.primerApellido_label.Location = new System.Drawing.Point(38, 127);
            this.primerApellido_label.Name = "primerApellido_label";
            this.primerApellido_label.Size = new System.Drawing.Size(109, 17);
            this.primerApellido_label.TabIndex = 8;
            this.primerApellido_label.Text = "Primer apellido:";
            // 
            // segundoApellido_label
            // 
            this.segundoApellido_label.AutoSize = true;
            this.segundoApellido_label.Location = new System.Drawing.Point(252, 127);
            this.segundoApellido_label.Name = "segundoApellido_label";
            this.segundoApellido_label.Size = new System.Drawing.Size(126, 17);
            this.segundoApellido_label.TabIndex = 9;
            this.segundoApellido_label.Text = "Segundo apellido:";
            // 
            // primerApellido_textBox
            // 
            this.primerApellido_textBox.Location = new System.Drawing.Point(40, 147);
            this.primerApellido_textBox.MaxLength = 30;
            this.primerApellido_textBox.Name = "primerApellido_textBox";
            this.primerApellido_textBox.Size = new System.Drawing.Size(185, 23);
            this.primerApellido_textBox.TabIndex = 3;
            // 
            // segundoApellido_textBox
            // 
            this.segundoApellido_textBox.Location = new System.Drawing.Point(255, 148);
            this.segundoApellido_textBox.MaxLength = 30;
            this.segundoApellido_textBox.Name = "segundoApellido_textBox";
            this.segundoApellido_textBox.Size = new System.Drawing.Size(185, 23);
            this.segundoApellido_textBox.TabIndex = 4;
            // 
            // estatus_comboBox
            // 
            this.estatus_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.estatus_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.estatus_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estatus_comboBox.FormattingEnabled = true;
            this.estatus_comboBox.Location = new System.Drawing.Point(41, 209);
            this.estatus_comboBox.MaxLength = 1;
            this.estatus_comboBox.Name = "estatus_comboBox";
            this.estatus_comboBox.Size = new System.Drawing.Size(60, 25);
            this.estatus_comboBox.TabIndex = 5;
            // 
            // estatus_label
            // 
            this.estatus_label.AutoSize = true;
            this.estatus_label.Location = new System.Drawing.Point(38, 187);
            this.estatus_label.Name = "estatus_label";
            this.estatus_label.Size = new System.Drawing.Size(56, 17);
            this.estatus_label.TabIndex = 13;
            this.estatus_label.Text = "Estatus:";
            // 
            // inicio_label
            // 
            this.inicio_label.AutoSize = true;
            this.inicio_label.Location = new System.Drawing.Point(255, 187);
            this.inicio_label.Name = "inicio_label";
            this.inicio_label.Size = new System.Drawing.Size(89, 17);
            this.inicio_label.TabIndex = 14;
            this.inicio_label.Text = "Fecha inicio:";
            // 
            // fechaInicio_dateTimePicker
            // 
            this.fechaInicio_dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechaInicio_dateTimePicker.CustomFormat = "yyyy-MMMM-dd";
            this.fechaInicio_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicio_dateTimePicker.Location = new System.Drawing.Point(255, 207);
            this.fechaInicio_dateTimePicker.Name = "fechaInicio_dateTimePicker";
            this.fechaInicio_dateTimePicker.Size = new System.Drawing.Size(185, 23);
            this.fechaInicio_dateTimePicker.TabIndex = 6;
            // 
            // departamento_label
            // 
            this.departamento_label.AutoSize = true;
            this.departamento_label.Location = new System.Drawing.Point(38, 249);
            this.departamento_label.Name = "departamento_label";
            this.departamento_label.Size = new System.Drawing.Size(109, 17);
            this.departamento_label.TabIndex = 16;
            this.departamento_label.Text = "Departamento:";
            // 
            // departamento_comboBox
            // 
            this.departamento_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.departamento_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departamento_comboBox.FormattingEnabled = true;
            this.departamento_comboBox.Location = new System.Drawing.Point(41, 270);
            this.departamento_comboBox.MaxLength = 30;
            this.departamento_comboBox.Name = "departamento_comboBox";
            this.departamento_comboBox.Size = new System.Drawing.Size(185, 25);
            this.departamento_comboBox.TabIndex = 7;
            // 
            // puesto_label
            // 
            this.puesto_label.AutoSize = true;
            this.puesto_label.Location = new System.Drawing.Point(258, 249);
            this.puesto_label.Name = "puesto_label";
            this.puesto_label.Size = new System.Drawing.Size(55, 17);
            this.puesto_label.TabIndex = 18;
            this.puesto_label.Text = "Puesto:";
            // 
            // puesto_comboBox
            // 
            this.puesto_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.puesto_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.puesto_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.puesto_comboBox.FormattingEnabled = true;
            this.puesto_comboBox.Location = new System.Drawing.Point(255, 269);
            this.puesto_comboBox.MaxLength = 30;
            this.puesto_comboBox.Name = "puesto_comboBox";
            this.puesto_comboBox.Size = new System.Drawing.Size(185, 25);
            this.puesto_comboBox.TabIndex = 8;
            // 
            // buscar_button
            // 
            this.buscar_button.BackColor = System.Drawing.Color.Transparent;
            this.buscar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.buscar;
            this.buscar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar_button.Location = new System.Drawing.Point(34, 5);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(48, 48);
            this.buscar_button.TabIndex = 13;
            this.buscar_button.Tag = "";
            this.buscar_button.UseVisualStyleBackColor = false;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // cuenta_label
            // 
            this.cuenta_label.AutoSize = true;
            this.cuenta_label.Location = new System.Drawing.Point(88, 7);
            this.cuenta_label.Name = "cuenta_label";
            this.cuenta_label.Size = new System.Drawing.Size(61, 17);
            this.cuenta_label.TabIndex = 21;
            this.cuenta_label.Text = "Cuenta:";
            // 
            // cargarFoto_button
            // 
            this.cargarFoto_button.BackColor = System.Drawing.Color.Transparent;
            this.cargarFoto_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.camara;
            this.cargarFoto_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargarFoto_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargarFoto_button.Location = new System.Drawing.Point(38, 335);
            this.cargarFoto_button.Name = "cargarFoto_button";
            this.cargarFoto_button.Size = new System.Drawing.Size(55, 48);
            this.cargarFoto_button.TabIndex = 9;
            this.cargarFoto_button.UseVisualStyleBackColor = false;
            this.cargarFoto_button.Click += new System.EventHandler(this.cargarFoto_button_Click);
            // 
            // imagenPerfil_pictureBox
            // 
            this.imagenPerfil_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenPerfil_pictureBox.Location = new System.Drawing.Point(102, 310);
            this.imagenPerfil_pictureBox.Name = "imagenPerfil_pictureBox";
            this.imagenPerfil_pictureBox.Size = new System.Drawing.Size(185, 109);
            this.imagenPerfil_pictureBox.TabIndex = 23;
            this.imagenPerfil_pictureBox.TabStop = false;
            // 
            // AdministracionUsuarios_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(484, 431);
            this.Controls.Add(this.imagenPerfil_pictureBox);
            this.Controls.Add(this.cargarFoto_button);
            this.Controls.Add(this.cuenta_label);
            this.Controls.Add(this.buscar_button);
            this.Controls.Add(this.puesto_comboBox);
            this.Controls.Add(this.puesto_label);
            this.Controls.Add(this.departamento_comboBox);
            this.Controls.Add(this.departamento_label);
            this.Controls.Add(this.fechaInicio_dateTimePicker);
            this.Controls.Add(this.inicio_label);
            this.Controls.Add(this.estatus_label);
            this.Controls.Add(this.estatus_comboBox);
            this.Controls.Add(this.segundoApellido_textBox);
            this.Controls.Add(this.primerApellido_textBox);
            this.Controls.Add(this.segundoApellido_label);
            this.Controls.Add(this.primerApellido_label);
            this.Controls.Add(this.nombres_label);
            this.Controls.Add(this.eliminar_button);
            this.Controls.Add(this.modificar_button);
            this.Controls.Add(this.agregar_button);
            this.Controls.Add(this.nombres_textBox);
            this.Controls.Add(this.clave_textBox);
            this.Controls.Add(this.cuenta_comboBox);
            this.Controls.Add(this.clave_label);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AdministracionUsuarios_vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administracion Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministracionUsuarios_vista_FormClosed);
            this.Load += new System.EventHandler(this.AdministracionUsuarios_vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPerfil_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clave_label;
        private System.Windows.Forms.ComboBox cuenta_comboBox;
        private System.Windows.Forms.TextBox clave_textBox;
        private System.Windows.Forms.TextBox nombres_textBox;
        private System.Windows.Forms.Button agregar_button;
        private System.Windows.Forms.Button modificar_button;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.Label nombres_label;
        private System.Windows.Forms.Label primerApellido_label;
        private System.Windows.Forms.Label segundoApellido_label;
        private System.Windows.Forms.TextBox primerApellido_textBox;
        private System.Windows.Forms.TextBox segundoApellido_textBox;
        private System.Windows.Forms.ComboBox estatus_comboBox;
        private System.Windows.Forms.Label estatus_label;
        private System.Windows.Forms.Label inicio_label;
        private System.Windows.Forms.DateTimePicker fechaInicio_dateTimePicker;
        private System.Windows.Forms.Label departamento_label;
        private System.Windows.Forms.ComboBox departamento_comboBox;
        private System.Windows.Forms.Label puesto_label;
        private System.Windows.Forms.ComboBox puesto_comboBox;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.Label cuenta_label;
        private System.Windows.Forms.Button cargarFoto_button;
        private System.Windows.Forms.PictureBox imagenPerfil_pictureBox;
    }
}