namespace TimerApp
{
    partial class StartTimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartTimerForm));
            this.Message = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(230, 42);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(93, 20);
            this.Message.TabIndex = 0;
            this.Message.Text = "Time is end!";
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(102, 87);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(159, 41);
            this.btnStartTimer.TabIndex = 1;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(287, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(169, 42);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // StartTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 140);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartTimerForm";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.StartTimerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnOK;
    }
}