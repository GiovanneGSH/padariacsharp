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
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblInserir = new System.Windows.Forms.Label();
            this.ltbMostraNumero = new System.Windows.Forms.ListBox();
            this.gpbAleatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAleatorio
            // 
            this.gpbAleatorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbAleatorio.Controls.Add(this.ltbMostraNumero);
            this.gpbAleatorio.Controls.Add(this.lblInserir);
            this.gpbAleatorio.Controls.Add(this.txtNumero);
            this.gpbAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAleatorio.Location = new System.Drawing.Point(8, 15);
            this.gpbAleatorio.Name = "gpbAleatorio";
            this.gpbAleatorio.Size = new System.Drawing.Size(512, 284);
            this.gpbAleatorio.TabIndex = 0;
            this.gpbAleatorio.TabStop = false;
            this.gpbAleatorio.Text = "Valores";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.Lime;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(36, 305);
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
            this.btnLimpar.Location = new System.Drawing.Point(201, 305);
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
            this.btnSair.Location = new System.Drawing.Point(366, 305);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 52);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(17, 72);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(157, 26);
            this.txtNumero.TabIndex = 0;
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(13, 36);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(119, 20);
            this.lblInserir.TabIndex = 1;
            this.lblInserir.Text = "Insira o número";
            // 
            // ltbMostraNumero
            // 
            this.ltbMostraNumero.FormattingEnabled = true;
            this.ltbMostraNumero.ItemHeight = 20;
            this.ltbMostraNumero.Location = new System.Drawing.Point(226, 36);
            this.ltbMostraNumero.Name = "ltbMostraNumero";
            this.ltbMostraNumero.Size = new System.Drawing.Size(265, 224);
            this.ltbMostraNumero.TabIndex = 2;
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 381);
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
    }
}