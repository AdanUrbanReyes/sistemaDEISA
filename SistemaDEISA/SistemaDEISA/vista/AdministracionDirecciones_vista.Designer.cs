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
            this.direccion_groupBox = new System.Windows.Forms.GroupBox();
            this.numeroInterior_textBox = new System.Windows.Forms.TextBox();
            this.numeroInterior_label = new System.Windows.Forms.Label();
            this.numeroExterior_textBox = new System.Windows.Forms.TextBox();
            this.numeroExterior_label = new System.Windows.Forms.Label();
            this.idCodigoPostal_textBox = new System.Windows.Forms.TextBox();
            this.idCodigoPostal_label = new System.Windows.Forms.Label();
            this.codigoPostal_textBox = new System.Windows.Forms.TextBox();
            this.colonia_label = new System.Windows.Forms.Label();
            this.calle_label = new System.Windows.Forms.Label();
            this.calle_textBox = new System.Windows.Forms.TextBox();
            this.asentamiento_comboBox = new System.Windows.Forms.ComboBox();
            this.municipio_comboBox = new System.Windows.Forms.ComboBox();
            this.estado_comboBox = new System.Windows.Forms.ComboBox();
            this.municipio_label = new System.Windows.Forms.Label();
            this.estado_label = new System.Windows.Forms.Label();
            this.codigoPostal_label = new System.Windows.Forms.Label();
            this.buscar_button = new System.Windows.Forms.Button();
            this.guardar_button = new System.Windows.Forms.Button();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.direcciones_listView = new System.Windows.Forms.ListView();
            this.codigoPostal_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.municipio_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.asentamiento_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calle_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeroExterior_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeroInterior_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.direccion_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // direccion_groupBox
            // 
            this.direccion_groupBox.Controls.Add(this.numeroInterior_textBox);
            this.direccion_groupBox.Controls.Add(this.numeroInterior_label);
            this.direccion_groupBox.Controls.Add(this.numeroExterior_textBox);
            this.direccion_groupBox.Controls.Add(this.numeroExterior_label);
            this.direccion_groupBox.Controls.Add(this.idCodigoPostal_textBox);
            this.direccion_groupBox.Controls.Add(this.idCodigoPostal_label);
            this.direccion_groupBox.Controls.Add(this.codigoPostal_textBox);
            this.direccion_groupBox.Controls.Add(this.colonia_label);
            this.direccion_groupBox.Controls.Add(this.calle_label);
            this.direccion_groupBox.Controls.Add(this.calle_textBox);
            this.direccion_groupBox.Controls.Add(this.asentamiento_comboBox);
            this.direccion_groupBox.Controls.Add(this.municipio_comboBox);
            this.direccion_groupBox.Controls.Add(this.estado_comboBox);
            this.direccion_groupBox.Controls.Add(this.municipio_label);
            this.direccion_groupBox.Controls.Add(this.estado_label);
            this.direccion_groupBox.Controls.Add(this.codigoPostal_label);
            this.direccion_groupBox.Location = new System.Drawing.Point(12, 12);
            this.direccion_groupBox.Name = "direccion_groupBox";
            this.direccion_groupBox.Size = new System.Drawing.Size(460, 263);
            this.direccion_groupBox.TabIndex = 0;
            this.direccion_groupBox.TabStop = false;
            this.direccion_groupBox.Text = "Direccion";
            // 
            // numeroInterior_textBox
            // 
            this.numeroInterior_textBox.Location = new System.Drawing.Point(6, 233);
            this.numeroInterior_textBox.MaxLength = 11;
            this.numeroInterior_textBox.Name = "numeroInterior_textBox";
            this.numeroInterior_textBox.Size = new System.Drawing.Size(120, 23);
            this.numeroInterior_textBox.TabIndex = 13;
            // 
            // numeroInterior_label
            // 
            this.numeroInterior_label.AutoSize = true;
            this.numeroInterior_label.Location = new System.Drawing.Point(3, 213);
            this.numeroInterior_label.Name = "numeroInterior_label";
            this.numeroInterior_label.Size = new System.Drawing.Size(83, 17);
            this.numeroInterior_label.TabIndex = 0;
            this.numeroInterior_label.Text = "No. Interior:";
            // 
            // numeroExterior_textBox
            // 
            this.numeroExterior_textBox.Location = new System.Drawing.Point(312, 184);
            this.numeroExterior_textBox.MaxLength = 11;
            this.numeroExterior_textBox.Name = "numeroExterior_textBox";
            this.numeroExterior_textBox.Size = new System.Drawing.Size(115, 23);
            this.numeroExterior_textBox.TabIndex = 12;
            // 
            // numeroExterior_label
            // 
            this.numeroExterior_label.AutoSize = true;
            this.numeroExterior_label.Location = new System.Drawing.Point(309, 163);
            this.numeroExterior_label.Name = "numeroExterior_label";
            this.numeroExterior_label.Size = new System.Drawing.Size(85, 17);
            this.numeroExterior_label.TabIndex = 14;
            this.numeroExterior_label.Text = "No. Exterior:";
            // 
            // idCodigoPostal_textBox
            // 
            this.idCodigoPostal_textBox.Location = new System.Drawing.Point(117, 131);
            this.idCodigoPostal_textBox.MaxLength = 7;
            this.idCodigoPostal_textBox.Name = "idCodigoPostal_textBox";
            this.idCodigoPostal_textBox.ReadOnly = true;
            this.idCodigoPostal_textBox.Size = new System.Drawing.Size(100, 23);
            this.idCodigoPostal_textBox.TabIndex = 7;
            // 
            // idCodigoPostal_label
            // 
            this.idCodigoPostal_label.AutoSize = true;
            this.idCodigoPostal_label.Location = new System.Drawing.Point(86, 134);
            this.idCodigoPostal_label.Name = "idCodigoPostal_label";
            this.idCodigoPostal_label.Size = new System.Drawing.Size(25, 17);
            this.idCodigoPostal_label.TabIndex = 9;
            this.idCodigoPostal_label.Text = "ID:";
            // 
            // codigoPostal_textBox
            // 
            this.codigoPostal_textBox.Location = new System.Drawing.Point(333, 131);
            this.codigoPostal_textBox.MaxLength = 6;
            this.codigoPostal_textBox.Name = "codigoPostal_textBox";
            this.codigoPostal_textBox.ReadOnly = true;
            this.codigoPostal_textBox.Size = new System.Drawing.Size(95, 23);
            this.codigoPostal_textBox.TabIndex = 8;
            // 
            // colonia_label
            // 
            this.colonia_label.AutoSize = true;
            this.colonia_label.Location = new System.Drawing.Point(9, 103);
            this.colonia_label.Name = "colonia_label";
            this.colonia_label.Size = new System.Drawing.Size(102, 17);
            this.colonia_label.TabIndex = 6;
            this.colonia_label.Text = "Asentamiento:";
            // 
            // calle_label
            // 
            this.calle_label.AutoSize = true;
            this.calle_label.Location = new System.Drawing.Point(3, 163);
            this.calle_label.Name = "calle_label";
            this.calle_label.Size = new System.Drawing.Size(168, 17);
            this.calle_label.TabIndex = 15;
            this.calle_label.Text = "Calle/Avenida/Calzada:";
            // 
            // calle_textBox
            // 
            this.calle_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.calle_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.calle_textBox.Location = new System.Drawing.Point(6, 183);
            this.calle_textBox.MaxLength = 100;
            this.calle_textBox.Name = "calle_textBox";
            this.calle_textBox.Size = new System.Drawing.Size(289, 23);
            this.calle_textBox.TabIndex = 11;
            // 
            // asentamiento_comboBox
            // 
            this.asentamiento_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.asentamiento_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.asentamiento_comboBox.FormattingEnabled = true;
            this.asentamiento_comboBox.Location = new System.Drawing.Point(117, 100);
            this.asentamiento_comboBox.MaxLength = 100;
            this.asentamiento_comboBox.Name = "asentamiento_comboBox";
            this.asentamiento_comboBox.Size = new System.Drawing.Size(311, 25);
            this.asentamiento_comboBox.TabIndex = 5;
            this.asentamiento_comboBox.Enter += new System.EventHandler(this.asentamiento_comboBox_Enter);
            this.asentamiento_comboBox.Leave += new System.EventHandler(this.asentamiento_comboBox_Leave);
            // 
            // municipio_comboBox
            // 
            this.municipio_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.municipio_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.municipio_comboBox.FormattingEnabled = true;
            this.municipio_comboBox.Location = new System.Drawing.Point(117, 62);
            this.municipio_comboBox.MaxLength = 100;
            this.municipio_comboBox.Name = "municipio_comboBox";
            this.municipio_comboBox.Size = new System.Drawing.Size(311, 25);
            this.municipio_comboBox.TabIndex = 3;
            this.municipio_comboBox.Enter += new System.EventHandler(this.municipio_comboBox_Enter);
            this.municipio_comboBox.Leave += new System.EventHandler(this.municipio_comboBox_Leave);
            // 
            // estado_comboBox
            // 
            this.estado_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estado_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado_comboBox.FormattingEnabled = true;
            this.estado_comboBox.Location = new System.Drawing.Point(117, 22);
            this.estado_comboBox.MaxLength = 100;
            this.estado_comboBox.Name = "estado_comboBox";
            this.estado_comboBox.Size = new System.Drawing.Size(311, 25);
            this.estado_comboBox.TabIndex = 1;
            this.estado_comboBox.Enter += new System.EventHandler(this.estado_comboBox_Enter);
            this.estado_comboBox.Leave += new System.EventHandler(this.estado_comboBox_Leave);
            // 
            // municipio_label
            // 
            this.municipio_label.AutoSize = true;
            this.municipio_label.Location = new System.Drawing.Point(37, 65);
            this.municipio_label.Name = "municipio_label";
            this.municipio_label.Size = new System.Drawing.Size(74, 17);
            this.municipio_label.TabIndex = 4;
            this.municipio_label.Text = "Municipio:";
            // 
            // estado_label
            // 
            this.estado_label.AutoSize = true;
            this.estado_label.Location = new System.Drawing.Point(55, 25);
            this.estado_label.Name = "estado_label";
            this.estado_label.Size = new System.Drawing.Size(56, 17);
            this.estado_label.TabIndex = 2;
            this.estado_label.Text = "Estado:";
            // 
            // codigoPostal_label
            // 
            this.codigoPostal_label.AutoSize = true;
            this.codigoPostal_label.Location = new System.Drawing.Point(221, 134);
            this.codigoPostal_label.Name = "codigoPostal_label";
            this.codigoPostal_label.Size = new System.Drawing.Size(106, 17);
            this.codigoPostal_label.TabIndex = 10;
            this.codigoPostal_label.Text = "Codigo postal:";
            // 
            // buscar_button
            // 
            this.buscar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.buscar;
            this.buscar_button.Location = new System.Drawing.Point(299, 407);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(48, 48);
            this.buscar_button.TabIndex = 8;
            this.buscar_button.UseVisualStyleBackColor = true;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // guardar_button
            // 
            this.guardar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.guardar;
            this.guardar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardar_button.Location = new System.Drawing.Point(353, 407);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(48, 48);
            this.guardar_button.TabIndex = 9;
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // eliminar_button
            // 
            this.eliminar_button.BackgroundImage = global::SistemaDEISA.Properties.Resources.eliminar;
            this.eliminar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar_button.Location = new System.Drawing.Point(407, 407);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(48, 48);
            this.eliminar_button.TabIndex = 11;
            this.eliminar_button.UseVisualStyleBackColor = true;
            this.eliminar_button.Click += new System.EventHandler(this.eliminar_button_Click);
            // 
            // direcciones_listView
            // 
            this.direcciones_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigoPostal_columnHeader,
            this.estado_columnHeader,
            this.municipio_columnHeader,
            this.asentamiento_columnHeader,
            this.calle_columnHeader,
            this.numeroExterior_columnHeader,
            this.numeroInterior_columnHeader});
            this.direcciones_listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.direcciones_listView.FullRowSelect = true;
            this.direcciones_listView.GridLines = true;
            this.direcciones_listView.Location = new System.Drawing.Point(13, 281);
            this.direcciones_listView.Name = "direcciones_listView";
            this.direcciones_listView.Size = new System.Drawing.Size(459, 120);
            this.direcciones_listView.TabIndex = 12;
            this.direcciones_listView.UseCompatibleStateImageBehavior = false;
            this.direcciones_listView.View = System.Windows.Forms.View.Details;
            // 
            // codigoPostal_columnHeader
            // 
            this.codigoPostal_columnHeader.Text = "Codigo postal";
            // 
            // estado_columnHeader
            // 
            this.estado_columnHeader.Text = "Estado";
            this.estado_columnHeader.Width = 150;
            // 
            // municipio_columnHeader
            // 
            this.municipio_columnHeader.Text = "Municipio";
            this.municipio_columnHeader.Width = 150;
            // 
            // asentamiento_columnHeader
            // 
            this.asentamiento_columnHeader.Text = "Asentamiento";
            this.asentamiento_columnHeader.Width = 150;
            // 
            // calle_columnHeader
            // 
            this.calle_columnHeader.Text = "Calle";
            this.calle_columnHeader.Width = 150;
            // 
            // numeroExterior_columnHeader
            // 
            this.numeroExterior_columnHeader.Text = "Numero Exterior";
            // 
            // numeroInterior_columnHeader
            // 
            this.numeroInterior_columnHeader.Text = "Numero Interior";
            // 
            // AdministracionDirecciones_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.direcciones_listView);
            this.Controls.Add(this.eliminar_button);
            this.Controls.Add(this.guardar_button);
            this.Controls.Add(this.buscar_button);
            this.Controls.Add(this.direccion_groupBox);
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
            this.direccion_groupBox.ResumeLayout(false);
            this.direccion_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox direccion_groupBox;
        private System.Windows.Forms.Label codigoPostal_label;
        private System.Windows.Forms.TextBox calle_textBox;
        private System.Windows.Forms.Label calle_label;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.Label estado_label;
        private System.Windows.Forms.Label municipio_label;
        private System.Windows.Forms.ComboBox estado_comboBox;
        private System.Windows.Forms.ComboBox municipio_comboBox;
        private System.Windows.Forms.Label colonia_label;
        private System.Windows.Forms.ComboBox asentamiento_comboBox;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.ListView direcciones_listView;
        private System.Windows.Forms.ColumnHeader codigoPostal_columnHeader;
        private System.Windows.Forms.ColumnHeader estado_columnHeader;
        private System.Windows.Forms.ColumnHeader municipio_columnHeader;
        private System.Windows.Forms.ColumnHeader asentamiento_columnHeader;
        private System.Windows.Forms.ColumnHeader calle_columnHeader;
        private System.Windows.Forms.TextBox codigoPostal_textBox;
        private System.Windows.Forms.Label idCodigoPostal_label;
        private System.Windows.Forms.TextBox idCodigoPostal_textBox;
        private System.Windows.Forms.TextBox numeroExterior_textBox;
        private System.Windows.Forms.Label numeroExterior_label;
        private System.Windows.Forms.Label numeroInterior_label;
        private System.Windows.Forms.TextBox numeroInterior_textBox;
        private System.Windows.Forms.ColumnHeader numeroExterior_columnHeader;
        private System.Windows.Forms.ColumnHeader numeroInterior_columnHeader;
    }
}