namespace ConversorDeTemperatura
{
    partial class frmConversorTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversorTemperatura));
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.rbFahrenheitSaida = new System.Windows.Forms.RadioButton();
            this.rbKelvinSaida = new System.Windows.Forms.RadioButton();
            this.rbCelsiusSaida = new System.Windows.Forms.RadioButton();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.rbFahrenheitEntrada = new System.Windows.Forms.RadioButton();
            this.rbKelvinEntrada = new System.Windows.Forms.RadioButton();
            this.rbCelsiusEntrada = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.gbSaida.SuspendLayout();
            this.gbEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.rbFahrenheitSaida);
            this.gbSaida.Controls.Add(this.rbKelvinSaida);
            this.gbSaida.Controls.Add(this.rbCelsiusSaida);
            this.gbSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaida.Location = new System.Drawing.Point(269, 41);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(200, 113);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saída";
            // 
            // rbFahrenheitSaida
            // 
            this.rbFahrenheitSaida.AutoSize = true;
            this.rbFahrenheitSaida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheitSaida.Location = new System.Drawing.Point(54, 78);
            this.rbFahrenheitSaida.Name = "rbFahrenheitSaida";
            this.rbFahrenheitSaida.Size = new System.Drawing.Size(95, 21);
            this.rbFahrenheitSaida.TabIndex = 0;
            this.rbFahrenheitSaida.TabStop = true;
            this.rbFahrenheitSaida.Text = "Fahrenheit";
            this.rbFahrenheitSaida.UseVisualStyleBackColor = true;
            // 
            // rbKelvinSaida
            // 
            this.rbKelvinSaida.AutoSize = true;
            this.rbKelvinSaida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvinSaida.Location = new System.Drawing.Point(54, 53);
            this.rbKelvinSaida.Name = "rbKelvinSaida";
            this.rbKelvinSaida.Size = new System.Drawing.Size(65, 21);
            this.rbKelvinSaida.TabIndex = 0;
            this.rbKelvinSaida.TabStop = true;
            this.rbKelvinSaida.Text = "Kelvin";
            this.rbKelvinSaida.UseVisualStyleBackColor = true;
            // 
            // rbCelsiusSaida
            // 
            this.rbCelsiusSaida.AutoSize = true;
            this.rbCelsiusSaida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsiusSaida.Location = new System.Drawing.Point(54, 26);
            this.rbCelsiusSaida.Name = "rbCelsiusSaida";
            this.rbCelsiusSaida.Size = new System.Drawing.Size(75, 21);
            this.rbCelsiusSaida.TabIndex = 0;
            this.rbCelsiusSaida.TabStop = true;
            this.rbCelsiusSaida.Text = "Celsius";
            this.rbCelsiusSaida.UseVisualStyleBackColor = true;
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbFahrenheitEntrada);
            this.gbEntrada.Controls.Add(this.rbKelvinEntrada);
            this.gbEntrada.Controls.Add(this.rbCelsiusEntrada);
            this.gbEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntrada.Location = new System.Drawing.Point(39, 41);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(200, 113);
            this.gbEntrada.TabIndex = 1;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // rbFahrenheitEntrada
            // 
            this.rbFahrenheitEntrada.AutoSize = true;
            this.rbFahrenheitEntrada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheitEntrada.Location = new System.Drawing.Point(66, 78);
            this.rbFahrenheitEntrada.Name = "rbFahrenheitEntrada";
            this.rbFahrenheitEntrada.Size = new System.Drawing.Size(95, 21);
            this.rbFahrenheitEntrada.TabIndex = 1;
            this.rbFahrenheitEntrada.TabStop = true;
            this.rbFahrenheitEntrada.Text = "Fahrenheit";
            this.rbFahrenheitEntrada.UseVisualStyleBackColor = true;
            // 
            // rbKelvinEntrada
            // 
            this.rbKelvinEntrada.AutoSize = true;
            this.rbKelvinEntrada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvinEntrada.Location = new System.Drawing.Point(66, 53);
            this.rbKelvinEntrada.Name = "rbKelvinEntrada";
            this.rbKelvinEntrada.Size = new System.Drawing.Size(65, 21);
            this.rbKelvinEntrada.TabIndex = 0;
            this.rbKelvinEntrada.TabStop = true;
            this.rbKelvinEntrada.Text = "Kelvin";
            this.rbKelvinEntrada.UseVisualStyleBackColor = true;
            // 
            // rbCelsiusEntrada
            // 
            this.rbCelsiusEntrada.AutoSize = true;
            this.rbCelsiusEntrada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsiusEntrada.Location = new System.Drawing.Point(66, 26);
            this.rbCelsiusEntrada.Name = "rbCelsiusEntrada";
            this.rbCelsiusEntrada.Size = new System.Drawing.Size(75, 21);
            this.rbCelsiusEntrada.TabIndex = 0;
            this.rbCelsiusEntrada.TabStop = true;
            this.rbCelsiusEntrada.Text = "Celsius";
            this.rbCelsiusEntrada.UseVisualStyleBackColor = true;
            this.rbCelsiusEntrada.CheckedChanged += new System.EventHandler(this.rbCelsiusEntrada_CheckedChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(208, 160);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(128, 23);
            this.txtResultado.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(208, 12);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(128, 23);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::ConversorDeTemperatura.Properties.Resources.broom__3_;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(269, 197);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 52);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Image = global::ConversorDeTemperatura.Properties.Resources.repostar__1_;
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.Location = new System.Drawing.Point(131, 197);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(108, 52);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // frmConversorTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.gbSaida);
            this.Controls.Add(this.gbEntrada);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConversorTemperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperatura";
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSaida;
        private System.Windows.Forms.RadioButton rbFahrenheitSaida;
        private System.Windows.Forms.RadioButton rbKelvinSaida;
        private System.Windows.Forms.RadioButton rbCelsiusSaida;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.RadioButton rbFahrenheitEntrada;
        private System.Windows.Forms.RadioButton rbKelvinEntrada;
        private System.Windows.Forms.RadioButton rbCelsiusEntrada;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

