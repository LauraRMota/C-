namespace MediaAluno
{
    partial class frmCalculoMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoMedia));
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPesoNota1 = new System.Windows.Forms.ComboBox();
            this.cboPesoNota2 = new System.Windows.Forms.ComboBox();
            this.cboTrabalho = new System.Windows.Forms.ComboBox();
            this.txtQdeAulas = new System.Windows.Forms.TextBox();
            this.txtQdeFaltas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAproveitamento = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numNotaCorte = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.gbSituação = new System.Windows.Forms.GroupBox();
            this.gbRecuperacao = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).BeginInit();
            this.gbSituação.SuspendLayout();
            this.gbRecuperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNota1
            // 
            this.txtNota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNota1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(88, 170);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 21);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNota2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(240, 170);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 21);
            this.txtNota2.TabIndex = 3;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrabalho.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabalho.Location = new System.Drawing.Point(390, 170);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(100, 21);
            this.txtTrabalho.TabIndex = 5;
            this.txtTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trabalho";
            // 
            // cboPesoNota1
            // 
            this.cboPesoNota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPesoNota1.FormattingEnabled = true;
            this.cboPesoNota1.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboPesoNota1.Location = new System.Drawing.Point(88, 197);
            this.cboPesoNota1.Name = "cboPesoNota1";
            this.cboPesoNota1.Size = new System.Drawing.Size(100, 23);
            this.cboPesoNota1.TabIndex = 2;
            // 
            // cboPesoNota2
            // 
            this.cboPesoNota2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPesoNota2.FormattingEnabled = true;
            this.cboPesoNota2.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboPesoNota2.Location = new System.Drawing.Point(240, 197);
            this.cboPesoNota2.Name = "cboPesoNota2";
            this.cboPesoNota2.Size = new System.Drawing.Size(100, 23);
            this.cboPesoNota2.TabIndex = 4;
            // 
            // cboTrabalho
            // 
            this.cboTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrabalho.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrabalho.FormattingEnabled = true;
            this.cboTrabalho.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cboTrabalho.Location = new System.Drawing.Point(390, 197);
            this.cboTrabalho.Name = "cboTrabalho";
            this.cboTrabalho.Size = new System.Drawing.Size(100, 23);
            this.cboTrabalho.TabIndex = 19;
            // 
            // txtQdeAulas
            // 
            this.txtQdeAulas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQdeAulas.Location = new System.Drawing.Point(256, 260);
            this.txtQdeAulas.Name = "txtQdeAulas";
            this.txtQdeAulas.Size = new System.Drawing.Size(100, 20);
            this.txtQdeAulas.TabIndex = 7;
            // 
            // txtQdeFaltas
            // 
            this.txtQdeFaltas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQdeFaltas.Location = new System.Drawing.Point(256, 285);
            this.txtQdeFaltas.Name = "txtQdeFaltas";
            this.txtQdeFaltas.Size = new System.Drawing.Size(100, 20);
            this.txtQdeFaltas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade faltas :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade aulas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nota de corte";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Média Final";
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMediaFinal.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaFinal.Location = new System.Drawing.Point(96, 357);
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(100, 21);
            this.txtMediaFinal.TabIndex = 9;
            this.txtMediaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMediaFinal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Aproveitamento";
            // 
            // txtAproveitamento
            // 
            this.txtAproveitamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAproveitamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAproveitamento.Location = new System.Drawing.Point(272, 357);
            this.txtAproveitamento.Name = "txtAproveitamento";
            this.txtAproveitamento.Size = new System.Drawing.Size(100, 21);
            this.txtAproveitamento.TabIndex = 11;
            this.txtAproveitamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::MediaAluno.Properties.Resources.broom__3_;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(262, 405);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 60);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = global::MediaAluno.Properties.Resources.calculator__2_;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(91, 405);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 60);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaAluno.Properties.Resources.png_transparent_blackboard_texture_black_background_black_textured_blackboard__1_;
            this.pictureBox1.Location = new System.Drawing.Point(174, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // numNotaCorte
            // 
            this.numNotaCorte.Location = new System.Drawing.Point(390, 285);
            this.numNotaCorte.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNotaCorte.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNotaCorte.Name = "numNotaCorte";
            this.numNotaCorte.Size = new System.Drawing.Size(107, 20);
            this.numNotaCorte.TabIndex = 9;
            this.numNotaCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Situação";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(6, -2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Recuperação";
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecuperacao.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecuperacao.Location = new System.Drawing.Point(30, 42);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(100, 21);
            this.txtRecuperacao.TabIndex = 1;
            this.txtRecuperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbSituação
            // 
            this.gbSituação.Controls.Add(this.label9);
            this.gbSituação.Controls.Add(this.lblSituacao);
            this.gbSituação.Location = new System.Drawing.Point(464, 332);
            this.gbSituação.Name = "gbSituação";
            this.gbSituação.Size = new System.Drawing.Size(200, 133);
            this.gbSituação.TabIndex = 16;
            this.gbSituação.TabStop = false;
            this.gbSituação.Text = "groupBox1";
            // 
            // gbRecuperacao
            // 
            this.gbRecuperacao.Controls.Add(this.label10);
            this.gbRecuperacao.Controls.Add(this.txtRecuperacao);
            this.gbRecuperacao.Location = new System.Drawing.Point(521, 145);
            this.gbRecuperacao.Name = "gbRecuperacao";
            this.gbRecuperacao.Size = new System.Drawing.Size(168, 101);
            this.gbRecuperacao.TabIndex = 16;
            this.gbRecuperacao.TabStop = false;
            this.gbRecuperacao.Text = "groupBox1";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(46, 52);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 22);
            this.lblSituacao.TabIndex = 2;
            // 
            // frmCalculoMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 501);
            this.Controls.Add(this.numNotaCorte);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAproveitamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMediaFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQdeFaltas);
            this.Controls.Add(this.txtQdeAulas);
            this.Controls.Add(this.cboTrabalho);
            this.Controls.Add(this.cboPesoNota2);
            this.Controls.Add(this.cboPesoNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbSituação);
            this.Controls.Add(this.gbRecuperacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculoMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Média";
            this.Load += new System.EventHandler(this.frmCalculoMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).EndInit();
            this.gbSituação.ResumeLayout(false);
            this.gbSituação.PerformLayout();
            this.gbRecuperacao.ResumeLayout(false);
            this.gbRecuperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtTrabalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPesoNota1;
        private System.Windows.Forms.ComboBox cboPesoNota2;
        private System.Windows.Forms.ComboBox cboTrabalho;
        private System.Windows.Forms.TextBox txtQdeAulas;
        private System.Windows.Forms.TextBox txtQdeFaltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMediaFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAproveitamento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.NumericUpDown numNotaCorte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRecuperacao;
        private System.Windows.Forms.GroupBox gbSituação;
        private System.Windows.Forms.GroupBox gbRecuperacao;
        private System.Windows.Forms.Label lblSituacao;
    }
}

