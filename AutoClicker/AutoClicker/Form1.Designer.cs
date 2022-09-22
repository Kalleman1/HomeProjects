namespace AutoClicker
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
            this.EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RandomCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Location = new System.Drawing.Point(22, 135);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Size = new System.Drawing.Size(99, 17);
            this.EnableCheckBox.TabIndex = 0;
            this.EnableCheckBox.Text = "Enable/Disable";
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set Interval";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interval between clicks (ms)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // RandomCheckBox
            // 
            this.RandomCheckBox.AutoSize = true;
            this.RandomCheckBox.Location = new System.Drawing.Point(137, 135);
            this.RandomCheckBox.Name = "RandomCheckBox";
            this.RandomCheckBox.Size = new System.Drawing.Size(151, 17);
            this.RandomCheckBox.TabIndex = 4;
            this.RandomCheckBox.Text = "Move cursor while clicking";
            this.RandomCheckBox.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(242, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(84, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start (F1)";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(242, 42);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(84, 23);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop (F2)";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 175);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.RandomCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EnableCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox RandomCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
    }
}

