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
            this.SuspendLayout();
            // 
            // razonSocial_label
            // 
            this.razonSocial_label.AutoSize = true;
            this.razonSocial_label.Location = new System.Drawing.Point(13, 13);
            this.razonSocial_label.Name = "razonSocial_label";
            this.razonSocial_label.Size = new System.Drawing.Size(93, 17);
            this.razonSocial_label.TabIndex = 1;
            this.razonSocial_label.Text = "Razon social:";
            // 
            // razonSocial_comboBox
            // 
            this.razonSocial_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.razonSocial_comboBox.FormattingEnabled = true;
            this.razonSocial_comboBox.Location = new System.Drawing.Point(112, 10);
            this.razonSocial_comboBox.Name = "razonSocial_comboBox";
            this.razonSocial_comboBox.Size = new System.Drawing.Size(612, 25);
            this.razonSocial_comboBox.TabIndex = 2;
            this.razonSocial_comboBox.Enter += new System.EventHandler(this.razonSocial_comboBox_Enter);
            this.razonSocial_comboBox.Leave += new System.EventHandler(this.razonSocial_comboBox_Leave);
            // 
            // planta_label
            // 
            this.planta_label.AutoSize = true;
            this.planta_label.Location = new System.Drawing.Point(52, 49);
            this.planta_label.Name = "planta_label";
            this.planta_label.Size = new System.Drawing.Size(54, 17);
            this.planta_label.TabIndex = 3;
            this.planta_label.Text = "Planta:";
            // 
            // planta_comboBox
            // 
            this.planta_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planta_comboBox.FormattingEnabled = true;
            this.planta_comboBox.Location = new System.Drawing.Point(112, 46);
            this.planta_comboBox.Name = "planta_comboBox";
            this.planta_comboBox.Size = new System.Drawing.Size(612, 25);
            this.planta_comboBox.TabIndex = 4;
            // 
            // direccion_textBox
            // 
            this.direccion_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.direccion_textBox.Location = new System.Drawing.Point(16, 85);
            this.direccion_textBox.Name = "direccion_textBox";
            this.direccion_textBox.ReadOnly = true;
            this.direccion_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.direccion_textBox.Size = new System.Drawing.Size(708, 23);
            this.direccion_textBox.TabIndex = 5;
            // 
            // Cotizaciones_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(734, 661);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label razonSocial_label;
        private System.Windows.Forms.ComboBox razonSocial_comboBox;
        private System.Windows.Forms.Label planta_label;
        private System.Windows.Forms.ComboBox planta_comboBox;
        private System.Windows.Forms.TextBox direccion_textBox;
    }
}