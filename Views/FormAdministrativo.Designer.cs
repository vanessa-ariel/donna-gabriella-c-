
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridVoluntarias = new System.Windows.Forms.DataGridView();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnExcluirCadastro = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarVoluntario = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoluntarias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridVoluntarias);
            this.panel5.Controls.Add(this.btnEditar);
            this.panel5.Controls.Add(this.btnExcluirCadastro);
            this.panel5.Controls.Add(this.btnCadastrarVoluntario);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(886, 445);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dataGridVoluntarias
            // 
            this.dataGridVoluntarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVoluntarias.Location = new System.Drawing.Point(36, 19);
            this.dataGridVoluntarias.Name = "dataGridVoluntarias";
            this.dataGridVoluntarias.Size = new System.Drawing.Size(832, 305);
            this.dataGridVoluntarias.TabIndex = 222;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 20;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(36, 279);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(182, 36);
            this.btnEditar.TabIndex = 219;
            this.btnEditar.Text = " Editar Cadastro";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirCadastro.BackColor = System.Drawing.Color.White;
            this.btnExcluirCadastro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadastro.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirCadastro.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExcluirCadastro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluirCadastro.IconSize = 20;
            this.btnExcluirCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCadastro.Location = new System.Drawing.Point(36, 330);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(182, 36);
            this.btnExcluirCadastro.TabIndex = 220;
            this.btnExcluirCadastro.Text = " Desativar Cadastro";
            this.btnExcluirCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarVoluntario
            // 
            this.btnCadastrarVoluntario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnCadastrarVoluntario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarVoluntario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVoluntario.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVoluntario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarVoluntario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCadastrarVoluntario.IconColor = System.Drawing.Color.Black;
            this.btnCadastrarVoluntario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarVoluntario.Location = new System.Drawing.Point(670, 344);
            this.btnCadastrarVoluntario.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarVoluntario.Name = "btnCadastrarVoluntario";
            this.btnCadastrarVoluntario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCadastrarVoluntario.Size = new System.Drawing.Size(162, 37);
            this.btnCadastrarVoluntario.TabIndex = 221;
            this.btnCadastrarVoluntario.Text = "Novo Cadastro";
            this.btnCadastrarVoluntario.UseVisualStyleBackColor = false;
            this.btnCadastrarVoluntario.Click += new System.EventHandler(this.BtnCadastrarVoluntario_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(-33, -86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 30);
            this.label1.TabIndex = 218;
            this.label1.Text = "Lista de voluntárias cadastradas";
            // 
            // FormAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(909, 365);
            this.Controls.Add(this.panel5);
            this.Name = "FormAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulário Administrativo";
            this.Load += new System.EventHandler(this.FormAdministrativo_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVoluntarias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnExcluirCadastro;
        private FontAwesome.Sharp.IconButton btnCadastrarVoluntario;
        private System.Windows.Forms.DataGridView dataGridVoluntarias;
    }
}