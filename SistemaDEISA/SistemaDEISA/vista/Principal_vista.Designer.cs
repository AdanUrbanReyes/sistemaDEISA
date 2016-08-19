namespace SistemaDEISA.vista
{
    partial class Principal_vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_vista));
            this.menu_menuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // menu_menuStrip
            // 
            this.menu_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_menuStrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menu_menuStrip.Name = "menu_menuStrip";
            this.menu_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menu_menuStrip.TabIndex = 0;
            this.menu_menuStrip.Text = "MENU";
            // 
            // Principal_vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menu_menuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal_vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema DEISA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_vista_FormClosed);
            this.Load += new System.EventHandler(this.Principal_vista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_menuStrip;

    }
}