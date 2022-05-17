
namespace DonnaGabriela
{
    partial class FormConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracoes));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.pnlInner = new System.Windows.Forms.Panel();
            this.pnlScrollBar = new System.Windows.Forms.Panel();
            this.vScrollBarVertical = new System.Windows.Forms.VScrollBar();
            this.panelContainer.SuspendLayout();
            this.pnlOuter.SuspendLayout();
            this.pnlScrollBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pnlOuter);
            this.panelContainer.Controls.Add(this.pnlScrollBar);
            this.panelContainer.Location = new System.Drawing.Point(3, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(946, 527);
            this.panelContainer.TabIndex = 0;
            // 
            // pnlOuter
            // 
            this.pnlOuter.Controls.Add(this.pnlInner);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(917, 527);
            this.pnlOuter.TabIndex = 1;
            // 
            // pnlInner
            // 
            this.pnlInner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInner.BackgroundImage")));
            this.pnlInner.Location = new System.Drawing.Point(0, 0);
            this.pnlInner.Name = "pnlInner";
            this.pnlInner.Size = new System.Drawing.Size(1920, 1439);
            this.pnlInner.TabIndex = 0;
            this.pnlInner.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlInner_Paint);
            // 
            // pnlScrollBar
            // 
            this.pnlScrollBar.Controls.Add(this.vScrollBarVertical);
            this.pnlScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlScrollBar.Location = new System.Drawing.Point(917, 0);
            this.pnlScrollBar.Name = "pnlScrollBar";
            this.pnlScrollBar.Size = new System.Drawing.Size(29, 527);
            this.pnlScrollBar.TabIndex = 0;
            // 
            // vScrollBarVertical
            // 
            this.vScrollBarVertical.Location = new System.Drawing.Point(6, 1);
            this.vScrollBarVertical.Name = "vScrollBarVertical";
            this.vScrollBarVertical.Size = new System.Drawing.Size(17, 525);
            this.vScrollBarVertical.TabIndex = 1;
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 537);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormConfiguracoes";
            this.ShowInTaskbar = false;
            this.Text = "FormConfiguracoes";
            this.Load += new System.EventHandler(this.FormConfiguracoes_Load);
            this.panelContainer.ResumeLayout(false);
            this.pnlOuter.ResumeLayout(false);
            this.pnlScrollBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.Panel pnlInner;
        private System.Windows.Forms.Panel pnlScrollBar;
        private System.Windows.Forms.VScrollBar vScrollBarVertical;
    }
}