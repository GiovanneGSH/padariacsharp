namespace ProjetoArrays
{
    partial class frmNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotas));
            this.gpbNotas = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNotaTrabalho = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblMostraNome = new System.Windows.Forms.Label();
            this.lblMostraCF = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblMostraMedia = new System.Windows.Forms.Label();
            this.lblMostraNotaTrabalho = new System.Windows.Forms.Label();
            this.lblMostraNota3 = new System.Windows.Forms.Label();
            this.lblMostraNota2 = new System.Windows.Forms.Label();
            this.lblMostraNota1 = new System.Windows.Forms.Label();
            this.lblRConceitoFinal = new System.Windows.Forms.Label();
            this.lblRMedia = new System.Windows.Forms.Label();
            this.lblRNome = new System.Windows.Forms.Label();
            this.lblRNotaTrabalho = new System.Windows.Forms.Label();
            this.lblRNotaProva3 = new System.Windows.Forms.Label();
            this.lblRNotaProva2 = new System.Windows.Forms.Label();
            this.lblRProva1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.ltbRecuperacao = new System.Windows.Forms.ListBox();
            this.ltbAprovados = new System.Windows.Forms.ListBox();
            this.ltbReprovados = new System.Windows.Forms.ListBox();
            this.gpbConceito = new System.Windows.Forms.GroupBox();
            this.btnLimparConceito = new System.Windows.Forms.Button();
            this.btnConceito = new System.Windows.Forms.Button();
            this.lblContaAlunos = new System.Windows.Forms.Label();
            this.gpbNotas.SuspendLayout();
            this.gpbConsulta.SuspendLayout();
            this.gpbConceito.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNotas
            // 
            this.gpbNotas.Controls.Add(this.lblContaAlunos);
            this.gpbNotas.Controls.Add(this.btnInserir);
            this.gpbNotas.Controls.Add(this.btnLimpar);
            this.gpbNotas.Controls.Add(this.txtNome);
            this.gpbNotas.Controls.Add(this.lblNome);
            this.gpbNotas.Controls.Add(this.txtNotaTrabalho);
            this.gpbNotas.Controls.Add(this.txtNota3);
            this.gpbNotas.Controls.Add(this.txtNota2);
            this.gpbNotas.Controls.Add(this.txtNota1);
            this.gpbNotas.Controls.Add(this.lblTrabalho);
            this.gpbNotas.Controls.Add(this.lblNota3);
            this.gpbNotas.Controls.Add(this.lblNota2);
            this.gpbNotas.Controls.Add(this.lblNota1);
            this.gpbNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNotas.Location = new System.Drawing.Point(12, 12);
            this.gpbNotas.Name = "gpbNotas";
            this.gpbNotas.Size = new System.Drawing.Size(626, 243);
            this.gpbNotas.TabIndex = 0;
            this.gpbNotas.TabStop = false;
            this.gpbNotas.Text = "Notas";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(148, 183);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(134, 38);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "&Inserir Nota";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(345, 183);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 38);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 55);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(426, 26);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(96, 20);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome Aluno";
            // 
            // txtNotaTrabalho
            // 
            this.txtNotaTrabalho.Location = new System.Drawing.Point(508, 126);
            this.txtNotaTrabalho.MaxLength = 3;
            this.txtNotaTrabalho.Name = "txtNotaTrabalho";
            this.txtNotaTrabalho.Size = new System.Drawing.Size(100, 26);
            this.txtNotaTrabalho.TabIndex = 4;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(345, 126);
            this.txtNota3.MaxLength = 3;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 26);
            this.txtNota3.TabIndex = 3;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(182, 126);
            this.txtNota2.MaxLength = 3;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 26);
            this.txtNota2.TabIndex = 2;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(19, 126);
            this.txtNota1.MaxLength = 3;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 26);
            this.txtNota1.TabIndex = 1;
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.AutoSize = true;
            this.lblTrabalho.Location = new System.Drawing.Point(504, 103);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(109, 20);
            this.lblTrabalho.TabIndex = 3;
            this.lblTrabalho.Text = "Nota Trabalho";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(341, 103);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(100, 20);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota Prova 3";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(178, 103);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(100, 20);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota Prova 2";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(15, 103);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(100, 20);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota Prova 1";
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Controls.Add(this.btnProximo);
            this.gpbConsulta.Controls.Add(this.btnAnterior);
            this.gpbConsulta.Controls.Add(this.lblMostraNome);
            this.gpbConsulta.Controls.Add(this.lblMostraCF);
            this.gpbConsulta.Controls.Add(this.btnConsulta);
            this.gpbConsulta.Controls.Add(this.lblMostraMedia);
            this.gpbConsulta.Controls.Add(this.lblMostraNotaTrabalho);
            this.gpbConsulta.Controls.Add(this.lblMostraNota3);
            this.gpbConsulta.Controls.Add(this.lblMostraNota2);
            this.gpbConsulta.Controls.Add(this.lblMostraNota1);
            this.gpbConsulta.Controls.Add(this.lblRConceitoFinal);
            this.gpbConsulta.Controls.Add(this.lblRMedia);
            this.gpbConsulta.Controls.Add(this.lblRNome);
            this.gpbConsulta.Controls.Add(this.lblRNotaTrabalho);
            this.gpbConsulta.Controls.Add(this.lblRNotaProva3);
            this.gpbConsulta.Controls.Add(this.lblRNotaProva2);
            this.gpbConsulta.Controls.Add(this.lblRProva1);
            this.gpbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsulta.Location = new System.Drawing.Point(12, 261);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(626, 214);
            this.gpbConsulta.TabIndex = 10;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "Consulta";
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProximo.Location = new System.Drawing.Point(505, 158);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(99, 38);
            this.btnProximo.TabIndex = 19;
            this.btnProximo.Text = "&Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAnterior.Location = new System.Drawing.Point(396, 158);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(99, 38);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "&Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblMostraNome
            // 
            this.lblMostraNome.AutoSize = true;
            this.lblMostraNome.Location = new System.Drawing.Point(132, 31);
            this.lblMostraNome.Name = "lblMostraNome";
            this.lblMostraNome.Size = new System.Drawing.Size(0, 20);
            this.lblMostraNome.TabIndex = 17;
            // 
            // lblMostraCF
            // 
            this.lblMostraCF.AutoSize = true;
            this.lblMostraCF.Location = new System.Drawing.Point(526, 121);
            this.lblMostraCF.Name = "lblMostraCF";
            this.lblMostraCF.Size = new System.Drawing.Size(0, 20);
            this.lblMostraCF.TabIndex = 16;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(19, 158);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 38);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "&Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblMostraMedia
            // 
            this.lblMostraMedia.AutoSize = true;
            this.lblMostraMedia.Location = new System.Drawing.Point(304, 121);
            this.lblMostraMedia.Name = "lblMostraMedia";
            this.lblMostraMedia.Size = new System.Drawing.Size(0, 20);
            this.lblMostraMedia.TabIndex = 15;
            // 
            // lblMostraNotaTrabalho
            // 
            this.lblMostraNotaTrabalho.AutoSize = true;
            this.lblMostraNotaTrabalho.Location = new System.Drawing.Point(148, 121);
            this.lblMostraNotaTrabalho.Name = "lblMostraNotaTrabalho";
            this.lblMostraNotaTrabalho.Size = new System.Drawing.Size(0, 20);
            this.lblMostraNotaTrabalho.TabIndex = 14;
            // 
            // lblMostraNota3
            // 
            this.lblMostraNota3.AutoSize = true;
            this.lblMostraNota3.Location = new System.Drawing.Point(514, 68);
            this.lblMostraNota3.Name = "lblMostraNota3";
            this.lblMostraNota3.Size = new System.Drawing.Size(0, 20);
            this.lblMostraNota3.TabIndex = 13;
            // 
            // lblMostraNota2
            // 
            this.lblMostraNota2.AutoSize = true;
            this.lblMostraNota2.Location = new System.Drawing.Point(326, 68);
            this.lblMostraNota2.Name = "lblMostraNota2";
            this.lblMostraNota2.Size = new System.Drawing.Size(0, 20);
            this.lblMostraNota2.TabIndex = 12;
            // 
            // lblMostraNota1
            // 
            this.lblMostraNota1.AutoSize = true;
            this.lblMostraNota1.Location = new System.Drawing.Point(138, 68);
            this.lblMostraNota1.Name = "lblMostraNota1";
            this.lblMostraNota1.Size = new System.Drawing.Size(0, 20);
            this.lblMostraNota1.TabIndex = 11;
            // 
            // lblRConceitoFinal
            // 
            this.lblRConceitoFinal.AutoSize = true;
            this.lblRConceitoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRConceitoFinal.Location = new System.Drawing.Point(392, 121);
            this.lblRConceitoFinal.Name = "lblRConceitoFinal";
            this.lblRConceitoFinal.Size = new System.Drawing.Size(129, 20);
            this.lblRConceitoFinal.TabIndex = 10;
            this.lblRConceitoFinal.Text = "Conceito Final:";
            // 
            // lblRMedia
            // 
            this.lblRMedia.AutoSize = true;
            this.lblRMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMedia.Location = new System.Drawing.Point(236, 121);
            this.lblRMedia.Name = "lblRMedia";
            this.lblRMedia.Size = new System.Drawing.Size(62, 20);
            this.lblRMedia.TabIndex = 9;
            this.lblRMedia.Text = "Média:";
            // 
            // lblRNome
            // 
            this.lblRNome.AutoSize = true;
            this.lblRNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNome.Location = new System.Drawing.Point(15, 31);
            this.lblRNome.Name = "lblRNome";
            this.lblRNome.Size = new System.Drawing.Size(111, 20);
            this.lblRNome.TabIndex = 8;
            this.lblRNome.Text = "Nome Aluno:";
            // 
            // lblRNotaTrabalho
            // 
            this.lblRNotaTrabalho.AutoSize = true;
            this.lblRNotaTrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNotaTrabalho.Location = new System.Drawing.Point(15, 121);
            this.lblRNotaTrabalho.Name = "lblRNotaTrabalho";
            this.lblRNotaTrabalho.Size = new System.Drawing.Size(127, 20);
            this.lblRNotaTrabalho.TabIndex = 3;
            this.lblRNotaTrabalho.Text = "Nota Trabalho:";
            // 
            // lblRNotaProva3
            // 
            this.lblRNotaProva3.AutoSize = true;
            this.lblRNotaProva3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNotaProva3.Location = new System.Drawing.Point(391, 68);
            this.lblRNotaProva3.Name = "lblRNotaProva3";
            this.lblRNotaProva3.Size = new System.Drawing.Size(117, 20);
            this.lblRNotaProva3.TabIndex = 2;
            this.lblRNotaProva3.Text = "Nota Prova 3:";
            // 
            // lblRNotaProva2
            // 
            this.lblRNotaProva2.AutoSize = true;
            this.lblRNotaProva2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNotaProva2.Location = new System.Drawing.Point(203, 68);
            this.lblRNotaProva2.Name = "lblRNotaProva2";
            this.lblRNotaProva2.Size = new System.Drawing.Size(117, 20);
            this.lblRNotaProva2.TabIndex = 1;
            this.lblRNotaProva2.Text = "Nota Prova 2:";
            // 
            // lblRProva1
            // 
            this.lblRProva1.AutoSize = true;
            this.lblRProva1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRProva1.Location = new System.Drawing.Point(15, 68);
            this.lblRProva1.Name = "lblRProva1";
            this.lblRProva1.Size = new System.Drawing.Size(117, 20);
            this.lblRProva1.TabIndex = 0;
            this.lblRProva1.Text = "Nota Prova 1:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightCoral;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(974, 437);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 38);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ltbRecuperacao
            // 
            this.ltbRecuperacao.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ltbRecuperacao.FormattingEnabled = true;
            this.ltbRecuperacao.ItemHeight = 20;
            this.ltbRecuperacao.Location = new System.Drawing.Point(14, 28);
            this.ltbRecuperacao.Name = "ltbRecuperacao";
            this.ltbRecuperacao.Size = new System.Drawing.Size(189, 124);
            this.ltbRecuperacao.TabIndex = 11;
            // 
            // ltbAprovados
            // 
            this.ltbAprovados.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ltbAprovados.FormattingEnabled = true;
            this.ltbAprovados.ItemHeight = 20;
            this.ltbAprovados.Location = new System.Drawing.Point(224, 28);
            this.ltbAprovados.Name = "ltbAprovados";
            this.ltbAprovados.Size = new System.Drawing.Size(189, 264);
            this.ltbAprovados.TabIndex = 12;
            // 
            // ltbReprovados
            // 
            this.ltbReprovados.BackColor = System.Drawing.Color.LightCoral;
            this.ltbReprovados.FormattingEnabled = true;
            this.ltbReprovados.ItemHeight = 20;
            this.ltbReprovados.Location = new System.Drawing.Point(14, 171);
            this.ltbReprovados.Name = "ltbReprovados";
            this.ltbReprovados.Size = new System.Drawing.Size(189, 124);
            this.ltbReprovados.TabIndex = 13;
            // 
            // gpbConceito
            // 
            this.gpbConceito.Controls.Add(this.btnLimparConceito);
            this.gpbConceito.Controls.Add(this.btnConceito);
            this.gpbConceito.Controls.Add(this.ltbReprovados);
            this.gpbConceito.Controls.Add(this.ltbAprovados);
            this.gpbConceito.Controls.Add(this.ltbRecuperacao);
            this.gpbConceito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConceito.Location = new System.Drawing.Point(649, 12);
            this.gpbConceito.Name = "gpbConceito";
            this.gpbConceito.Size = new System.Drawing.Size(424, 415);
            this.gpbConceito.TabIndex = 14;
            this.gpbConceito.TabStop = false;
            this.gpbConceito.Text = "Conceito Final";
            // 
            // btnLimparConceito
            // 
            this.btnLimparConceito.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimparConceito.Location = new System.Drawing.Point(295, 317);
            this.btnLimparConceito.Name = "btnLimparConceito";
            this.btnLimparConceito.Size = new System.Drawing.Size(118, 44);
            this.btnLimparConceito.TabIndex = 15;
            this.btnLimparConceito.Text = "Li&mpar";
            this.btnLimparConceito.UseVisualStyleBackColor = false;
            this.btnLimparConceito.Click += new System.EventHandler(this.btnLimparConceito_Click);
            // 
            // btnConceito
            // 
            this.btnConceito.BackColor = System.Drawing.Color.LightBlue;
            this.btnConceito.Location = new System.Drawing.Point(14, 317);
            this.btnConceito.Name = "btnConceito";
            this.btnConceito.Size = new System.Drawing.Size(118, 44);
            this.btnConceito.TabIndex = 14;
            this.btnConceito.Text = "Conceito &Final";
            this.btnConceito.UseVisualStyleBackColor = false;
            this.btnConceito.Click += new System.EventHandler(this.btnConceito_Click);
            // 
            // lblContaAlunos
            // 
            this.lblContaAlunos.AutoSize = true;
            this.lblContaAlunos.Location = new System.Drawing.Point(470, 58);
            this.lblContaAlunos.Name = "lblContaAlunos";
            this.lblContaAlunos.Size = new System.Drawing.Size(0, 20);
            this.lblContaAlunos.TabIndex = 9;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 487);
            this.Controls.Add(this.gpbConceito);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gpbConsulta);
            this.Controls.Add(this.gpbNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotas";
            this.gpbNotas.ResumeLayout(false);
            this.gpbNotas.PerformLayout();
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            this.gpbConceito.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNotas;
        private System.Windows.Forms.Label lblTrabalho;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNotaTrabalho;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.Label lblRNome;
        private System.Windows.Forms.Label lblRNotaTrabalho;
        private System.Windows.Forms.Label lblRNotaProva3;
        private System.Windows.Forms.Label lblRNotaProva2;
        private System.Windows.Forms.Label lblRProva1;
        private System.Windows.Forms.Label lblRConceitoFinal;
        private System.Windows.Forms.Label lblRMedia;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblMostraCF;
        private System.Windows.Forms.Label lblMostraMedia;
        private System.Windows.Forms.Label lblMostraNotaTrabalho;
        private System.Windows.Forms.Label lblMostraNota3;
        private System.Windows.Forms.Label lblMostraNota2;
        private System.Windows.Forms.Label lblMostraNota1;
        private System.Windows.Forms.Label lblMostraNome;
        private System.Windows.Forms.ListBox ltbRecuperacao;
        private System.Windows.Forms.ListBox ltbAprovados;
        private System.Windows.Forms.ListBox ltbReprovados;
        private System.Windows.Forms.GroupBox gpbConceito;
        private System.Windows.Forms.Button btnLimparConceito;
        private System.Windows.Forms.Button btnConceito;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblContaAlunos;
    }
}