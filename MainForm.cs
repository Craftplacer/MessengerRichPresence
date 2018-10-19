using System;
using System.Windows.Forms;
using DiscordRpcNet;

namespace MessengerRichPresence
{
	public partial class MainForm : Form
	{
		private const string StartupRegistryPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

		public bool NotConnectedBalloonShown = false;

		public MainForm() => InitializeComponent();

		private void UpdateTimer_Tick(object sender, EventArgs e)
		{
			if (!Program.IsConnected())
			{
				if (!NotConnectedBalloonShown)
				{
					NotifyIcon.ShowBalloonTip(1000, "Messenger is not connected or running", "Messenger Rich Presence won't work until you are online with Windows Messenger", ToolTipIcon.Warning);
					NotConnectedBalloonShown = true;
				}
			}
			else
			{
				Program.UpdatePresence();
				if (NotConnectedBalloonShown)
				{
					NotifyIcon.ShowBalloonTip(1000, "Messenger Rich Presence is running again", "You can open it by double-clicking the icon in the tray area.", ToolTipIcon.None);
					NotConnectedBalloonShown = false;
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				this.WindowState = FormWindowState.Minimized;
				e.Cancel = true;
			}
			else
			{
				NotifyIcon.Visible = false;
				DiscordRpc.Shutdown();
				SaveSettings();
			}
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				NotifyIcon.Visible = true;
			}
		}

		private void LoadSettings()
		{
			StartupCheckBox.Checked = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(StartupRegistryPath, false).GetValue("Messenger Rich Presence", null) != null;
			InviteCheckBox.Checked = Properties.Settings.Default.AllowInvites;
			EmailCheckBox.Checked = Properties.Settings.Default.SeeEmail;
			NameCheckBox.Checked = Properties.Settings.Default.SeeName;
			StatusCheckBox.Checked = Properties.Settings.Default.SeeStatus;
			ContactsCheckBox.Checked = Properties.Settings.Default.SeeContacts;
			Properties.Settings.Default.Save();
		}

		private void SaveSettings()
		{
			Properties.Settings.Default.AllowInvites = InviteCheckBox.Checked;
			Properties.Settings.Default.SeeEmail = EmailCheckBox.Checked;
			Properties.Settings.Default.SeeName = NameCheckBox.Checked;
			Properties.Settings.Default.SeeStatus = StatusCheckBox.Checked;
			Properties.Settings.Default.SeeContacts = ContactsCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void HideButton_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			NotifyIcon.Visible = false;
		}

		private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadSettings();
			if (Program.IsConnected())
			{
				NotifyIcon.ShowBalloonTip(1000, "Messenger Rich Presence is running", "You can open it by double-clicking the icon in the tray area.", ToolTipIcon.Info);
			}
		}

		private void StartupCheckBox_Click(object sender, EventArgs e)
		{
			Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(StartupRegistryPath, true);
			if (StartupCheckBox.Checked)
			{
				key.SetValue(Program.AppName, Application.ExecutablePath);
			}
			else
			{
				key.DeleteValue(Program.AppName, false);
			}
		}

		private void VersionLabel_DoubleClick(object sender, EventArgs e)
		{
			if ((ModifierKeys & Keys.Shift) != 0)
			{
				if (MessageBox.Show("Would you like to add me as friend?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					MessengerDotNet.MessengerAPI.AddContact("craftplacer@outlook.de");
			}
			else
			{
				MessageBox.Show("Coded by Craftplacer (#4006/craftplacer@outlook.de)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}