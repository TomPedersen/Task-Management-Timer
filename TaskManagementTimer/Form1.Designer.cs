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
            this.accomplish1 = new System.Windows.Forms.TextBox();
            this.accomplish2 = new System.Windows.Forms.TextBox();
            this.accomplish3 = new System.Windows.Forms.TextBox();
            this.accomplish4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.justDistract1 = new System.Windows.Forms.TextBox();
            this.justDistract2 = new System.Windows.Forms.TextBox();
            this.justDistract3 = new System.Windows.Forms.TextBox();
            this.justDistract4 = new System.Windows.Forms.TextBox();
            this.justDistract5 = new System.Windows.Forms.TextBox();
            this.unjustDistract5 = new System.Windows.Forms.TextBox();
            this.unjustDistract4 = new System.Windows.Forms.TextBox();
            this.unjustDistract3 = new System.Windows.Forms.TextBox();
            this.unjustDistract2 = new System.Windows.Forms.TextBox();
            this.unjustDistract1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            // accomplish1
            // 
            this.accomplish1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accomplish1.Location = new System.Drawing.Point(34, 155);
            this.accomplish1.Name = "accomplish1";
            this.accomplish1.Size = new System.Drawing.Size(300, 26);
            this.accomplish1.TabIndex = 5;
            // 
            // accomplish2
            // 
            this.accomplish2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accomplish2.Location = new System.Drawing.Point(34, 187);
            this.accomplish2.Name = "accomplish2";
            this.accomplish2.Size = new System.Drawing.Size(300, 26);
            this.accomplish2.TabIndex = 6;
            // 
            // accomplish3
            // 
            this.accomplish3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accomplish3.Location = new System.Drawing.Point(34, 219);
            this.accomplish3.Name = "accomplish3";
            this.accomplish3.Size = new System.Drawing.Size(300, 26);
            this.accomplish3.TabIndex = 7;
            // 
            // accomplish4
            // 
            this.accomplish4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accomplish4.Location = new System.Drawing.Point(34, 251);
            this.accomplish4.Name = "accomplish4";
            this.accomplish4.Size = new System.Drawing.Size(300, 26);
            this.accomplish4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(34, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(300, 26);
            this.textBox5.TabIndex = 9;
            // 
            // justDistract1
            // 
            this.justDistract1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justDistract1.Location = new System.Drawing.Point(34, 365);
            this.justDistract1.Name = "justDistract1";
            this.justDistract1.Size = new System.Drawing.Size(300, 26);
            this.justDistract1.TabIndex = 10;
            // 
            // justDistract2
            // 
            this.justDistract2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justDistract2.Location = new System.Drawing.Point(34, 397);
            this.justDistract2.Name = "justDistract2";
            this.justDistract2.Size = new System.Drawing.Size(300, 26);
            this.justDistract2.TabIndex = 11;
            // 
            // justDistract3
            // 
            this.justDistract3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justDistract3.Location = new System.Drawing.Point(34, 429);
            this.justDistract3.Name = "justDistract3";
            this.justDistract3.Size = new System.Drawing.Size(300, 26);
            this.justDistract3.TabIndex = 12;
            // 
            // justDistract4
            // 
            this.justDistract4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justDistract4.Location = new System.Drawing.Point(34, 461);
            this.justDistract4.Name = "justDistract4";
            this.justDistract4.Size = new System.Drawing.Size(300, 26);
            this.justDistract4.TabIndex = 13;
            // 
            // justDistract5
            // 
            this.justDistract5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justDistract5.Location = new System.Drawing.Point(34, 493);
            this.justDistract5.Name = "justDistract5";
            this.justDistract5.Size = new System.Drawing.Size(300, 26);
            this.justDistract5.TabIndex = 14;
            // 
            // unjustDistract5
            // 
            this.unjustDistract5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unjustDistract5.Location = new System.Drawing.Point(34, 700);
            this.unjustDistract5.Name = "unjustDistract5";
            this.unjustDistract5.Size = new System.Drawing.Size(300, 26);
            this.unjustDistract5.TabIndex = 19;
            // 
            // unjustDistract4
            // 
            this.unjustDistract4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unjustDistract4.Location = new System.Drawing.Point(34, 668);
            this.unjustDistract4.Name = "unjustDistract4";
            this.unjustDistract4.Size = new System.Drawing.Size(300, 26);
            this.unjustDistract4.TabIndex = 18;
            // 
            // unjustDistract3
            // 
            this.unjustDistract3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unjustDistract3.Location = new System.Drawing.Point(34, 636);
            this.unjustDistract3.Name = "unjustDistract3";
            this.unjustDistract3.Size = new System.Drawing.Size(300, 26);
            this.unjustDistract3.TabIndex = 17;
            // 
            // unjustDistract2
            // 
            this.unjustDistract2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unjustDistract2.Location = new System.Drawing.Point(34, 604);
            this.unjustDistract2.Name = "unjustDistract2";
            this.unjustDistract2.Size = new System.Drawing.Size(300, 26);
            this.unjustDistract2.TabIndex = 16;
            // 
            // unjustDistract1
            // 
            this.unjustDistract1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unjustDistract1.Location = new System.Drawing.Point(34, 572);
            this.unjustDistract1.Name = "unjustDistract1";
            this.unjustDistract1.Size = new System.Drawing.Size(300, 26);
            this.unjustDistract1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tasks For Today";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stuff that \"Just Happened\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Distractions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "What you want to focus on today!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Justified distractions, e.g. unplanned meetings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Questionable distractions, e.g. surfing the web";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 742);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unjustDistract5);
            this.Controls.Add(this.unjustDistract4);
            this.Controls.Add(this.unjustDistract3);
            this.Controls.Add(this.unjustDistract2);
            this.Controls.Add(this.unjustDistract1);
            this.Controls.Add(this.justDistract5);
            this.Controls.Add(this.justDistract4);
            this.Controls.Add(this.justDistract3);
            this.Controls.Add(this.justDistract2);
            this.Controls.Add(this.justDistract1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.accomplish4);
            this.Controls.Add(this.accomplish3);
            this.Controls.Add(this.accomplish2);
            this.Controls.Add(this.accomplish1);
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
        private System.Windows.Forms.TextBox accomplish1;
        private System.Windows.Forms.TextBox accomplish2;
        private System.Windows.Forms.TextBox accomplish3;
        private System.Windows.Forms.TextBox accomplish4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox justDistract1;
        private System.Windows.Forms.TextBox justDistract2;
        private System.Windows.Forms.TextBox justDistract3;
        private System.Windows.Forms.TextBox justDistract4;
        private System.Windows.Forms.TextBox justDistract5;
        private System.Windows.Forms.TextBox unjustDistract5;
        private System.Windows.Forms.TextBox unjustDistract4;
        private System.Windows.Forms.TextBox unjustDistract3;
        private System.Windows.Forms.TextBox unjustDistract2;
        private System.Windows.Forms.TextBox unjustDistract1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

