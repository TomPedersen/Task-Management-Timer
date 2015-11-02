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
            this.startTimer = new System.Windows.Forms.Button();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 668);
            this.Controls.Add(this.startTimer);
            this.Name = "MainForm";
            this.Text = "Task Management Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startTimer;
    }
}

