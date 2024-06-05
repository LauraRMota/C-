namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            txtHistorico = new TextBox();
            txtVisor = new TextBox();
            button1 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn1 = new Button();
            button5 = new Button();
            btn3 = new Button();
            btn7 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            button10 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            btnLimpar = new Button();
            btnBackspace = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnRaiz = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // txtHistorico
            // 
            txtHistorico.BackColor = SystemColors.ControlLightLight;
            txtHistorico.Location = new Point(13, 45);
            txtHistorico.Margin = new Padding(4, 5, 4, 5);
            txtHistorico.Name = "txtHistorico";
            txtHistorico.ReadOnly = true;
            txtHistorico.Size = new Size(417, 31);
            txtHistorico.TabIndex = 0;
            // 
            // txtVisor
            // 
            txtVisor.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtVisor.ForeColor = Color.DodgerBlue;
            txtVisor.Location = new Point(13, 93);
            txtVisor.Margin = new Padding(4, 5, 4, 5);
            txtVisor.Multiline = true;
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(417, 91);
            txtVisor.TabIndex = 0;
            txtVisor.Text = "0";
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(13, 196);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(71, 75);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClicouBotao_Click;
            // 
            // btn8
            // 
            btn8.Image = Properties.Resources.numero_8;
            btn8.Location = new Point(93, 196);
            btn8.Margin = new Padding(4, 5, 4, 5);
            btn8.Name = "btn8";
            btn8.Size = new Size(71, 75);
            btn8.TabIndex = 1;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += ClicouBotao_Click;
            // 
            // btn9
            // 
            btn9.Image = Properties.Resources.numero_9;
            btn9.Location = new Point(173, 196);
            btn9.Margin = new Padding(4, 5, 4, 5);
            btn9.Name = "btn9";
            btn9.Size = new Size(71, 75);
            btn9.TabIndex = 1;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += ClicouBotao_Click;
            // 
            // btn1
            // 
            btn1.Image = (Image)resources.GetObject("btn1.Image");
            btn1.Location = new Point(13, 366);
            btn1.Margin = new Padding(4, 5, 4, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(71, 75);
            btn1.TabIndex = 1;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += ClicouBotao_Click;
            // 
            // button5
            // 
            button5.Location = new Point(93, 366);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(71, 75);
            button5.TabIndex = 1;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ClicouBotao_Click;
            // 
            // btn3
            // 
            btn3.Image = Properties.Resources.numero_3;
            btn3.Location = new Point(173, 366);
            btn3.Margin = new Padding(4, 5, 4, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(71, 75);
            btn3.TabIndex = 1;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += ClicouBotao_Click;
            // 
            // btn7
            // 
            btn7.Image = Properties.Resources.sete;
            btn7.Location = new Point(13, 196);
            btn7.Margin = new Padding(4, 5, 4, 5);
            btn7.Name = "btn7";
            btn7.Size = new Size(71, 75);
            btn7.TabIndex = 1;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += ClicouBotao_Click;
            // 
            // btn2
            // 
            btn2.Image = Properties.Resources.numero_2;
            btn2.Location = new Point(93, 366);
            btn2.Margin = new Padding(4, 5, 4, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(71, 75);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += ClicouBotao_Click;
            // 
            // btn4
            // 
            btn4.Image = Properties.Resources.numero_quatro;
            btn4.Location = new Point(13, 281);
            btn4.Margin = new Padding(4, 5, 4, 5);
            btn4.Name = "btn4";
            btn4.Size = new Size(71, 75);
            btn4.TabIndex = 1;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += ClicouBotao_Click;
            // 
            // button10
            // 
            button10.Location = new Point(93, 281);
            button10.Margin = new Padding(4, 5, 4, 5);
            button10.Name = "button10";
            button10.Size = new Size(71, 75);
            button10.TabIndex = 1;
            button10.Text = "button1";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ClicouBotao_Click;
            // 
            // btn5
            // 
            btn5.Image = Properties.Resources.numero_5;
            btn5.Location = new Point(93, 281);
            btn5.Margin = new Padding(4, 5, 4, 5);
            btn5.Name = "btn5";
            btn5.Size = new Size(71, 75);
            btn5.TabIndex = 1;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += ClicouBotao_Click;
            // 
            // btn6
            // 
            btn6.Image = Properties.Resources.seis;
            btn6.Location = new Point(173, 281);
            btn6.Margin = new Padding(4, 5, 4, 5);
            btn6.Name = "btn6";
            btn6.Size = new Size(71, 75);
            btn6.TabIndex = 1;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += ClicouBotao_Click;
            // 
            // btn0
            // 
            btn0.Image = Properties.Resources.zero__1___1_;
            btn0.Location = new Point(13, 451);
            btn0.Margin = new Padding(4, 5, 4, 5);
            btn0.Name = "btn0";
            btn0.Size = new Size(151, 75);
            btn0.TabIndex = 2;
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += ClicouBotao_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Image = Properties.Resources.virgula__1_;
            btnVirgula.Location = new Point(173, 451);
            btnVirgula.Margin = new Padding(4, 5, 4, 5);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(71, 75);
            btnVirgula.TabIndex = 1;
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += ClicouBotao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.letra_c__1_;
            btnLimpar.Location = new Point(280, 196);
            btnLimpar.Margin = new Padding(4, 5, 4, 5);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(71, 75);
            btnLimpar.TabIndex = 1;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            btnBackspace.Image = (Image)resources.GetObject("btnBackspace.Image");
            btnBackspace.Location = new Point(360, 196);
            btnBackspace.Margin = new Padding(4, 5, 4, 5);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(71, 75);
            btnBackspace.TabIndex = 1;
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnAdicao
            // 
            btnAdicao.Image = Properties.Resources.mais__1_;
            btnAdicao.Location = new Point(279, 281);
            btnAdicao.Margin = new Padding(4, 5, 4, 5);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(71, 75);
            btnAdicao.TabIndex = 1;
            btnAdicao.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Image = Properties.Resources.menos__1_;
            btnSubtracao.Location = new Point(359, 281);
            btnSubtracao.Margin = new Padding(4, 5, 4, 5);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(71, 75);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Image = Properties.Resources.letra_x__1_;
            btnMultiplicacao.Location = new Point(279, 366);
            btnMultiplicacao.Margin = new Padding(4, 5, 4, 5);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(71, 75);
            btnMultiplicacao.TabIndex = 1;
            btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnDivisao
            // 
            btnDivisao.Image = Properties.Resources.colon__1_;
            btnDivisao.Location = new Point(359, 366);
            btnDivisao.Margin = new Padding(4, 5, 4, 5);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(71, 75);
            btnDivisao.TabIndex = 1;
            btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnRaiz
            // 
            btnRaiz.Image = (Image)resources.GetObject("btnRaiz.Image");
            btnRaiz.Location = new Point(279, 451);
            btnRaiz.Margin = new Padding(4, 5, 4, 5);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(71, 75);
            btnRaiz.TabIndex = 1;
            btnRaiz.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Image = Properties.Resources.igual__2_;
            btnIgual.Location = new Point(359, 451);
            btnIgual.Margin = new Padding(4, 5, 4, 5);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(71, 75);
            btnIgual.TabIndex = 1;
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(452, 561);
            Controls.Add(btn0);
            Controls.Add(btn6);
            Controls.Add(btnVirgula);
            Controls.Add(btn3);
            Controls.Add(btnIgual);
            Controls.Add(btnRaiz);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(btnBackspace);
            Controls.Add(btnLimpar);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(button10);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(button5);
            Controls.Add(btn1);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(button1);
            Controls.Add(txtVisor);
            Controls.Add(txtHistorico);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHistorico;
        private TextBox txtVisor;
        private Button button1;
        private Button btn8;
        private Button btn9;
        private Button btn1;
        private Button button5;
        private Button btn3;
        private Button btn7;
        private Button btn2;
        private Button btn4;
        private Button button10;
        private Button btn5;
        private Button btn6;
        private Button btn0;
        private Button btnVirgula;
        private Button btnLimpar;
        private Button btnBackspace;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnRaiz;
        private Button btnIgual;
    }
}