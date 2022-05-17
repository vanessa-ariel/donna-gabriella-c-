
namespace DonnaGabriela
{
    partial class FormAdministrativo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExcluirCadastro = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarVoluntario = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridVoluntarias = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoluntarias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 634);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(141, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 77);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(899, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 557);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExcluirCadastro);
            this.panel4.Controls.Add(this.btnCadastrarVoluntario);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(141, 534);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(758, 100);
            this.panel4.TabIndex = 3;
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            this.btnExcluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadastro.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCadastro.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExcluirCadastro.IconColor = System.Drawing.Color.White;
            this.btnExcluirCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluirCadastro.IconSize = 20;
            this.btnExcluirCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCadastro.Location = new System.Drawing.Point(192, 15);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(182, 36);
            this.btnExcluirCadastro.TabIndex = 1;
            this.btnExcluirCadastro.Text = "Desativar Cadastro";
            this.btnExcluirCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
            // 
            // btnCadastrarVoluntario
            // 
            this.btnCadastrarVoluntario.BackColor = System.Drawing.Color.White;
            this.btnCadastrarVoluntario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarVoluntario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVoluntario.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVoluntario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnCadastrarVoluntario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCadastrarVoluntario.IconColor = System.Drawing.Color.Black;
            this.btnCadastrarVoluntario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarVoluntario.Location = new System.Drawing.Point(616, 13);
            this.btnCadastrarVoluntario.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarVoluntario.Name = "btnCadastrarVoluntario";
            this.btnCadastrarVoluntario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCadastrarVoluntario.Size = new System.Drawing.Size(142, 37);
            this.btnCadastrarVoluntario.TabIndex = 1;
            this.btnCadastrarVoluntario.Text = "Novo Cadastro";
            this.btnCadastrarVoluntario.UseVisualStyleBackColor = false;
            this.btnCadastrarVoluntario.Click += new System.EventHandler(this.btnCadastrarVoluntario_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 20;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(17, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 36);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar Cadastro";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dataGridVoluntarias);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(141, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(758, 457);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de usuárias cadastradas";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dataGridVoluntarias
            // 
            this.dataGridVoluntarias.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVoluntarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVoluntarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVoluntarias.Location = new System.Drawing.Point(0, 0);
            this.dataGridVoluntarias.Name = "dataGridVoluntarias";
            this.dataGridVoluntarias.Size = new System.Drawing.Size(758, 457);
            this.dataGridVoluntarias.TabIndex = 0;
            this.dataGridVoluntarias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVoluntarias_CellContentClick);
            // 
            // FormAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(996, 634);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Administrativo";
            this.Load += new System.EventHandler(this.FormAdministrativo_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoluntarias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridVoluntarias;
        private FontAwesome.Sharp.IconButton btnCadastrarVoluntario;
        private FontAwesome.Sharp.IconButton btnExcluirCadastro;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Label label1;
    }
}