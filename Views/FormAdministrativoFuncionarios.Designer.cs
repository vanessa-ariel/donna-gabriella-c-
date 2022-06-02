
namespace DonnaGabriela.Views
{
    partial class FormAdministrativoFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblError = new System.Windows.Forms.Label();
            this.dataGridFuncionarios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelModal = new System.Windows.Forms.Panel();
            this.btnNao = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.lblModalTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableHeader = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnDesativarCadastro = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButtonNovo = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelModal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableHeader.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblError.Location = new System.Drawing.Point(140, 142);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(541, 30);
            this.lblError.TabIndex = 229;
            this.lblError.Text = "Nenhum dado disponível. Tente novamente mais tarde.";
            this.lblError.Visible = false;
            // 
            // dataGridFuncionarios
            // 
            this.dataGridFuncionarios.AllowUserToAddRows = false;
            this.dataGridFuncionarios.AllowUserToDeleteRows = false;
            this.dataGridFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFuncionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionarios.ColumnHeadersVisible = false;
            this.dataGridFuncionarios.Location = new System.Drawing.Point(36, 54);
            this.dataGridFuncionarios.Name = "dataGridFuncionarios";
            this.dataGridFuncionarios.ReadOnly = true;
            this.dataGridFuncionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFuncionarios.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFuncionarios.ShowCellErrors = false;
            this.dataGridFuncionarios.ShowCellToolTips = false;
            this.dataGridFuncionarios.ShowEditingIcon = false;
            this.dataGridFuncionarios.ShowRowErrors = false;
            this.dataGridFuncionarios.Size = new System.Drawing.Size(832, 232);
            this.dataGridFuncionarios.TabIndex = 222;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(220, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 224;
            this.label3.Text = "Nome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(109, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 20);
            this.panel2.TabIndex = 226;
            // 
            // panelModal
            // 
            this.panelModal.BackColor = System.Drawing.Color.White;
            this.panelModal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelModal.Controls.Add(this.btnNao);
            this.panelModal.Controls.Add(this.richTextBox1);
            this.panelModal.Controls.Add(this.btnSim);
            this.panelModal.Controls.Add(this.btnModal);
            this.panelModal.Controls.Add(this.lblModalTitle);
            this.panelModal.Location = new System.Drawing.Point(278, 64);
            this.panelModal.Name = "panelModal";
            this.panelModal.Size = new System.Drawing.Size(340, 226);
            this.panelModal.TabIndex = 230;
            this.panelModal.Visible = false;
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            this.btnNao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.ForeColor = System.Drawing.Color.White;
            this.btnNao.Location = new System.Drawing.Point(244, 173);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(76, 36);
            this.btnNao.TabIndex = 6;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.richTextBox1.Location = new System.Drawing.Point(19, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Tem certeza que deseja desativar o item cadastrado?";
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            this.btnSim.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.ForeColor = System.Drawing.Color.White;
            this.btnSim.Location = new System.Drawing.Point(157, 173);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(76, 36);
            this.btnSim.TabIndex = 2;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = false;
            // 
            // btnModal
            // 
            this.btnModal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModal.Location = new System.Drawing.Point(303, -1);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(36, 38);
            this.btnModal.TabIndex = 7;
            this.btnModal.Text = "x";
            // 
            // lblModalTitle
            // 
            this.lblModalTitle.AutoSize = true;
            this.lblModalTitle.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblModalTitle.Location = new System.Drawing.Point(15, 14);
            this.lblModalTitle.Name = "lblModalTitle";
            this.lblModalTitle.Size = new System.Drawing.Size(138, 25);
            this.lblModalTitle.TabIndex = 0;
            this.lblModalTitle.Text = "Desativar item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(72, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 225;
            this.label4.Text = "Telefone";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(612, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 20);
            this.panel3.TabIndex = 227;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(36, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 223;
            this.label2.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 20);
            this.panel1.TabIndex = 0;
            // 
            // tableHeader
            // 
            this.tableHeader.BackColor = System.Drawing.Color.White;
            this.tableHeader.Controls.Add(this.panel1);
            this.tableHeader.Controls.Add(this.panel3);
            this.tableHeader.Controls.Add(this.panel2);
            this.tableHeader.Location = new System.Drawing.Point(36, 19);
            this.tableHeader.Name = "tableHeader";
            this.tableHeader.Size = new System.Drawing.Size(832, 34);
            this.tableHeader.TabIndex = 228;
            this.tableHeader.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 20;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(36, 345);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(182, 36);
            this.btnEditar.TabIndex = 219;
            this.btnEditar.Text = " Editar Cadastro";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            // 
            // btnDesativarCadastro
            // 
            this.btnDesativarCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesativarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnDesativarCadastro.FlatAppearance.BorderSize = 0;
            this.btnDesativarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesativarCadastro.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesativarCadastro.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnDesativarCadastro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesativarCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesativarCadastro.IconSize = 20;
            this.btnDesativarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesativarCadastro.Location = new System.Drawing.Point(36, 396);
            this.btnDesativarCadastro.Name = "btnDesativarCadastro";
            this.btnDesativarCadastro.Size = new System.Drawing.Size(182, 36);
            this.btnDesativarCadastro.TabIndex = 220;
            this.btnDesativarCadastro.Text = " Desativar Cadastro";
            this.btnDesativarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesativarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesativarCadastro.UseVisualStyleBackColor = false;
            this.btnDesativarCadastro.Visible = false;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.iconButtonNovo);
            this.panel5.Controls.Add(this.panelModal);
            this.panel5.Controls.Add(this.lblError);
            this.panel5.Controls.Add(this.tableHeader);
            this.panel5.Controls.Add(this.dataGridFuncionarios);
            this.panel5.Controls.Add(this.btnEditar);
            this.panel5.Controls.Add(this.btnDesativarCadastro);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(11, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(886, 445);
            this.panel5.TabIndex = 230;
            // 
            // iconButtonNovo
            // 
            this.iconButtonNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.iconButtonNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.iconButtonNovo.FlatAppearance.BorderSize = 0;
            this.iconButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNovo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonNovo.ForeColor = System.Drawing.Color.White;
            this.iconButtonNovo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonNovo.IconColor = System.Drawing.Color.White;
            this.iconButtonNovo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNovo.IconSize = 20;
            this.iconButtonNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNovo.Location = new System.Drawing.Point(36, 289);
            this.iconButtonNovo.Name = "iconButtonNovo";
            this.iconButtonNovo.Size = new System.Drawing.Size(182, 36);
            this.iconButtonNovo.TabIndex = 231;
            this.iconButtonNovo.Text = " Novo Cadastro";
            this.iconButtonNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNovo.UseVisualStyleBackColor = false;
            this.iconButtonNovo.Visible = false;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(777, 74);
            this.panel6.TabIndex = 231;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(112)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(44, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 30);
            this.label5.TabIndex = 218;
            this.label5.Text = "Cadastros Ativos Funcionarios";
            // 
            // FormAdministrativoFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(914, 538);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "FormAdministrativoFuncionarios";
            this.Text = "FormAdministrativoFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelModal.ResumeLayout(false);
            this.panelModal.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableHeader.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dataGridFuncionarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelModal;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Label lblModalTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel tableHeader;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnDesativarCadastro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButtonNovo;
    }
}