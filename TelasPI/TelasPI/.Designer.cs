namespace TelasPI
{
    partial class Form1
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
            this.btAgendamento = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btOrcamento = new System.Windows.Forms.Button();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btSairTelaInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAgendamento
            // 
            this.btAgendamento.Location = new System.Drawing.Point(265, 137);
            this.btAgendamento.Name = "btAgendamento";
            this.btAgendamento.Size = new System.Drawing.Size(100, 30);
            this.btAgendamento.TabIndex = 0;
            this.btAgendamento.Text = "Agendamento";
            this.btAgendamento.UseVisualStyleBackColor = true;
            // 
            // btCadastro
            // 
            this.btCadastro.Location = new System.Drawing.Point(397, 137);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(100, 30);
            this.btCadastro.TabIndex = 1;
            this.btCadastro.Text = "Cadastro";
            this.btCadastro.UseVisualStyleBackColor = true;
            // 
            // btEstoque
            // 
            this.btEstoque.Location = new System.Drawing.Point(397, 209);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Size = new System.Drawing.Size(100, 30);
            this.btEstoque.TabIndex = 3;
            this.btEstoque.Text = "Estoque";
            this.btEstoque.UseVisualStyleBackColor = true;
            // 
            // btOrcamento
            // 
            this.btOrcamento.Location = new System.Drawing.Point(265, 209);
            this.btOrcamento.Name = "btOrcamento";
            this.btOrcamento.Size = new System.Drawing.Size(100, 30);
            this.btOrcamento.TabIndex = 2;
            this.btOrcamento.Text = "Orçamento";
            this.btOrcamento.UseVisualStyleBackColor = true;
            // 
            // btUsuario
            // 
            this.btUsuario.Location = new System.Drawing.Point(56, 388);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(100, 30);
            this.btUsuario.TabIndex = 4;
            this.btUsuario.Text = "Usuário";
            this.btUsuario.UseVisualStyleBackColor = true;
            // 
            // btSairTelaInicio
            // 
            this.btSairTelaInicio.Location = new System.Drawing.Point(625, 388);
            this.btSairTelaInicio.Name = "btSairTelaInicio";
            this.btSairTelaInicio.Size = new System.Drawing.Size(100, 30);
            this.btSairTelaInicio.TabIndex = 5;
            this.btSairTelaInicio.Text = "Sair";
            this.btSairTelaInicio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSairTelaInicio);
            this.Controls.Add(this.btUsuario);
            this.Controls.Add(this.btEstoque);
            this.Controls.Add(this.btOrcamento);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.btAgendamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAgendamento;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btOrcamento;
        private System.Windows.Forms.Button btUsuario;
        private System.Windows.Forms.Button btSairTelaInicio;
    }
}