namespace CadastroCliente
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePF = new System.Windows.Forms.TextBox();
            this.txtEndereçoPF = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtMostraPessoaFisica = new System.Windows.Forms.TextBox();
            this.pnlPessoaFisica = new System.Windows.Forms.Panel();
            this.pnlPessoaJuridica = new System.Windows.Forms.Panel();
            this.txtMostraPessoaJuridica = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.txtEndereçoPJ = new System.Windows.Forms.TextBox();
            this.txtNomePJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPessoaJuridica = new System.Windows.Forms.Button();
            this.btnPessoaFisica = new System.Windows.Forms.Button();
            this.pnlPessoaFisica.SuspendLayout();
            this.pnlPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(6, 7);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(60, 20);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço:";
            // 
            // txtNomePF
            // 
            this.txtNomePF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePF.Location = new System.Drawing.Point(72, 7);
            this.txtNomePF.Name = "txtNomePF";
            this.txtNomePF.Size = new System.Drawing.Size(346, 20);
            this.txtNomePF.TabIndex = 8;
            // 
            // txtEndereçoPF
            // 
            this.txtEndereçoPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereçoPF.Location = new System.Drawing.Point(103, 39);
            this.txtEndereçoPF.Name = "txtEndereçoPF";
            this.txtEndereçoPF.Size = new System.Drawing.Size(315, 20);
            this.txtEndereçoPF.TabIndex = 9;
            // 
            // txtRG
            // 
            this.txtRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRG.Location = new System.Drawing.Point(50, 72);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(143, 20);
            this.txtRG.TabIndex = 10;
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Location = new System.Drawing.Point(256, 72);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(162, 20);
            this.txtCPF.TabIndex = 12;
            // 
            // txtMostraPessoaFisica
            // 
            this.txtMostraPessoaFisica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostraPessoaFisica.Location = new System.Drawing.Point(10, 98);
            this.txtMostraPessoaFisica.Multiline = true;
            this.txtMostraPessoaFisica.Name = "txtMostraPessoaFisica";
            this.txtMostraPessoaFisica.Size = new System.Drawing.Size(408, 156);
            this.txtMostraPessoaFisica.TabIndex = 13;
            // 
            // pnlPessoaFisica
            // 
            this.pnlPessoaFisica.Controls.Add(this.txtMostraPessoaFisica);
            this.pnlPessoaFisica.Controls.Add(this.txtCPF);
            this.pnlPessoaFisica.Controls.Add(this.txtRG);
            this.pnlPessoaFisica.Controls.Add(this.txtEndereçoPF);
            this.pnlPessoaFisica.Controls.Add(this.txtNomePF);
            this.pnlPessoaFisica.Controls.Add(this.label4);
            this.pnlPessoaFisica.Controls.Add(this.label3);
            this.pnlPessoaFisica.Controls.Add(this.label1);
            this.pnlPessoaFisica.Controls.Add(this.Nome);
            this.pnlPessoaFisica.Location = new System.Drawing.Point(53, 75);
            this.pnlPessoaFisica.Name = "pnlPessoaFisica";
            this.pnlPessoaFisica.Size = new System.Drawing.Size(430, 270);
            this.pnlPessoaFisica.TabIndex = 15;
            // 
            // pnlPessoaJuridica
            // 
            this.pnlPessoaJuridica.Controls.Add(this.txtMostraPessoaJuridica);
            this.pnlPessoaJuridica.Controls.Add(this.txtCNPJ);
            this.pnlPessoaJuridica.Controls.Add(this.txtIE);
            this.pnlPessoaJuridica.Controls.Add(this.txtEndereçoPJ);
            this.pnlPessoaJuridica.Controls.Add(this.txtNomePJ);
            this.pnlPessoaJuridica.Controls.Add(this.label2);
            this.pnlPessoaJuridica.Controls.Add(this.label5);
            this.pnlPessoaJuridica.Controls.Add(this.label6);
            this.pnlPessoaJuridica.Controls.Add(this.label7);
            this.pnlPessoaJuridica.Location = new System.Drawing.Point(53, 75);
            this.pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            this.pnlPessoaJuridica.Size = new System.Drawing.Size(430, 270);
            this.pnlPessoaJuridica.TabIndex = 16;
            // 
            // txtMostraPessoaJuridica
            // 
            this.txtMostraPessoaJuridica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostraPessoaJuridica.Location = new System.Drawing.Point(10, 98);
            this.txtMostraPessoaJuridica.Multiline = true;
            this.txtMostraPessoaJuridica.Name = "txtMostraPessoaJuridica";
            this.txtMostraPessoaJuridica.Size = new System.Drawing.Size(408, 156);
            this.txtMostraPessoaJuridica.TabIndex = 13;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNPJ.Location = new System.Drawing.Point(256, 72);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(162, 20);
            this.txtCNPJ.TabIndex = 12;
            // 
            // txtIE
            // 
            this.txtIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIE.Location = new System.Drawing.Point(53, 72);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(143, 20);
            this.txtIE.TabIndex = 10;
            // 
            // txtEndereçoPJ
            // 
            this.txtEndereçoPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereçoPJ.Location = new System.Drawing.Point(103, 39);
            this.txtEndereçoPJ.Name = "txtEndereçoPJ";
            this.txtEndereçoPJ.Size = new System.Drawing.Size(315, 20);
            this.txtEndereçoPJ.TabIndex = 9;
            // 
            // txtNomePJ
            // 
            this.txtNomePJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePJ.Location = new System.Drawing.Point(72, 7);
            this.txtNomePJ.Name = "txtNomePJ";
            this.txtNomePJ.Size = new System.Drawing.Size(346, 20);
            this.txtNomePJ.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "IE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "CNPJ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::CadastroCliente.Properties.Resources.clipart193383;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(342, 26);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 43);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPessoaJuridica
            // 
            this.btnPessoaJuridica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPessoaJuridica.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaJuridica.Image = global::CadastroCliente.Properties.Resources.pngwing2;
            this.btnPessoaJuridica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoaJuridica.Location = new System.Drawing.Point(196, 26);
            this.btnPessoaJuridica.Name = "btnPessoaJuridica";
            this.btnPessoaJuridica.Size = new System.Drawing.Size(141, 43);
            this.btnPessoaJuridica.TabIndex = 1;
            this.btnPessoaJuridica.Text = "Pessoa Jurídica";
            this.btnPessoaJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnPessoaJuridica.Click += new System.EventHandler(this.btnPessoaJuridica_Click);
            // 
            // btnPessoaFisica
            // 
            this.btnPessoaFisica.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaFisica.Image = global::CadastroCliente.Properties.Resources.do_utilizador;
            this.btnPessoaFisica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoaFisica.Location = new System.Drawing.Point(41, 26);
            this.btnPessoaFisica.Name = "btnPessoaFisica";
            this.btnPessoaFisica.Size = new System.Drawing.Size(141, 43);
            this.btnPessoaFisica.TabIndex = 0;
            this.btnPessoaFisica.Text = "Pessoa Física";
            this.btnPessoaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPessoaFisica.UseVisualStyleBackColor = true;
            this.btnPessoaFisica.Click += new System.EventHandler(this.btnPessoaFisica_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 358);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPessoaJuridica);
            this.Controls.Add(this.btnPessoaFisica);
            this.Controls.Add(this.pnlPessoaFisica);
            this.Controls.Add(this.pnlPessoaJuridica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.pnlPessoaFisica.ResumeLayout(false);
            this.pnlPessoaFisica.PerformLayout();
            this.pnlPessoaJuridica.ResumeLayout(false);
            this.pnlPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPessoaFisica;
        private System.Windows.Forms.Button btnPessoaJuridica;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePF;
        private System.Windows.Forms.TextBox txtEndereçoPF;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtMostraPessoaFisica;
        private System.Windows.Forms.Panel pnlPessoaFisica;
        private System.Windows.Forms.Panel pnlPessoaJuridica;
        private System.Windows.Forms.TextBox txtMostraPessoaJuridica;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.TextBox txtEndereçoPJ;
        private System.Windows.Forms.TextBox txtNomePJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

