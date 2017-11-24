namespace AlgoritmoGenetico
{
    partial class TestCrossover
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
            this.txtPai = new System.Windows.Forms.TextBox();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.txtFilho2 = new System.Windows.Forms.TextBox();
            this.txtFilho1 = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtPop = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPai
            // 
            this.txtPai.Location = new System.Drawing.Point(12, 12);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(977, 20);
            this.txtPai.TabIndex = 0;
            // 
            // txtMae
            // 
            this.txtMae.Location = new System.Drawing.Point(12, 38);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(977, 20);
            this.txtMae.TabIndex = 1;
            // 
            // txtFilho2
            // 
            this.txtFilho2.Location = new System.Drawing.Point(12, 102);
            this.txtFilho2.Name = "txtFilho2";
            this.txtFilho2.Size = new System.Drawing.Size(977, 20);
            this.txtFilho2.TabIndex = 3;
            // 
            // txtFilho1
            // 
            this.txtFilho1.Location = new System.Drawing.Point(12, 76);
            this.txtFilho1.Name = "txtFilho1";
            this.txtFilho1.Size = new System.Drawing.Size(977, 20);
            this.txtFilho1.TabIndex = 2;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(51, 497);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(172, 42);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(12, 151);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(977, 340);
            this.txtPop.TabIndex = 5;
            this.txtPop.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Interar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMedia
            // 
            this.lbMedia.AutoSize = true;
            this.lbMedia.Location = new System.Drawing.Point(775, 512);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(36, 13);
            this.lbMedia.TabIndex = 7;
            this.lbMedia.Text = "Media";
            // 
            // TestCrossover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 551);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtFilho2);
            this.Controls.Add(this.txtFilho1);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.txtPai);
            this.Name = "TestCrossover";
            this.Text = "TestCrossover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPai;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.TextBox txtFilho2;
        private System.Windows.Forms.TextBox txtFilho1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RichTextBox txtPop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMedia;
    }
}