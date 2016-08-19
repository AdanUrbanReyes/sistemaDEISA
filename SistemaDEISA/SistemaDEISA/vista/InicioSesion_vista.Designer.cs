namespace SistemaDEISA.vista
{
    partial class InicioSesion_vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion_vista));
            this.cuenta_label = new System.Windows.Forms.Label();
            this.clave_label = new System.Windows.Forms.Label();
            this.tarjeta_pictureBox = new System.Windows.Forms.PictureBox();
            this.cuenta_textBox = new System.Windows.Forms.TextBox();
            this.clave_textBox = new System.Windows.Forms.TextBox();
            this.tipoConexion_groupBox = new System.Windows.Forms.GroupBox();
            this.remota_radioButton = new System.Windows.Forms.RadioButton();
            this.local_radioButton = new System.Windows.Forms.RadioButton();
            this.iniciar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarjeta_pictureBox)).BeginInit();
            this.tipoConexion_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuenta_label
            // 
            this.cuenta_label.AutoSize = true;
            this.cuenta_label.BackColor = System.Drawing.Color.Transparent;
            this.cuenta_label.Location = new System.Drawing.Point(60, 172);
            this.cuenta_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cuenta_label.Name = "cuenta_label";
            this.cuenta_label.Size = new System.Drawing.Size(61, 17);
            this.cuenta_label.TabIndex = 0;
            this.cuenta_label.Text = "Cuenta:";
            // 
            // clave_label
            // 
            this.clave_label.AutoSize = true;
            this.clave_label.BackColor = System.Drawing.Color.Transparent;
            this.clave_label.Location = new System.Drawing.Point(70, 208);
            this.clave_label.Name = "clave_label";
            this.clave_label.Size = new System.Drawing.Size(51, 17);
            this.clave_label.TabIndex = 1;
            this.clave_label.Text = "Clave:";
            // 
            // tarjeta_pictureBox
            // 
            this.tarjeta_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.tarjeta_pictureBox.BackgroundImage = global::SistemaDEISA.Properties.Resources.tarjeta;
            this.tarjeta_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tarjeta_pictureBox.Location = new System.Drawing.Point(100, 10);
            this.tarjeta_pictureBox.Name = "tarjeta_pictureBox";
            this.tarjeta_pictureBox.Size = new System.Drawing.Size(150, 136);
            this.tarjeta_pictureBox.TabIndex = 2;
            this.tarjeta_pictureBox.TabStop = false;
            // 
            // cuenta_textBox
            // 
            this.cuenta_textBox.Location = new System.Drawing.Point(128, 169);
            this.cuenta_textBox.MaxLength = 45;
            this.cuenta_textBox.Name = "cuenta_textBox";
            this.cuenta_textBox.Size = new System.Drawing.Size(151, 23);
            this.cuenta_textBox.TabIndex = 3;
            this.cuenta_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cuenta_textBox_KeyDown);
            // 
            // clave_textBox
            // 
            this.clave_textBox.Location = new System.Drawing.Point(128, 205);
            this.clave_textBox.MaxLength = 45;
            this.clave_textBox.Name = "clave_textBox";
            this.clave_textBox.PasswordChar = '*';
            this.clave_textBox.Size = new System.Drawing.Size(151, 23);
            this.clave_textBox.TabIndex = 4;
            this.clave_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clave_textBox_KeyDown);
            // 
            // tipoConexion_groupBox
            // 
            this.tipoConexion_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.tipoConexion_groupBox.Controls.Add(this.remota_radioButton);
            this.tipoConexion_groupBox.Controls.Add(this.local_radioButton);
            this.tipoConexion_groupBox.Location = new System.Drawing.Point(44, 246);
            this.tipoConexion_groupBox.Name = "tipoConexion_groupBox";
            this.tipoConexion_groupBox.Size = new System.Drawing.Size(235, 86);
            this.tipoConexion_groupBox.TabIndex = 5;
            this.tipoConexion_groupBox.TabStop = false;
            this.tipoConexion_groupBox.Text = "Tipo de conexion";
            // 
            // remota_radioButton
            // 
            this.remota_radioButton.AutoSize = true;
            this.remota_radioButton.Location = new System.Drawing.Point(132, 39);
            this.remota_radioButton.Name = "remota_radioButton";
            this.remota_radioButton.Size = new System.Drawing.Size(78, 21);
            this.remota_radioButton.TabIndex = 1;
            this.remota_radioButton.Text = "Remota";
            this.remota_radioButton.UseVisualStyleBackColor = true;
            // 
            // local_radioButton
            // 
            this.local_radioButton.AutoSize = true;
            this.local_radioButton.Checked = true;
            this.local_radioButton.Location = new System.Drawing.Point(29, 39);
            this.local_radioButton.Name = "local_radioButton";
            this.local_radioButton.Size = new System.Drawing.Size(61, 21);
            this.local_radioButton.TabIndex = 0;
            this.local_radioButton.TabStop = true;
            this.local_radioButton.Text = "Local";
            this.local_radioButton.UseVisualStyleBackColor = true;
            // 
            // iniciar_button
            // 
            this.iniciar_button.BackColor = System.Drawing.Color.SteelBlue;
            this.iniciar_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar_button.Location = new System.Drawing.Point(116, 348);
            this.iniciar_button.Name = "iniciar_button";
            this.iniciar_button.Size = new System.Drawing.Size(93, 38);
            this.iniciar_button.TabIndex = 6;
            this.iniciar_button.Text = "INICIAR";
            this.iniciar_button.UseVisualStyleBackColor = false;
            this.iniciar_button.Click += new System.EventHandler(this.iniciar_button_Click);
            // 
            // InicioSesion_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDEISA.Properties.Resources.fondoInicioSesion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.iniciar_button);
            this.Controls.Add(this.tipoConexion_groupBox);
            this.Controls.Add(this.clave_textBox);
            this.Controls.Add(this.cuenta_textBox);
            this.Controls.Add(this.tarjeta_pictureBox);
            this.Controls.Add(this.clave_label);
            this.Controls.Add(this.cuenta_label);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InicioSesion_vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSesion_vista_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tarjeta_pictureBox)).EndInit();
            this.tipoConexion_groupBox.ResumeLayout(false);
            this.tipoConexion_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cuenta_label;
        private System.Windows.Forms.Label clave_label;
        private System.Windows.Forms.PictureBox tarjeta_pictureBox;
        private System.Windows.Forms.TextBox cuenta_textBox;
        private System.Windows.Forms.TextBox clave_textBox;
        private System.Windows.Forms.GroupBox tipoConexion_groupBox;
        private System.Windows.Forms.RadioButton remota_radioButton;
        private System.Windows.Forms.RadioButton local_radioButton;
        private System.Windows.Forms.Button iniciar_button;
    }
}