namespace MessengerRichPresence
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
            System.Windows.Forms.Timer UpdateTimer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HideButton = new System.Windows.Forms.Button();
            this.PrivacyGroupBox = new System.Windows.Forms.GroupBox();
            this.ContactsCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusCheckBox = new System.Windows.Forms.CheckBox();
            this.EmailCheckBox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.InviteCheckBox = new System.Windows.Forms.CheckBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.VersionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.PrivacyGroupBox.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            UpdateTimer.Enabled = true;
            UpdateTimer.Interval = 5;
            UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.Location = new System.Drawing.Point(468, 341);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(75, 23);
            this.HideButton.TabIndex = 0;
            this.HideButton.Text = "&Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // PrivacyGroupBox
            // 
            this.PrivacyGroupBox.AutoSize = true;
            this.PrivacyGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrivacyGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PrivacyGroupBox.Controls.Add(this.ContactsCheckBox);
            this.PrivacyGroupBox.Controls.Add(this.StatusCheckBox);
            this.PrivacyGroupBox.Controls.Add(this.EmailCheckBox);
            this.PrivacyGroupBox.Controls.Add(this.NameCheckBox);
            this.PrivacyGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrivacyGroupBox.Location = new System.Drawing.Point(15, 81);
            this.PrivacyGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.PrivacyGroupBox.Name = "PrivacyGroupBox";
            this.PrivacyGroupBox.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.PrivacyGroupBox.Size = new System.Drawing.Size(531, 128);
            this.PrivacyGroupBox.TabIndex = 1;
            this.PrivacyGroupBox.TabStop = false;
            this.PrivacyGroupBox.Text = "Privacy Settings";
            // 
            // ContactsCheckBox
            // 
            this.ContactsCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactsCheckBox.Image = global::MessengerRichPresence.Properties.Resources.friends;
            this.ContactsCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactsCheckBox.Location = new System.Drawing.Point(6, 96);
            this.ContactsCheckBox.Name = "ContactsCheckBox";
            this.ContactsCheckBox.Size = new System.Drawing.Size(519, 26);
            this.ContactsCheckBox.TabIndex = 8;
            this.ContactsCheckBox.Text = "Display my amount of contacts";
            this.ContactsCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ContactsCheckBox.UseVisualStyleBackColor = true;
            // 
            // StatusCheckBox
            // 
            this.StatusCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusCheckBox.Image = global::MessengerRichPresence.Properties.Resources.status;
            this.StatusCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusCheckBox.Location = new System.Drawing.Point(6, 70);
            this.StatusCheckBox.Name = "StatusCheckBox";
            this.StatusCheckBox.Size = new System.Drawing.Size(519, 26);
            this.StatusCheckBox.TabIndex = 2;
            this.StatusCheckBox.Text = "Display my status";
            this.StatusCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmailCheckBox
            // 
            this.EmailCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailCheckBox.Image = global::MessengerRichPresence.Properties.Resources.email;
            this.EmailCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmailCheckBox.Location = new System.Drawing.Point(6, 44);
            this.EmailCheckBox.Name = "EmailCheckBox";
            this.EmailCheckBox.Size = new System.Drawing.Size(519, 26);
            this.EmailCheckBox.TabIndex = 7;
            this.EmailCheckBox.Text = "Display my email address";
            this.EmailCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmailCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.Checked = true;
            this.NameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NameCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameCheckBox.FlatAppearance.BorderSize = 0;
            this.NameCheckBox.Image = global::MessengerRichPresence.Properties.Resources.name;
            this.NameCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameCheckBox.Location = new System.Drawing.Point(6, 18);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(519, 26);
            this.NameCheckBox.TabIndex = 6;
            this.NameCheckBox.Text = "Display my name";
            this.NameCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(387, 341);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingsGroupBox.Controls.Add(this.StartupCheckBox);
            this.SettingsGroupBox.Controls.Add(this.InviteCheckBox);
            this.SettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsGroupBox.Location = new System.Drawing.Point(15, 209);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.SettingsGroupBox.Size = new System.Drawing.Size(531, 72);
            this.SettingsGroupBox.TabIndex = 3;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Other Settings";
            // 
            // StartupCheckBox
            // 
            this.StartupCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartupCheckBox.Image = global::MessengerRichPresence.Properties.Resources.startup;
            this.StartupCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartupCheckBox.Location = new System.Drawing.Point(6, 44);
            this.StartupCheckBox.Name = "StartupCheckBox";
            this.StartupCheckBox.Size = new System.Drawing.Size(519, 26);
            this.StartupCheckBox.TabIndex = 1;
            this.StartupCheckBox.Text = "Start with Windows";
            this.StartupCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // InviteCheckBox
            // 
            this.InviteCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InviteCheckBox.Image = global::MessengerRichPresence.Properties.Resources.add;
            this.InviteCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InviteCheckBox.Location = new System.Drawing.Point(6, 18);
            this.InviteCheckBox.Name = "InviteCheckBox";
            this.InviteCheckBox.Size = new System.Drawing.Size(519, 26);
            this.InviteCheckBox.TabIndex = 0;
            this.InviteCheckBox.Text = "Enable invites";
            this.InviteCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InviteCheckBox.UseVisualStyleBackColor = true;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Messenger Rich Presence";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // ToolTip
            // 
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.VersionLabel.Location = new System.Drawing.Point(18, 346);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(154, 13);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "Messenger Rich Presence 1.5";
            this.VersionLabel.DoubleClick += new System.EventHandler(this.VersionLabel_DoubleClick);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.TitleLabel.Location = new System.Drawing.Point(15, 50);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TitleLabel.Size = new System.Drawing.Size(246, 31);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = "Messenger Rich Presence Settings";
            // 
            // MainForm
            // 
            this.AcceptButton = this.HideButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MessengerRichPresence.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(561, 382);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PrivacyGroupBox);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15, 50, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger Rich Presence";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.PrivacyGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button HideButton;
		private System.Windows.Forms.GroupBox PrivacyGroupBox;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.GroupBox SettingsGroupBox;
		public System.Windows.Forms.CheckBox StatusCheckBox;
		public System.Windows.Forms.CheckBox InviteCheckBox;
		private System.Windows.Forms.ToolTip ToolTip;
		private System.Windows.Forms.Label VersionLabel;
		public System.Windows.Forms.CheckBox EmailCheckBox;
		public System.Windows.Forms.CheckBox NameCheckBox;
		public System.Windows.Forms.NotifyIcon NotifyIcon;
		private System.Windows.Forms.Label TitleLabel;
		public System.Windows.Forms.CheckBox StartupCheckBox;
		public System.Windows.Forms.CheckBox ContactsCheckBox;
	}
}

