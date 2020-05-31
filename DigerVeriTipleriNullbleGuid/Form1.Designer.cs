namespace DigerVeriTipleriNullbleGuid
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
            this.btnNullable = new System.Windows.Forms.Button();
            this.btnGuid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNullable
            // 
            this.btnNullable.Location = new System.Drawing.Point(300, 69);
            this.btnNullable.Name = "btnNullable";
            this.btnNullable.Size = new System.Drawing.Size(75, 23);
            this.btnNullable.TabIndex = 0;
            this.btnNullable.Text = "Nullable";
            this.btnNullable.UseVisualStyleBackColor = true;
            this.btnNullable.Click += new System.EventHandler(this.btnNullable_Click);
            // 
            // btnGuid
            // 
            this.btnGuid.Location = new System.Drawing.Point(300, 132);
            this.btnGuid.Name = "btnGuid";
            this.btnGuid.Size = new System.Drawing.Size(75, 23);
            this.btnGuid.TabIndex = 1;
            this.btnGuid.Text = "Guid";
            this.btnGuid.UseVisualStyleBackColor = true;
            this.btnGuid.Click += new System.EventHandler(this.btnGuid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuid);
            this.Controls.Add(this.btnNullable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNullable;
        private System.Windows.Forms.Button btnGuid;
    }
}

