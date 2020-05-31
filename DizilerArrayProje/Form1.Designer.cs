namespace DizilerArrayProje
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
            this.btnArray = new System.Windows.Forms.Button();
            this.cmbAylar = new System.Windows.Forms.ComboBox();
            this.cmbSayilar = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(198, 69);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(156, 23);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // cmbAylar
            // 
            this.cmbAylar.FormattingEnabled = true;
            this.cmbAylar.Location = new System.Drawing.Point(198, 117);
            this.cmbAylar.Name = "cmbAylar";
            this.cmbAylar.Size = new System.Drawing.Size(121, 21);
            this.cmbAylar.TabIndex = 1;
            // 
            // cmbSayilar
            // 
            this.cmbSayilar.FormattingEnabled = true;
            this.cmbSayilar.Location = new System.Drawing.Point(198, 160);
            this.cmbSayilar.Name = "cmbSayilar";
            this.cmbSayilar.Size = new System.Drawing.Size(121, 21);
            this.cmbSayilar.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(438, 219);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(87, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Diğer Forma Geç";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmbSayilar);
            this.Controls.Add(this.cmbAylar);
            this.Controls.Add(this.btnArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.ComboBox cmbAylar;
        private System.Windows.Forms.ComboBox cmbSayilar;
        private System.Windows.Forms.Label lbl1;
    }
}

