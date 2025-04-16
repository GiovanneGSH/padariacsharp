namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaPessoa
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mktTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mktCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbMostraNome = new System.Windows.Forms.GroupBox();
            this.lblMostraIdade = new System.Windows.Forms.Label();
            this.lblMostraNome = new System.Windows.Forms.Label();
            this.lblMostraTelefone = new System.Windows.Forms.Label();
            this.lblMostraCpf = new System.Windows.Forms.Label();
            this.lblMostraEmail = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbMostraNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 383);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 55);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.mktTelefone);
            this.gpbDadosPessoais.Controls.Add(this.mktCpf);
            this.gpbDadosPessoais.Controls.Add(this.txtIdade);
            this.gpbDadosPessoais.Controls.Add(this.lblIdade);
            this.gpbDadosPessoais.Controls.Add(this.label3);
            this.gpbDadosPessoais.Controls.Add(this.lblCpf);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.label1);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(776, 147);
            this.gpbDadosPessoais.TabIndex = 1;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados pessoais";
            // 
            // mktTelefone
            // 
            this.mktTelefone.Location = new System.Drawing.Point(438, 72);
            this.mktTelefone.Mask = "(99)99999-9999";
            this.mktTelefone.Name = "mktTelefone";
            this.mktTelefone.Size = new System.Drawing.Size(125, 26);
            this.mktTelefone.TabIndex = 4;
            // 
            // mktCpf
            // 
            this.mktCpf.Location = new System.Drawing.Point(65, 79);
            this.mktCpf.Mask = "999,999,999-99";
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(122, 26);
            this.mktCpf.TabIndex = 3;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(63, 112);
            this.txtIdade.MaxLength = 2;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(39, 26);
            this.txtIdade.TabIndex = 5;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(6, 115);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(50, 20);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(6, 75);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(418, 28);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 28);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(264, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gpbMostraNome
            // 
            this.gpbMostraNome.Controls.Add(this.lblMostraIdade);
            this.gpbMostraNome.Controls.Add(this.lblMostraNome);
            this.gpbMostraNome.Controls.Add(this.lblMostraTelefone);
            this.gpbMostraNome.Controls.Add(this.lblMostraCpf);
            this.gpbMostraNome.Controls.Add(this.lblMostraEmail);
            this.gpbMostraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMostraNome.Location = new System.Drawing.Point(12, 172);
            this.gpbMostraNome.Name = "gpbMostraNome";
            this.gpbMostraNome.Size = new System.Drawing.Size(776, 175);
            this.gpbMostraNome.TabIndex = 2;
            this.gpbMostraNome.TabStop = false;
            this.gpbMostraNome.Text = "Mostra Registros";
            // 
            // lblMostraIdade
            // 
            this.lblMostraIdade.AutoSize = true;
            this.lblMostraIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraIdade.Location = new System.Drawing.Point(6, 115);
            this.lblMostraIdade.Name = "lblMostraIdade";
            this.lblMostraIdade.Size = new System.Drawing.Size(50, 20);
            this.lblMostraIdade.TabIndex = 15;
            this.lblMostraIdade.Text = "Idade";
            // 
            // lblMostraNome
            // 
            this.lblMostraNome.AutoSize = true;
            this.lblMostraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraNome.Location = new System.Drawing.Point(6, 31);
            this.lblMostraNome.Name = "lblMostraNome";
            this.lblMostraNome.Size = new System.Drawing.Size(51, 20);
            this.lblMostraNome.TabIndex = 0;
            this.lblMostraNome.Text = "Nome";
            // 
            // lblMostraTelefone
            // 
            this.lblMostraTelefone.AutoSize = true;
            this.lblMostraTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraTelefone.Location = new System.Drawing.Point(361, 75);
            this.lblMostraTelefone.Name = "lblMostraTelefone";
            this.lblMostraTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblMostraTelefone.TabIndex = 14;
            this.lblMostraTelefone.Text = "Telefone";
            // 
            // lblMostraCpf
            // 
            this.lblMostraCpf.AutoSize = true;
            this.lblMostraCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraCpf.Location = new System.Drawing.Point(6, 75);
            this.lblMostraCpf.Name = "lblMostraCpf";
            this.lblMostraCpf.Size = new System.Drawing.Size(40, 20);
            this.lblMostraCpf.TabIndex = 13;
            this.lblMostraCpf.Text = "CPF";
            // 
            // lblMostraEmail
            // 
            this.lblMostraEmail.AutoSize = true;
            this.lblMostraEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraEmail.Location = new System.Drawing.Point(361, 31);
            this.lblMostraEmail.Name = "lblMostraEmail";
            this.lblMostraEmail.Size = new System.Drawing.Size(48, 20);
            this.lblMostraEmail.TabIndex = 12;
            this.lblMostraEmail.Text = "Email";
            // 
            // frmExecutaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbMostraNome);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmExecutaPessoa";
            this.Text = "frmExecutaPessoa";
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbMostraNome.ResumeLayout(false);
            this.gpbMostraNome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbMostraNome;
        private System.Windows.Forms.Label lblMostraNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.MaskedTextBox mktTelefone;
        private System.Windows.Forms.MaskedTextBox mktCpf;
        private System.Windows.Forms.Label lblMostraIdade;
        private System.Windows.Forms.Label lblMostraTelefone;
        private System.Windows.Forms.Label lblMostraCpf;
        private System.Windows.Forms.Label lblMostraEmail;
    }
}