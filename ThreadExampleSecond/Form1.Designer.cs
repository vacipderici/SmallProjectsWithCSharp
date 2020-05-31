namespace ThreadExampleSecond
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
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(236, 75);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(75, 36);
            this.btnArrayList.TabIndex = 0;
            this.btnArrayList.Text = "ArrayList";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(471, 75);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(79, 36);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List<>";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(359, 180);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(79, 36);
            this.btnThread.TabIndex = 2;
            this.btnThread.Text = "Thread İle";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnArrayList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnThread;
    }
}

