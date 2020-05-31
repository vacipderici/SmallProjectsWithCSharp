namespace TipDonusumleri
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
            this.btnImplicint = new System.Windows.Forms.Button();
            this.btnExplicit = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnTryParse = new System.Windows.Forms.Button();
            this.btnToString = new System.Windows.Forms.Button();
            this.btnAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImplicint
            // 
            this.btnImplicint.Location = new System.Drawing.Point(191, 42);
            this.btnImplicint.Name = "btnImplicint";
            this.btnImplicint.Size = new System.Drawing.Size(267, 23);
            this.btnImplicint.TabIndex = 0;
            this.btnImplicint.Text = "Küçük Tip Büyük Tipe(Bilinçsiz Dönüşüm)";
            this.btnImplicint.UseVisualStyleBackColor = true;
            this.btnImplicint.Click += new System.EventHandler(this.btnImplicint_Click);
            // 
            // btnExplicit
            // 
            this.btnExplicit.Location = new System.Drawing.Point(191, 93);
            this.btnExplicit.Name = "btnExplicit";
            this.btnExplicit.Size = new System.Drawing.Size(267, 23);
            this.btnExplicit.TabIndex = 1;
            this.btnExplicit.Text = "Büyük Tip Küçük Tipe(Bilinçli)";
            this.btnExplicit.UseVisualStyleBackColor = true;
            this.btnExplicit.Click += new System.EventHandler(this.btnExplicit_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(191, 148);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(267, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert Yöntemi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(191, 255);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(267, 23);
            this.btnParse.TabIndex = 3;
            this.btnParse.Text = "Parse Yöntemi";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnTryParse
            // 
            this.btnTryParse.Location = new System.Drawing.Point(191, 312);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(267, 23);
            this.btnTryParse.TabIndex = 4;
            this.btnTryParse.Text = "Try Parse Yöntemi";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // btnToString
            // 
            this.btnToString.Location = new System.Drawing.Point(191, 208);
            this.btnToString.Name = "btnToString";
            this.btnToString.Size = new System.Drawing.Size(267, 23);
            this.btnToString.TabIndex = 5;
            this.btnToString.Text = "ToString ";
            this.btnToString.UseVisualStyleBackColor = true;
            this.btnToString.Click += new System.EventHandler(this.btnToString_Click);
            // 
            // btnAs
            // 
            this.btnAs.Location = new System.Drawing.Point(191, 375);
            this.btnAs.Name = "btnAs";
            this.btnAs.Size = new System.Drawing.Size(267, 23);
            this.btnAs.TabIndex = 6;
            this.btnAs.Text = "As Kullanımı";
            this.btnAs.UseVisualStyleBackColor = true;
            this.btnAs.Click += new System.EventHandler(this.btnAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAs);
            this.Controls.Add(this.btnToString);
            this.Controls.Add(this.btnTryParse);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnExplicit);
            this.Controls.Add(this.btnImplicint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImplicint;
        private System.Windows.Forms.Button btnExplicit;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnTryParse;
        private System.Windows.Forms.Button btnToString;
        private System.Windows.Forms.Button btnAs;
    }
}

