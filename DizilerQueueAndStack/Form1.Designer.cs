namespace DizilerQueueAndStack
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
            this.txtEklenecekVeri = new System.Windows.Forms.TextBox();
            this.lblStack = new System.Windows.Forms.ListBox();
            this.lblQueue = new System.Windows.Forms.ListBox();
            this.btnStackQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEklenecekVeri
            // 
            this.txtEklenecekVeri.Location = new System.Drawing.Point(211, 98);
            this.txtEklenecekVeri.Name = "txtEklenecekVeri";
            this.txtEklenecekVeri.Size = new System.Drawing.Size(234, 20);
            this.txtEklenecekVeri.TabIndex = 0;
            // 
            // lblStack
            // 
            this.lblStack.FormattingEnabled = true;
            this.lblStack.Location = new System.Drawing.Point(63, 165);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(138, 95);
            this.lblStack.TabIndex = 1;
            // 
            // lblQueue
            // 
            this.lblQueue.FormattingEnabled = true;
            this.lblQueue.Location = new System.Drawing.Point(437, 165);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(130, 95);
            this.lblQueue.TabIndex = 2;
            // 
            // btnStackQueue
            // 
            this.btnStackQueue.Location = new System.Drawing.Point(263, 30);
            this.btnStackQueue.Name = "btnStackQueue";
            this.btnStackQueue.Size = new System.Drawing.Size(121, 23);
            this.btnStackQueue.TabIndex = 3;
            this.btnStackQueue.Text = "StackQueue";
            this.btnStackQueue.UseVisualStyleBackColor = true;
            this.btnStackQueue.Click += new System.EventHandler(this.btnStackQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStackQueue);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lblStack);
            this.Controls.Add(this.txtEklenecekVeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEklenecekVeri;
        private System.Windows.Forms.ListBox lblStack;
        private System.Windows.Forms.ListBox lblQueue;
        private System.Windows.Forms.Button btnStackQueue;
    }
}

