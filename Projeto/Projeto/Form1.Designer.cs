namespace Projeto
{
    partial class Form1
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
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.btnIMC = new System.Windows.Forms.Button();
            this.btnDirigir = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnParcelamento = new System.Windows.Forms.Button();
            this.txbValorDivida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbQtdParcelas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbParcelado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(261, 32);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(40, 13);
            this.lbIdade.TabIndex = 0;
            this.lbIdade.Text = "IDADE";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(12, 32);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(97, 13);
            this.lbAltura.TabIndex = 1;
            this.lbAltura.Text = "ALTURA (ex: 1,70)";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(118, 32);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(89, 13);
            this.lbPeso.TabIndex = 2;
            this.lbPeso.Text = "PESO (ex: 65,75)";
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(264, 58);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(100, 20);
            this.txbIdade.TabIndex = 3;
            this.txbIdade.TextChanged += new System.EventHandler(this.txbIdade_TextChanged);
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(15, 58);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 4;
            this.txbAltura.TextChanged += new System.EventHandler(this.txbAltura_TextChanged);
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(121, 58);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 5;
            this.txbPeso.TextChanged += new System.EventHandler(this.txbPeso_TextChanged);
            // 
            // btnIMC
            // 
            this.btnIMC.Location = new System.Drawing.Point(15, 146);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(75, 23);
            this.btnIMC.TabIndex = 6;
            this.btnIMC.Text = "Calcular IMC";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // btnDirigir
            // 
            this.btnDirigir.Location = new System.Drawing.Point(96, 146);
            this.btnDirigir.Name = "btnDirigir";
            this.btnDirigir.Size = new System.Drawing.Size(96, 23);
            this.btnDirigir.TabIndex = 7;
            this.btnDirigir.Text = "Posso dirigir?";
            this.btnDirigir.UseVisualStyleBackColor = true;
            this.btnDirigir.Click += new System.EventHandler(this.btnDirigir_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(353, 151);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(73, 13);
            this.lbResultado.TabIndex = 8;
            this.lbResultado.Text = "RESULTADO";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // btnParcelamento
            // 
            this.btnParcelamento.Location = new System.Drawing.Point(198, 146);
            this.btnParcelamento.Name = "btnParcelamento";
            this.btnParcelamento.Size = new System.Drawing.Size(137, 23);
            this.btnParcelamento.TabIndex = 9;
            this.btnParcelamento.Text = "Calcular o parcelamento";
            this.btnParcelamento.UseVisualStyleBackColor = true;
            this.btnParcelamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbValorDivida
            // 
            this.txbValorDivida.Location = new System.Drawing.Point(15, 107);
            this.txbValorDivida.Name = "txbValorDivida";
            this.txbValorDivida.Size = new System.Drawing.Size(100, 20);
            this.txbValorDivida.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "VALOR DA DIVIDA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbQtdParcelas
            // 
            this.txbQtdParcelas.Location = new System.Drawing.Point(121, 107);
            this.txbQtdParcelas.Name = "txbQtdParcelas";
            this.txbQtdParcelas.Size = new System.Drawing.Size(100, 20);
            this.txbQtdParcelas.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "PARCELAS";
            // 
            // lbParcelado
            // 
            this.lbParcelado.AutoSize = true;
            this.lbParcelado.Location = new System.Drawing.Point(353, 186);
            this.lbParcelado.Name = "lbParcelado";
            this.lbParcelado.Size = new System.Drawing.Size(111, 13);
            this.lbParcelado.TabIndex = 14;
            this.lbParcelado.Text = "VALOR PARCELADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbParcelado);
            this.Controls.Add(this.txbQtdParcelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbValorDivida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParcelamento);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnDirigir);
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbIdade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Button btnDirigir;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnParcelamento;
        private System.Windows.Forms.TextBox txbValorDivida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQtdParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbParcelado;
    }
}

