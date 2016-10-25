namespace Win10Theme
{
    partial class MenuItem
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.pnlLabelPlacer = new System.Windows.Forms.Panel();
            this.pnlIconPlacer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            this.pnlLabelPlacer.SuspendLayout();
            this.pnlIconPlacer.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxIcon.Location = new System.Drawing.Point(5, 10);
            this.picBoxIcon.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(23, 18);
            this.picBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcon.TabIndex = 0;
            this.picBoxIcon.TabStop = false;
            this.picBoxIcon.Click += new System.EventHandler(this.picBoxIcon_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.White;
            this.lblLabel.Location = new System.Drawing.Point(5, 9);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(43, 21);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "label";
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            // 
            // pnlLabelPlacer
            // 
            this.pnlLabelPlacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLabelPlacer.Controls.Add(this.lblLabel);
            this.pnlLabelPlacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLabelPlacer.Location = new System.Drawing.Point(38, 10);
            this.pnlLabelPlacer.Name = "pnlLabelPlacer";
            this.pnlLabelPlacer.Padding = new System.Windows.Forms.Padding(5, 9, 0, 0);
            this.pnlLabelPlacer.Size = new System.Drawing.Size(168, 38);
            this.pnlLabelPlacer.TabIndex = 2;
            this.pnlLabelPlacer.Click += new System.EventHandler(this.pnlLabelPlacer_Click);
            // 
            // pnlIconPlacer
            // 
            this.pnlIconPlacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlIconPlacer.Controls.Add(this.picBoxIcon);
            this.pnlIconPlacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIconPlacer.Location = new System.Drawing.Point(0, 10);
            this.pnlIconPlacer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlIconPlacer.Name = "pnlIconPlacer";
            this.pnlIconPlacer.Padding = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.pnlIconPlacer.Size = new System.Drawing.Size(38, 38);
            this.pnlIconPlacer.TabIndex = 3;
            this.pnlIconPlacer.Click += new System.EventHandler(this.pnlIconPlacer_Click);
            // 
            // MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlLabelPlacer);
            this.Controls.Add(this.pnlIconPlacer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MenuItem";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Size = new System.Drawing.Size(206, 58);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            this.pnlLabelPlacer.ResumeLayout(false);
            this.pnlLabelPlacer.PerformLayout();
            this.pnlIconPlacer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLabelPlacer;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Panel pnlIconPlacer;
    }
}
