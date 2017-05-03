namespace vigenere
{
    partial class Form1
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
            this.btnDekripto = new System.Windows.Forms.Button();
            this.lblCelsi1 = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCeles = new System.Windows.Forms.Button();
            this.lblCelesi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDekripto
            // 
            this.btnDekripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.Location = new System.Drawing.Point(349, 441);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(113, 46);
            this.btnDekripto.TabIndex = 10;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // lblCelsi1
            // 
            this.lblCelsi1.AutoSize = true;
            this.lblCelsi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsi1.Location = new System.Drawing.Point(29, 208);
            this.lblCelsi1.Name = "lblCelsi1";
            this.lblCelsi1.Size = new System.Drawing.Size(0, 24);
            this.lblCelsi1.TabIndex = 8;
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(12, 38);
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(1180, 136);
            this.txtCipher.TabIndex = 7;
            this.txtCipher.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ciphertexti:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnCeles
            // 
            this.btnCeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCeles.Location = new System.Drawing.Point(900, 180);
            this.btnCeles.Name = "btnCeles";
            this.btnCeles.Size = new System.Drawing.Size(292, 46);
            this.btnCeles.TabIndex = 12;
            this.btnCeles.Text = "Gjej celesat e mundshem";
            this.btnCeles.UseVisualStyleBackColor = true;
            this.btnCeles.Click += new System.EventHandler(this.btnCeles_Click);
            // 
            // lblCelesi
            // 
            this.lblCelesi.AutoSize = true;
            this.lblCelesi.Location = new System.Drawing.Point(30, 374);
            this.lblCelesi.Name = "lblCelesi";
            this.lblCelesi.Size = new System.Drawing.Size(133, 13);
            this.lblCelesi.TabIndex = 13;
            this.lblCelesi.Text = "Shkruaj njerin nga Celesat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 602);
            this.Controls.Add(this.lblCelesi);
            this.Controls.Add(this.btnCeles);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.lblCelsi1);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Label lblCelsi1;
        private System.Windows.Forms.RichTextBox txtCipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCeles;
        private System.Windows.Forms.Label lblCelesi;
    }
}

