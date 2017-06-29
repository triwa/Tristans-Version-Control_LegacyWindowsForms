namespace Tristans_Version_Control
{
    partial class NotificationsForm
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
            this.CurrentProcessesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NotificationsListBox = new System.Windows.Forms.ListBox();
            this.AddToNotificationsButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentProcessesListBox
            // 
            this.CurrentProcessesListBox.FormattingEnabled = true;
            this.CurrentProcessesListBox.Location = new System.Drawing.Point(16, 61);
            this.CurrentProcessesListBox.Name = "CurrentProcessesListBox";
            this.CurrentProcessesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.CurrentProcessesListBox.Size = new System.Drawing.Size(213, 290);
            this.CurrentProcessesListBox.Sorted = true;
            this.CurrentProcessesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currently open programs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notifications Enabled:";
            // 
            // NotificationsListBox
            // 
            this.NotificationsListBox.FormattingEnabled = true;
            this.NotificationsListBox.Location = new System.Drawing.Point(357, 61);
            this.NotificationsListBox.Name = "NotificationsListBox";
            this.NotificationsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.NotificationsListBox.Size = new System.Drawing.Size(213, 290);
            this.NotificationsListBox.TabIndex = 3;
            // 
            // AddToNotificationsButton
            // 
            this.AddToNotificationsButton.Location = new System.Drawing.Point(235, 178);
            this.AddToNotificationsButton.Name = "AddToNotificationsButton";
            this.AddToNotificationsButton.Size = new System.Drawing.Size(116, 56);
            this.AddToNotificationsButton.TabIndex = 4;
            this.AddToNotificationsButton.Text = "Enable Notifications for Selected";
            this.AddToNotificationsButton.UseVisualStyleBackColor = true;
            this.AddToNotificationsButton.Click += new System.EventHandler(this.AddToNotificationsButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(16, 32);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(105, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh List";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(424, 32);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(146, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove Selected";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(127, 35);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextBox.TabIndex = 0;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(16, 357);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(554, 42);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Finish";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 407);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddToNotificationsButton);
            this.Controls.Add(this.NotificationsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentProcessesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Notifications";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CurrentProcessesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox NotificationsListBox;
        private System.Windows.Forms.Button AddToNotificationsButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}