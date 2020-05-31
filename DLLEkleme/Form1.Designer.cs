namespace DLLEkleme
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
            this.btnCiftMi = new System.Windows.Forms.Button();
            this.btnSayiMi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCiftMi
            // 
            this.btnCiftMi.Location = new System.Drawing.Point(138, 92);
            this.btnCiftMi.Name = "btnCiftMi";
            this.btnCiftMi.Size = new System.Drawing.Size(75, 23);
            this.btnCiftMi.TabIndex = 0;
            this.btnCiftMi.Text = "Çift Mi ?";
            this.btnCiftMi.UseVisualStyleBackColor = true;
            this.btnCiftMi.Click += new System.EventHandler(this.btnCiftMi_Click);
            // 
            // btnSayiMi
            // 
            this.btnSayiMi.Location = new System.Drawing.Point(138, 156);
            this.btnSayiMi.Name = "btnSayiMi";
            this.btnSayiMi.Size = new System.Drawing.Size(75, 23);
            this.btnSayiMi.TabIndex = 1;
            this.btnSayiMi.Text = "Sayi mi ?";
            this.btnSayiMi.UseVisualStyleBackColor = true;
            this.btnSayiMi.Click += new System.EventHandler(this.btnSayiMi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(441, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(441, 161);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSayiMi);
            this.Controls.Add(this.btnCiftMi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCiftMi;
        private System.Windows.Forms.Button btnSayiMi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

