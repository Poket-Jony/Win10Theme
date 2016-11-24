namespace Win10Theme
{
    partial class MenuStyle
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTopContainer = new System.Windows.Forms.Panel();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblMenuItemTitle = new System.Windows.Forms.Label();
            this.picBoxMenuButton = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.flowPnlMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlTopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenuButton)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SlateGray;
            this.pnlTop.Controls.Add(this.pnlTopContainer);
            this.pnlTop.Controls.Add(this.picBoxMenuButton);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTop.Size = new System.Drawing.Size(578, 39);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlTopContainer
            // 
            this.pnlTopContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopContainer.Controls.Add(this.pnlStatusBar);
            this.pnlTopContainer.Controls.Add(this.lblMenuItemTitle);
            this.pnlTopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopContainer.Location = new System.Drawing.Point(37, 5);
            this.pnlTopContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopContainer.Name = "pnlTopContainer";
            this.pnlTopContainer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlTopContainer.Size = new System.Drawing.Size(536, 29);
            this.pnlTopContainer.TabIndex = 3;
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatusBar.Location = new System.Drawing.Point(20, 0);
            this.pnlStatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(516, 30);
            this.pnlStatusBar.TabIndex = 0;
            // 
            // lblMenuItemTitle
            // 
            this.lblMenuItemTitle.AutoSize = true;
            this.lblMenuItemTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMenuItemTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItemTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuItemTitle.Location = new System.Drawing.Point(20, 0);
            this.lblMenuItemTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuItemTitle.Name = "lblMenuItemTitle";
            this.lblMenuItemTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblMenuItemTitle.Size = new System.Drawing.Size(0, 25);
            this.lblMenuItemTitle.TabIndex = 0;
            // 
            // picBoxMenuButton
            // 
            this.picBoxMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMenuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBoxMenuButton.Image = global::Win10Theme.Properties.Resources.fa_bars_64_0_ffffff_none;
            this.picBoxMenuButton.Location = new System.Drawing.Point(5, 5);
            this.picBoxMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxMenuButton.Name = "picBoxMenuButton";
            this.picBoxMenuButton.Size = new System.Drawing.Size(32, 29);
            this.picBoxMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMenuButton.TabIndex = 2;
            this.picBoxMenuButton.TabStop = false;
            this.picBoxMenuButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxMenuButton_MouseDown);
            this.picBoxMenuButton.MouseEnter += new System.EventHandler(this.picBoxMenuButton_MouseEnter);
            this.picBoxMenuButton.MouseLeave += new System.EventHandler(this.picBoxMenuButton_MouseLeave);
            this.picBoxMenuButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxMenuButton_MouseUp);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DimGray;
            this.pnlLeft.Controls.Add(this.flowPnlMenuItems);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 39);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(35, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(35, 502);
            this.pnlLeft.TabIndex = 1;
            // 
            // flowPnlMenuItems
            // 
            this.flowPnlMenuItems.BackColor = System.Drawing.Color.Transparent;
            this.flowPnlMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPnlMenuItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowPnlMenuItems.Location = new System.Drawing.Point(0, 0);
            this.flowPnlMenuItems.Name = "flowPnlMenuItems";
            this.flowPnlMenuItems.Size = new System.Drawing.Size(35, 502);
            this.flowPnlMenuItems.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(35, 39);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(543, 502);
            this.pnlContent.TabIndex = 2;
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 1;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // MenuStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "MenuStyle";
            this.Size = new System.Drawing.Size(578, 541);
            this.pnlTop.ResumeLayout(false);
            this.pnlTopContainer.ResumeLayout(false);
            this.pnlTopContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenuButton)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picBoxMenuButton;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.FlowLayoutPanel flowPnlMenuItems;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Panel pnlTopContainer;
        private System.Windows.Forms.Label lblMenuItemTitle;
    }
}
