namespace BasicThreding
{
    partial class frmBasicThred
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
            this.lblThreadStart = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThreadStart
            // 
            this.lblThreadStart.AutoSize = true;
            this.lblThreadStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreadStart.Location = new System.Drawing.Point(75, 83);
            this.lblThreadStart.Name = "lblThreadStart";
            this.lblThreadStart.Size = new System.Drawing.Size(350, 37);
            this.lblThreadStart.TabIndex = 0;
            this.lblThreadStart.Text = "-Before Starting Thead-";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(188, 168);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(117, 45);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmBasicThred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 252);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblThreadStart);
            this.Name = "frmBasicThred";
            this.Text = "BasicThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThreadStart;
        private System.Windows.Forms.Button btnRun;
    }
}

