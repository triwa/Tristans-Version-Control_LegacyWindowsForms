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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.CurrentBrowser = new System.Windows.Forms.OpenFileDialog();
            this.SaveBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton1 = new System.Windows.Forms.Button();
            this.SaveTextBox1 = new System.Windows.Forms.TextBox();
            this.CurrentButton1 = new System.Windows.Forms.Button();
            this.CurrentTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.SaveTextBox2 = new System.Windows.Forms.TextBox();
            this.CurrentButton2 = new System.Windows.Forms.Button();
            this.CurrentTextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton3 = new System.Windows.Forms.Button();
            this.SaveTextBox3 = new System.Windows.Forms.TextBox();
            this.CurrentButton3 = new System.Windows.Forms.Button();
            this.CurrentTextBox3 = new System.Windows.Forms.TextBox();
            this.CurrentBrowser1 = new System.Windows.Forms.OpenFileDialog();
            this.CurrentBrowser2 = new System.Windows.Forms.OpenFileDialog();
            this.CurrentBrowser3 = new System.Windows.Forms.OpenFileDialog();
            this.SaveBrowser1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveBrowser2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveBrowser3 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // CurrentTextBox
            // 
            this.CurrentTextBox.Location = new System.Drawing.Point(16, 35);
            this.CurrentTextBox.Name = "CurrentTextBox";
            this.CurrentTextBox.ReadOnly = true;
            this.CurrentTextBox.Size = new System.Drawing.Size(452, 20);
            this.CurrentTextBox.TabIndex = 0;
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentLabel.Location = new System.Drawing.Point(12, 9);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(117, 20);
            this.CurrentLabel.TabIndex = 1;
            this.CurrentLabel.Text = "Current Files:";
            // 
            // CurrentButton
            // 
            this.CurrentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentButton.Location = new System.Drawing.Point(474, 33);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(75, 23);
            this.CurrentButton.TabIndex = 2;
            this.CurrentButton.Text = "Browse...";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(1068, 32);
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
            this.SaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLabel.Location = new System.Drawing.Point(606, 9);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(137, 20);
            this.SaveLabel.TabIndex = 4;
            this.SaveLabel.Text = "Save Locations:";
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Location = new System.Drawing.Point(610, 35);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.ReadOnly = true;
            this.SaveTextBox.Size = new System.Drawing.Size(452, 20);
            this.SaveTextBox.TabIndex = 3;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(175, 138);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(42, 20);
            this.TimeTextBox.TabIndex = 6;
            this.TimeTextBox.Text = "30";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 136);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(157, 20);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "New version every:";
            // 
            // TimeMinutesLabel
            // 
            this.TimeMinutesLabel.AutoSize = true;
            this.TimeMinutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMinutesLabel.Location = new System.Drawing.Point(223, 142);
            this.TimeMinutesLabel.Name = "TimeMinutesLabel";
            this.TimeMinutesLabel.Size = new System.Drawing.Size(54, 16);
            this.TimeMinutesLabel.TabIndex = 8;
            this.TimeMinutesLabel.Text = "minutes";
            // 
            // FinishButton
            // 
            this.FinishButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FinishButton.BackgroundImage")));
            this.FinishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FinishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FinishButton.Location = new System.Drawing.Point(974, 142);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(169, 58);
            this.FinishButton.TabIndex = 9;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CurrentBrowser
            // 
            this.CurrentBrowser.Title = "Choose file to make new versions of:";
            // 
            // SaveBrowser
            // 
            this.SaveBrowser.Description = "Choose where to make new versions:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearButton.Location = new System.Drawing.Point(799, 142);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(169, 58);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(555, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Save to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(555, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Save to:";
            // 
            // SaveButton1
            // 
            this.SaveButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton1.Location = new System.Drawing.Point(1068, 58);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(75, 23);
            this.SaveButton1.TabIndex = 15;
            this.SaveButton1.Text = "Browse...";
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // SaveTextBox1
            // 
            this.SaveTextBox1.Location = new System.Drawing.Point(610, 61);
            this.SaveTextBox1.Name = "SaveTextBox1";
            this.SaveTextBox1.ReadOnly = true;
            this.SaveTextBox1.Size = new System.Drawing.Size(452, 20);
            this.SaveTextBox1.TabIndex = 14;
            // 
            // CurrentButton1
            // 
            this.CurrentButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentButton1.Location = new System.Drawing.Point(474, 59);
            this.CurrentButton1.Name = "CurrentButton1";
            this.CurrentButton1.Size = new System.Drawing.Size(75, 23);
            this.CurrentButton1.TabIndex = 13;
            this.CurrentButton1.Text = "Browse...";
            this.CurrentButton1.UseVisualStyleBackColor = true;
            this.CurrentButton1.Click += new System.EventHandler(this.CurrentButton1_Click);
            // 
            // CurrentTextBox1
            // 
            this.CurrentTextBox1.Location = new System.Drawing.Point(16, 61);
            this.CurrentTextBox1.Name = "CurrentTextBox1";
            this.CurrentTextBox1.ReadOnly = true;
            this.CurrentTextBox1.Size = new System.Drawing.Size(452, 20);
            this.CurrentTextBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(555, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Save to:";
            // 
            // SaveButton2
            // 
            this.SaveButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton2.Location = new System.Drawing.Point(1068, 84);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(75, 23);
            this.SaveButton2.TabIndex = 20;
            this.SaveButton2.Text = "Browse...";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton2_Click);
            // 
            // SaveTextBox2
            // 
            this.SaveTextBox2.Location = new System.Drawing.Point(610, 87);
            this.SaveTextBox2.Name = "SaveTextBox2";
            this.SaveTextBox2.ReadOnly = true;
            this.SaveTextBox2.Size = new System.Drawing.Size(452, 20);
            this.SaveTextBox2.TabIndex = 19;
            // 
            // CurrentButton2
            // 
            this.CurrentButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentButton2.Location = new System.Drawing.Point(474, 85);
            this.CurrentButton2.Name = "CurrentButton2";
            this.CurrentButton2.Size = new System.Drawing.Size(75, 23);
            this.CurrentButton2.TabIndex = 18;
            this.CurrentButton2.Text = "Browse...";
            this.CurrentButton2.UseVisualStyleBackColor = true;
            this.CurrentButton2.Click += new System.EventHandler(this.CurrentButton2_Click);
            // 
            // CurrentTextBox2
            // 
            this.CurrentTextBox2.Location = new System.Drawing.Point(16, 87);
            this.CurrentTextBox2.Name = "CurrentTextBox2";
            this.CurrentTextBox2.ReadOnly = true;
            this.CurrentTextBox2.Size = new System.Drawing.Size(452, 20);
            this.CurrentTextBox2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(555, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Save to:";
            // 
            // SaveButton3
            // 
            this.SaveButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton3.Location = new System.Drawing.Point(1068, 110);
            this.SaveButton3.Name = "SaveButton3";
            this.SaveButton3.Size = new System.Drawing.Size(75, 23);
            this.SaveButton3.TabIndex = 25;
            this.SaveButton3.Text = "Browse...";
            this.SaveButton3.UseVisualStyleBackColor = true;
            this.SaveButton3.Click += new System.EventHandler(this.SaveButton3_Click);
            // 
            // SaveTextBox3
            // 
            this.SaveTextBox3.Location = new System.Drawing.Point(610, 113);
            this.SaveTextBox3.Name = "SaveTextBox3";
            this.SaveTextBox3.ReadOnly = true;
            this.SaveTextBox3.Size = new System.Drawing.Size(452, 20);
            this.SaveTextBox3.TabIndex = 24;
            // 
            // CurrentButton3
            // 
            this.CurrentButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentButton3.Location = new System.Drawing.Point(474, 111);
            this.CurrentButton3.Name = "CurrentButton3";
            this.CurrentButton3.Size = new System.Drawing.Size(75, 23);
            this.CurrentButton3.TabIndex = 23;
            this.CurrentButton3.Text = "Browse...";
            this.CurrentButton3.UseVisualStyleBackColor = true;
            this.CurrentButton3.Click += new System.EventHandler(this.CurrentButton3_Click);
            // 
            // CurrentTextBox3
            // 
            this.CurrentTextBox3.Location = new System.Drawing.Point(16, 113);
            this.CurrentTextBox3.Name = "CurrentTextBox3";
            this.CurrentTextBox3.ReadOnly = true;
            this.CurrentTextBox3.Size = new System.Drawing.Size(452, 20);
            this.CurrentTextBox3.TabIndex = 22;
            // 
            // CurrentBrowser1
            // 
            this.CurrentBrowser1.Title = "Choose file to make new versions of:";
            // 
            // CurrentBrowser2
            // 
            this.CurrentBrowser2.Title = "Choose file to make new versions of:";
            // 
            // CurrentBrowser3
            // 
            this.CurrentBrowser3.Title = "Choose file to make new versions of:";
            // 
            // SaveBrowser1
            // 
            this.SaveBrowser1.Description = "Choose where to make new versions:";
            // 
            // SaveBrowser2
            // 
            this.SaveBrowser2.Description = "Choose where to make new versions:";
            // 
            // SaveBrowser3
            // 
            this.SaveBrowser3.Description = "Choose where to make new versions:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveButton3);
            this.Controls.Add(this.SaveTextBox3);
            this.Controls.Add(this.CurrentButton3);
            this.Controls.Add(this.CurrentTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.SaveTextBox2);
            this.Controls.Add(this.CurrentButton2);
            this.Controls.Add(this.CurrentTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton1);
            this.Controls.Add(this.SaveTextBox1);
            this.Controls.Add(this.CurrentButton1);
            this.Controls.Add(this.CurrentTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.OpenFileDialog CurrentBrowser;
        private System.Windows.Forms.FolderBrowserDialog SaveBrowser;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton1;
        private System.Windows.Forms.TextBox SaveTextBox1;
        private System.Windows.Forms.Button CurrentButton1;
        private System.Windows.Forms.TextBox CurrentTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.TextBox SaveTextBox2;
        private System.Windows.Forms.Button CurrentButton2;
        private System.Windows.Forms.TextBox CurrentTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton3;
        private System.Windows.Forms.TextBox SaveTextBox3;
        private System.Windows.Forms.Button CurrentButton3;
        private System.Windows.Forms.TextBox CurrentTextBox3;
        private System.Windows.Forms.OpenFileDialog CurrentBrowser1;
        private System.Windows.Forms.OpenFileDialog CurrentBrowser2;
        private System.Windows.Forms.OpenFileDialog CurrentBrowser3;
        private System.Windows.Forms.FolderBrowserDialog SaveBrowser1;
        private System.Windows.Forms.FolderBrowserDialog SaveBrowser2;
        private System.Windows.Forms.FolderBrowserDialog SaveBrowser3;
    }
}

