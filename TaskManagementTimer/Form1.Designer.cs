namespace TaskManagementTimer
{
    partial class MainForm
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
            this.startTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Minutes = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTimer
            // 
            this.startTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimer.Location = new System.Drawing.Point(12, 12);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(131, 36);
            this.startTimer.TabIndex = 0;
            this.startTimer.Text = "Start Your Timer";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.begin_timer);
            // 
            // stopTimer
            // 
            this.stopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopTimer.Location = new System.Drawing.Point(12, 54);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(131, 36);
            this.stopTimer.TabIndex = 1;
            this.stopTimer.Text = "Stop Your Timer";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutes.Location = new System.Drawing.Point(962, 11);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(36, 37);
            this.Minutes.TabIndex = 2;
            this.Minutes.Text = "0";
            this.Minutes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds.Location = new System.Drawing.Point(1057, 12);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(36, 37);
            this.Seconds.TabIndex = 3;
            this.Seconds.Text = "0";
            this.Seconds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1024, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimer);
            this.Name = "MainForm";
            this.Text = "Task Management Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label label3;
    }
}

