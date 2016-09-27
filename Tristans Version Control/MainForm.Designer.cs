namespace Tristans_Version_Control
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
            this.CurrentTextBox = new System.Windows.Forms.TextBox();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeMinutesLabel = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.CurrentBrowser = new System.Windows.Forms.OpenFileDialog();
            this.SaveBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // CurrentTextBox
            // 
            this.CurrentTextBox.Location = new System.Drawing.Point(16, 35);
            this.CurrentTextBox.Name = "CurrentTextBox";
            this.CurrentTextBox.Size = new System.Drawing.Size(452, 20);
            this.CurrentTextBox.TabIndex = 0;
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentLabel.Location = new System.Drawing.Point(12, 9);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(108, 20);
            this.CurrentLabel.TabIndex = 1;
            this.CurrentLabel.Text = "Current File:";
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(126, 6);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(75, 23);
            this.CurrentButton.TabIndex = 2;
            this.CurrentButton.Text = "Browse...";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(146, 61);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Browse...";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLabel.Location = new System.Drawing.Point(12, 64);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(128, 20);
            this.SaveLabel.TabIndex = 4;
            this.SaveLabel.Text = "Save Location:";
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Location = new System.Drawing.Point(16, 90);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(452, 20);
            this.SaveTextBox.TabIndex = 3;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(16, 142);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(42, 20);
            this.TimeTextBox.TabIndex = 6;
            this.TimeTextBox.Text = "30";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 119);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(157, 20);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "New version every:";
            // 
            // TimeMinutesLabel
            // 
            this.TimeMinutesLabel.AutoSize = true;
            this.TimeMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMinutesLabel.Location = new System.Drawing.Point(64, 146);
            this.TimeMinutesLabel.Name = "TimeMinutesLabel";
            this.TimeMinutesLabel.Size = new System.Drawing.Size(54, 16);
            this.TimeMinutesLabel.TabIndex = 8;
            this.TimeMinutesLabel.Text = "minutes";
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(175, 119);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(293, 43);
            this.FinishButton.TabIndex = 9;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // CurrentBrowser
            // 
            this.CurrentBrowser.Title = "Choose file to make new versions of:";
            // 
            // SaveBrowser
            // 
            this.SaveBrowser.Description = "Choose where to make new versions:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 177);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.TimeMinutesLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.CurrentLabel);
            this.Controls.Add(this.CurrentTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Tristan\'s Version Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentTextBox;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.Button CurrentButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TimeMinutesLabel;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.OpenFileDialog CurrentBrowser;
        private System.Windows.Forms.FolderBrowserDialog SaveBrowser;
    }
}

