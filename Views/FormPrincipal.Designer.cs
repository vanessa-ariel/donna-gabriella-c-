
namespace DonnaGabriela
{
    partial class FormPrincipal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.btnAgendamentos = new FontAwesome.Sharp.IconButton();
            this.btnPendencias = new FontAwesome.Sharp.IconButton();
            this.btnAdminstrativo = new FontAwesome.Sharp.IconButton();
            this.btnDashBoard = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.iconeRestaurar = new System.Windows.Forms.PictureBox();
            this.iconeMinimizar = new System.Windows.Forms.PictureBox();
            this.iconeMaximizar = new System.Windows.Forms.PictureBox();
            this.iconeFechar = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFormularios.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.btnConfiguracoes);
            this.panelMenu.Controls.Add(this.btnAgendamentos);
            this.panelMenu.Controls.Add(this.btnPendencias);
            this.panelMenu.Controls.Add(this.btnAdminstrativo);
            this.panelMenu.Controls.Add(this.btnDashBoard);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 768);
            this.panelMenu.TabIndex = 0;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnConfiguracoes.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracoes.IconSize = 24;
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 340);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConfiguracoes.Size = new System.Drawing.Size(221, 60);
            this.btnConfiguracoes.TabIndex = 5;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.BackColor = System.Drawing.Color.White;
            this.btnAgendamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendamentos.FlatAppearance.BorderSize = 0;
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgendamentos.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnAgendamentos.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnAgendamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgendamentos.IconSize = 24;
            this.btnAgendamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamentos.Location = new System.Drawing.Point(0, 280);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAgendamentos.Size = new System.Drawing.Size(221, 60);
            this.btnAgendamentos.TabIndex = 4;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgendamentos.UseVisualStyleBackColor = false;
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
            // 
            // btnPendencias
            // 
            this.btnPendencias.BackColor = System.Drawing.Color.White;
            this.btnPendencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendencias.FlatAppearance.BorderSize = 0;
            this.btnPendencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendencias.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPendencias.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnPendencias.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnPendencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPendencias.IconSize = 24;
            this.btnPendencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendencias.Location = new System.Drawing.Point(0, 220);
            this.btnPendencias.Name = "btnPendencias";
            this.btnPendencias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPendencias.Size = new System.Drawing.Size(221, 60);
            this.btnPendencias.TabIndex = 3;
            this.btnPendencias.Text = "Pendências";
            this.btnPendencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPendencias.UseVisualStyleBackColor = false;
            this.btnPendencias.Click += new System.EventHandler(this.btnPendencias_Click);
            // 
            // btnAdminstrativo
            // 
            this.btnAdminstrativo.BackColor = System.Drawing.Color.White;
            this.btnAdminstrativo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminstrativo.FlatAppearance.BorderSize = 0;
            this.btnAdminstrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminstrativo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminstrativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminstrativo.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.btnAdminstrativo.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnAdminstrativo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdminstrativo.IconSize = 24;
            this.btnAdminstrativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminstrativo.Location = new System.Drawing.Point(0, 160);
            this.btnAdminstrativo.Name = "btnAdminstrativo";
            this.btnAdminstrativo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdminstrativo.Size = new System.Drawing.Size(221, 60);
            this.btnAdminstrativo.TabIndex = 2;
            this.btnAdminstrativo.Text = "Administrativo";
            this.btnAdminstrativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminstrativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminstrativo.UseVisualStyleBackColor = false;
            this.btnAdminstrativo.Click += new System.EventHandler(this.btnAdminstrativo_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.White;
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashBoard.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnDashBoard.IconColor = System.Drawing.Color.DarkOrchid;
            this.btnDashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashBoard.IconSize = 24;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 100);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashBoard.Size = new System.Drawing.Size(221, 60);
            this.btnDashBoard.TabIndex = 1;
            this.btnDashBoard.Text = "Dashboard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DonnaGabriela.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormularios
            // 
            this.panelFormularios.AutoScroll = true;
            this.panelFormularios.AutoSize = true;
            this.panelFormularios.Controls.Add(this.panel3);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(221, 100);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(979, 668);
            this.panelFormularios.TabIndex = 3;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFormularios_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(150)))), ((int)(((byte)(228)))));
            this.panel3.Controls.Add(this.lblFooter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 568);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 100);
            this.panel3.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFooter.Location = new System.Drawing.Point(6, 40);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(597, 21);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "2022 © - Donna Gabri-Ela - Todos os direitos reservados";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.White;
            this.panelTitulo.Controls.Add(this.iconeRestaurar);
            this.panelTitulo.Controls.Add(this.iconeMinimizar);
            this.panelTitulo.Controls.Add(this.iconeMaximizar);
            this.panelTitulo.Controls.Add(this.iconeFechar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(221, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(979, 100);
            this.panelTitulo.TabIndex = 1;
            // 
            // iconeRestaurar
            // 
            this.iconeRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeRestaurar.Image = global::DonnaGabriela.Properties.Resources.restaurar;
            this.iconeRestaurar.Location = new System.Drawing.Point(895, 25);
            this.iconeRestaurar.Name = "iconeRestaurar";
            this.iconeRestaurar.Size = new System.Drawing.Size(25, 25);
            this.iconeRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeRestaurar.TabIndex = 3;
            this.iconeRestaurar.TabStop = false;
            this.iconeRestaurar.Visible = false;
            this.iconeRestaurar.Click += new System.EventHandler(this.iconeRestaurar_Click);
            // 
            // iconeMinimizar
            // 
            this.iconeMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeMinimizar.Image = global::DonnaGabriela.Properties.Resources.minimizar;
            this.iconeMinimizar.Location = new System.Drawing.Point(864, 25);
            this.iconeMinimizar.Name = "iconeMinimizar";
            this.iconeMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconeMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeMinimizar.TabIndex = 2;
            this.iconeMinimizar.TabStop = false;
            this.iconeMinimizar.Click += new System.EventHandler(this.iconeMinimizar_Click);
            // 
            // iconeMaximizar
            // 
            this.iconeMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeMaximizar.Image = global::DonnaGabriela.Properties.Resources.maximizar1;
            this.iconeMaximizar.Location = new System.Drawing.Point(895, 25);
            this.iconeMaximizar.Name = "iconeMaximizar";
            this.iconeMaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconeMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeMaximizar.TabIndex = 1;
            this.iconeMaximizar.TabStop = false;
            this.iconeMaximizar.Click += new System.EventHandler(this.iconeMaximizar_Click);
            // 
            // iconeFechar
            // 
            this.iconeFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconeFechar.Image = global::DonnaGabriela.Properties.Resources.fechar;
            this.iconeFechar.Location = new System.Drawing.Point(926, 25);
            this.iconeFechar.Name = "iconeFechar";
            this.iconeFechar.Size = new System.Drawing.Size(25, 25);
            this.iconeFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeFechar.TabIndex = 0;
            this.iconeFechar.TabStop = false;
            this.iconeFechar.Click += new System.EventHandler(this.iconeFechar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(150)))), ((int)(((byte)(228)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 668);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 100);
            this.panel4.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFormularios.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconeRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private FontAwesome.Sharp.IconButton btnConfiguracoes;
        private FontAwesome.Sharp.IconButton btnAgendamentos;
        private FontAwesome.Sharp.IconButton btnPendencias;
        private FontAwesome.Sharp.IconButton btnAdminstrativo;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconeFechar;
        private System.Windows.Forms.PictureBox iconeMinimizar;
        private System.Windows.Forms.PictureBox iconeMaximizar;
        private System.Windows.Forms.PictureBox iconeRestaurar;
        private System.Windows.Forms.Panel panel4;
    }
}