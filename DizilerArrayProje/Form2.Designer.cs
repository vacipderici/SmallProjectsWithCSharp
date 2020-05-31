namespace DizilerArrayProje
{
    partial class Form2
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
            this.txtDizi = new System.Windows.Forms.TextBox();
            this.lstDizi = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDizi
            // 
            this.txtDizi.Location = new System.Drawing.Point(142, 74);
            this.txtDizi.Name = "txtDizi";
            this.txtDizi.Size = new System.Drawing.Size(100, 20);
            this.txtDizi.TabIndex = 0;
            // 
            // lstDizi
            // 
            this.lstDizi.FormattingEnabled = true;
            this.lstDizi.Location = new System.Drawing.Point(142, 114);
            this.lstDizi.Name = "lstDizi";
            this.lstDizi.Size = new System.Drawing.Size(120, 95);
            this.lstDizi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(321, 71);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Diziye Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstDizi);
            this.Controls.Add(this.txtDizi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDizi;
        private System.Windows.Forms.ListBox lstDizi;
        private System.Windows.Forms.Button btnEkle;
    }
}