namespace ProjetoArrays
{
    partial class frmNumAleatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumAleatorio));
            this.gpbAleatorio = new System.Windows.Forms.GroupBox();
            this.ltbMostraNumero = new System.Windows.Forms.ListBox();
            this.lblInserir = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNMinimo = new System.Windows.Forms.Label();
            this.txtNMinimo = new System.Windows.Forms.TextBox();
            this.lblNMaximo = new System.Windows.Forms.Label();
            this.txtNMaximo = new System.Windows.Forms.TextBox();
            this.gpbSelecionar = new System.Windows.Forms.GroupBox();
            this.rdbInteirosA = new System.Windows.Forms.RadioButton();
            this.rdbVariosInteiros = new System.Windows.Forms.RadioButton();
            this.rdbIntAIntervalos = new System.Windows.Forms.RadioButton();
            this.rdbGerarFloatsA = new System.Windows.Forms.RadioButton();
            this.rdbAleatoriosRepeticao = new System.Windows.Forms.RadioButton();
            this.lblNumeroRepeticao = new System.Windows.Forms.Label();
            this.txtRepeticao = new System.Windows.Forms.TextBox();
            this.gpbAleatorio.SuspendLayout();
            this.gpbSelecionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAleatorio
            // 
            this.gpbAleatorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbAleatorio.Controls.Add(this.lblNumeroRepeticao);
            this.gpbAleatorio.Controls.Add(this.txtRepeticao);
            this.gpbAleatorio.Controls.Add(this.gpbSelecionar);
            this.gpbAleatorio.Controls.Add(this.lblNMaximo);
            this.gpbAleatorio.Controls.Add(this.txtNMaximo);
            this.gpbAleatorio.Controls.Add(this.lblNMinimo);
            this.gpbAleatorio.Controls.Add(this.ltbMostraNumero);
            this.gpbAleatorio.Controls.Add(this.txtNMinimo);
            this.gpbAleatorio.Controls.Add(this.lblInserir);
            this.gpbAleatorio.Controls.Add(this.txtNumero);
            this.gpbAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAleatorio.Location = new System.Drawing.Point(12, 15);
            this.gpbAleatorio.Name = "gpbAleatorio";
            this.gpbAleatorio.Size = new System.Drawing.Size(651, 244);
            this.gpbAleatorio.TabIndex = 0;
            this.gpbAleatorio.TabStop = false;
            this.gpbAleatorio.Text = "Valores";
            // 
            // ltbMostraNumero
            // 
            this.ltbMostraNumero.FormattingEnabled = true;
            this.ltbMostraNumero.ItemHeight = 20;
            this.ltbMostraNumero.Location = new System.Drawing.Point(462, 34);
            this.ltbMostraNumero.Name = "ltbMostraNumero";
            this.ltbMostraNumero.Size = new System.Drawing.Size(172, 204);
            this.ltbMostraNumero.TabIndex = 2;
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(13, 25);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(119, 20);
            this.lblInserir.TabIndex = 1;
            this.lblInserir.Text = "Insira o número";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(17, 48);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(157, 26);
            this.txtNumero.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.Lime;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(29, 277);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(132, 52);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(265, 277);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(132, 52);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(502, 277);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 52);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNMinimo
            // 
            this.lblNMinimo.AutoSize = true;
            this.lblNMinimo.Location = new System.Drawing.Point(13, 77);
            this.lblNMinimo.Name = "lblNMinimo";
            this.lblNMinimo.Size = new System.Drawing.Size(119, 20);
            this.lblNMinimo.TabIndex = 4;
            this.lblNMinimo.Text = "Número Mínimo";
            // 
            // txtNMinimo
            // 
            this.txtNMinimo.Enabled = false;
            this.txtNMinimo.Location = new System.Drawing.Point(17, 100);
            this.txtNMinimo.Name = "txtNMinimo";
            this.txtNMinimo.Size = new System.Drawing.Size(157, 26);
            this.txtNMinimo.TabIndex = 3;
            // 
            // lblNMaximo
            // 
            this.lblNMaximo.AutoSize = true;
            this.lblNMaximo.Location = new System.Drawing.Point(13, 129);
            this.lblNMaximo.Name = "lblNMaximo";
            this.lblNMaximo.Size = new System.Drawing.Size(123, 20);
            this.lblNMaximo.TabIndex = 6;
            this.lblNMaximo.Text = "Número Máximo";
            // 
            // txtNMaximo
            // 
            this.txtNMaximo.Enabled = false;
            this.txtNMaximo.Location = new System.Drawing.Point(17, 152);
            this.txtNMaximo.Name = "txtNMaximo";
            this.txtNMaximo.Size = new System.Drawing.Size(157, 26);
            this.txtNMaximo.TabIndex = 5;
            // 
            // gpbSelecionar
            // 
            this.gpbSelecionar.Controls.Add(this.rdbAleatoriosRepeticao);
            this.gpbSelecionar.Controls.Add(this.rdbGerarFloatsA);
            this.gpbSelecionar.Controls.Add(this.rdbIntAIntervalos);
            this.gpbSelecionar.Controls.Add(this.rdbVariosInteiros);
            this.gpbSelecionar.Controls.Add(this.rdbInteirosA);
            this.gpbSelecionar.Location = new System.Drawing.Point(194, 25);
            this.gpbSelecionar.Name = "gpbSelecionar";
            this.gpbSelecionar.Size = new System.Drawing.Size(250, 205);
            this.gpbSelecionar.TabIndex = 7;
            this.gpbSelecionar.TabStop = false;
            this.gpbSelecionar.Text = "Selecione";
            // 
            // rdbInteirosA
            // 
            this.rdbInteirosA.AutoSize = true;
            this.rdbInteirosA.Location = new System.Drawing.Point(16, 25);
            this.rdbInteirosA.Name = "rdbInteirosA";
            this.rdbInteirosA.Size = new System.Drawing.Size(155, 24);
            this.rdbInteirosA.TabIndex = 0;
            this.rdbInteirosA.TabStop = true;
            this.rdbInteirosA.Text = "Inteiros Aleatórios";
            this.rdbInteirosA.UseVisualStyleBackColor = true;
            this.rdbInteirosA.CheckedChanged += new System.EventHandler(this.rdbInteirosA_CheckedChanged);
            // 
            // rdbVariosInteiros
            // 
            this.rdbVariosInteiros.AutoSize = true;
            this.rdbVariosInteiros.Location = new System.Drawing.Point(16, 55);
            this.rdbVariosInteiros.Name = "rdbVariosInteiros";
            this.rdbVariosInteiros.Size = new System.Drawing.Size(204, 24);
            this.rdbVariosInteiros.TabIndex = 1;
            this.rdbVariosInteiros.TabStop = true;
            this.rdbVariosInteiros.Text = "Vários Inteiros Aleatórios";
            this.rdbVariosInteiros.UseVisualStyleBackColor = true;
            this.rdbVariosInteiros.CheckedChanged += new System.EventHandler(this.rdbVariosInteiros_CheckedChanged);
            // 
            // rdbIntAIntervalos
            // 
            this.rdbIntAIntervalos.AutoSize = true;
            this.rdbIntAIntervalos.Location = new System.Drawing.Point(16, 85);
            this.rdbIntAIntervalos.Name = "rdbIntAIntervalos";
            this.rdbIntAIntervalos.Size = new System.Drawing.Size(228, 24);
            this.rdbIntAIntervalos.TabIndex = 2;
            this.rdbIntAIntervalos.TabStop = true;
            this.rdbIntAIntervalos.Text = "Inteiros Aleatórios Intervalos";
            this.rdbIntAIntervalos.UseVisualStyleBackColor = true;
            this.rdbIntAIntervalos.CheckedChanged += new System.EventHandler(this.rdbIntAIntervalos_CheckedChanged);
            // 
            // rdbGerarFloatsA
            // 
            this.rdbGerarFloatsA.AutoSize = true;
            this.rdbGerarFloatsA.Location = new System.Drawing.Point(16, 115);
            this.rdbGerarFloatsA.Name = "rdbGerarFloatsA";
            this.rdbGerarFloatsA.Size = new System.Drawing.Size(191, 24);
            this.rdbGerarFloatsA.TabIndex = 3;
            this.rdbGerarFloatsA.TabStop = true;
            this.rdbGerarFloatsA.Text = "Gerar Floats Aleatórios";
            this.rdbGerarFloatsA.UseVisualStyleBackColor = true;
            // 
            // rdbAleatoriosRepeticao
            // 
            this.rdbAleatoriosRepeticao.AutoSize = true;
            this.rdbAleatoriosRepeticao.Location = new System.Drawing.Point(16, 145);
            this.rdbAleatoriosRepeticao.Name = "rdbAleatoriosRepeticao";
            this.rdbAleatoriosRepeticao.Size = new System.Drawing.Size(175, 24);
            this.rdbAleatoriosRepeticao.TabIndex = 4;
            this.rdbAleatoriosRepeticao.TabStop = true;
            this.rdbAleatoriosRepeticao.Text = "Aleatórios Repetição";
            this.rdbAleatoriosRepeticao.UseVisualStyleBackColor = true;
            this.rdbAleatoriosRepeticao.CheckedChanged += new System.EventHandler(this.rdbAleatoriosRepeticao_CheckedChanged);
            // 
            // lblNumeroRepeticao
            // 
            this.lblNumeroRepeticao.AutoSize = true;
            this.lblNumeroRepeticao.Location = new System.Drawing.Point(13, 181);
            this.lblNumeroRepeticao.Name = "lblNumeroRepeticao";
            this.lblNumeroRepeticao.Size = new System.Drawing.Size(150, 20);
            this.lblNumeroRepeticao.TabIndex = 9;
            this.lblNumeroRepeticao.Text = "Número Repetições";
            // 
            // txtRepeticao
            // 
            this.txtRepeticao.Enabled = false;
            this.txtRepeticao.Location = new System.Drawing.Point(17, 204);
            this.txtRepeticao.Name = "txtRepeticao";
            this.txtRepeticao.Size = new System.Drawing.Size(157, 26);
            this.txtRepeticao.TabIndex = 8;
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 341);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.gpbAleatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNumAleatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNumAleatorio";
            this.gpbAleatorio.ResumeLayout(false);
            this.gpbAleatorio.PerformLayout();
            this.gpbSelecionar.ResumeLayout(false);
            this.gpbSelecionar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAleatorio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.ListBox ltbMostraNumero;
        private System.Windows.Forms.Label lblNMaximo;
        private System.Windows.Forms.TextBox txtNMaximo;
        private System.Windows.Forms.Label lblNMinimo;
        private System.Windows.Forms.TextBox txtNMinimo;
        private System.Windows.Forms.GroupBox gpbSelecionar;
        private System.Windows.Forms.RadioButton rdbGerarFloatsA;
        private System.Windows.Forms.RadioButton rdbIntAIntervalos;
        private System.Windows.Forms.RadioButton rdbVariosInteiros;
        private System.Windows.Forms.RadioButton rdbInteirosA;
        private System.Windows.Forms.RadioButton rdbAleatoriosRepeticao;
        private System.Windows.Forms.Label lblNumeroRepeticao;
        private System.Windows.Forms.TextBox txtRepeticao;
    }
}