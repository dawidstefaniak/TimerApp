namespace TimerApp
{
    partial class TimerStartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerStartForm));
            this.lblTime = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnBreakReset = new System.Windows.Forms.Button();
            this.btnWorkReset = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.HotPink;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(13, 14);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(408, 178);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "99:99";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(208, 284);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(77, 60);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "▎ ▎";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnResume.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Font = new System.Drawing.Font("Bauhaus 93", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Image = ((System.Drawing.Image)(resources.GetObject("btnResume.Image")));
            this.btnResume.Location = new System.Drawing.Point(13, 197);
            this.btnResume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(187, 147);
            this.btnResume.TabIndex = 3;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnBreakReset
            // 
            this.btnBreakReset.BackColor = System.Drawing.Color.Cyan;
            this.btnBreakReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBreakReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakReset.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreakReset.Location = new System.Drawing.Point(317, 241);
            this.btnBreakReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBreakReset.Name = "btnBreakReset";
            this.btnBreakReset.Size = new System.Drawing.Size(41, 36);
            this.btnBreakReset.TabIndex = 4;
            this.btnBreakReset.Text = "■";
            this.btnBreakReset.UseVisualStyleBackColor = false;
            this.btnBreakReset.Click += new System.EventHandler(this.btnBreakReset_Click);
            // 
            // btnWorkReset
            // 
            this.btnWorkReset.BackColor = System.Drawing.Color.HotPink;
            this.btnWorkReset.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnWorkReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkReset.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkReset.Location = new System.Drawing.Point(317, 197);
            this.btnWorkReset.Name = "btnWorkReset";
            this.btnWorkReset.Size = new System.Drawing.Size(41, 36);
            this.btnWorkReset.TabIndex = 7;
            this.btnWorkReset.Text = "■";
            this.btnWorkReset.UseVisualStyleBackColor = false;
            this.btnWorkReset.Click += new System.EventHandler(this.btnWorkReset_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Start the timer.";
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.MaximizeTheApp);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Break";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(13, 352);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(422, 39);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // TimerStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(447, 400);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWorkReset);
            this.Controls.Add(this.btnBreakReset);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TimerStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Resize += new System.EventHandler(this.TimerStartForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnBreakReset;
        private System.Windows.Forms.Button btnWorkReset;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbtn;
    }
}