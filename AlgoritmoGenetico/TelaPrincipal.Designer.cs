namespace AlgoritmoGenetico
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.zedPopulacao = new ZedGraph.ZedGraphControl();
            this.zedMediaPopulacao = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtTaxaCrossover = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.MaskedTextBox();
            this.txtIteracoes = new System.Windows.Forms.MaskedTextBox();
            this.btnIniciarAG = new System.Windows.Forms.Button();
            this.btnCriarPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedPopulacao
            // 
            this.zedPopulacao.Location = new System.Drawing.Point(15, 85);
            this.zedPopulacao.Name = "zedPopulacao";
            this.zedPopulacao.ScrollGrace = 0D;
            this.zedPopulacao.ScrollMaxX = 0D;
            this.zedPopulacao.ScrollMaxY = 0D;
            this.zedPopulacao.ScrollMaxY2 = 0D;
            this.zedPopulacao.ScrollMinX = 0D;
            this.zedPopulacao.ScrollMinY = 0D;
            this.zedPopulacao.ScrollMinY2 = 0D;
            this.zedPopulacao.Size = new System.Drawing.Size(509, 329);
            this.zedPopulacao.TabIndex = 0;
            // 
            // zedMediaPopulacao
            // 
            this.zedMediaPopulacao.Location = new System.Drawing.Point(538, 85);
            this.zedMediaPopulacao.Name = "zedMediaPopulacao";
            this.zedMediaPopulacao.ScrollGrace = 0D;
            this.zedMediaPopulacao.ScrollMaxX = 0D;
            this.zedMediaPopulacao.ScrollMaxY = 0D;
            this.zedMediaPopulacao.ScrollMaxY2 = 0D;
            this.zedMediaPopulacao.ScrollMinX = 0D;
            this.zedMediaPopulacao.ScrollMinY = 0D;
            this.zedMediaPopulacao.ScrollMinY2 = 0D;
            this.zedMediaPopulacao.Size = new System.Drawing.Size(466, 329);
            this.zedMediaPopulacao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taxa de Crossover:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taxa de Mutação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Evoluções:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Melhores Individuos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Piores Individuos";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 433);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(509, 106);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(538, 433);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(466, 106);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // txtTaxaCrossover
            // 
            this.txtTaxaCrossover.Location = new System.Drawing.Point(117, 6);
            this.txtTaxaCrossover.Mask = "0,00";
            this.txtTaxaCrossover.Name = "txtTaxaCrossover";
            this.txtTaxaCrossover.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaCrossover.TabIndex = 9;
            this.txtTaxaCrossover.Text = "080";
            this.txtTaxaCrossover.ValidatingType = typeof(System.DateTime);
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Location = new System.Drawing.Point(117, 33);
            this.txtTaxaMutacao.Mask = "0,00";
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaMutacao.TabIndex = 10;
            this.txtTaxaMutacao.Text = "001";
            // 
            // txtIteracoes
            // 
            this.txtIteracoes.Location = new System.Drawing.Point(117, 60);
            this.txtIteracoes.Mask = "00000";
            this.txtIteracoes.Name = "txtIteracoes";
            this.txtIteracoes.Size = new System.Drawing.Size(100, 20);
            this.txtIteracoes.TabIndex = 11;
            this.txtIteracoes.Text = "100";
            this.txtIteracoes.ValidatingType = typeof(int);
            // 
            // btnIniciarAG
            // 
            this.btnIniciarAG.Location = new System.Drawing.Point(538, 12);
            this.btnIniciarAG.Name = "btnIniciarAG";
            this.btnIniciarAG.Size = new System.Drawing.Size(167, 41);
            this.btnIniciarAG.TabIndex = 13;
            this.btnIniciarAG.Text = "Executar AG";
            this.btnIniciarAG.UseVisualStyleBackColor = true;
            this.btnIniciarAG.Click += new System.EventHandler(this.btnIniciarAG_Click);
            // 
            // btnCriarPop
            // 
            this.btnCriarPop.Location = new System.Drawing.Point(357, 12);
            this.btnCriarPop.Name = "btnCriarPop";
            this.btnCriarPop.Size = new System.Drawing.Size(167, 41);
            this.btnCriarPop.TabIndex = 14;
            this.btnCriarPop.Text = "Criar População";
            this.btnCriarPop.UseVisualStyleBackColor = true;
            this.btnCriarPop.Click += new System.EventHandler(this.btnCriarPop_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 551);
            this.Controls.Add(this.btnCriarPop);
            this.Controls.Add(this.btnIniciarAG);
            this.Controls.Add(this.txtIteracoes);
            this.Controls.Add(this.txtTaxaMutacao);
            this.Controls.Add(this.txtTaxaCrossover);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedMediaPopulacao);
            this.Controls.Add(this.zedPopulacao);
            this.Name = "TelaPrincipal";
            this.Text = "Execução do Algoritmo Genético";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedPopulacao;
        private ZedGraph.ZedGraphControl zedMediaPopulacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.MaskedTextBox txtTaxaCrossover;
        private System.Windows.Forms.MaskedTextBox txtTaxaMutacao;
        private System.Windows.Forms.MaskedTextBox txtIteracoes;
        private System.Windows.Forms.Button btnIniciarAG;
        private System.Windows.Forms.Button btnCriarPop;
    }
}