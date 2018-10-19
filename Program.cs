using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DiscordRpcNet;
using Microsoft.Win32;

namespace MessengerRichPresence
{
    internal static class Program
	{
		public static MainForm Form;
        public const string AppName = "Messenger Rich Presence";
        public static DiscordRpc.RichPresence CurrentPresence = new DiscordRpc.RichPresence();
        private static MessengerDotNet.MessengerContact me;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		public static void Main()
		{
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (!File.Exists(Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "discord-rpc.dll")))
                {
                    MessageBox.Show("The Discord Rich Presence DLL couldn't be found. Please re-download this program.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var i = IsInstalled();
                if (i == null)
                {
                    MessageBox.Show("Messenger seems not to be installed. Please download MSN/Windows Live Messenger.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Form = new MainForm();
                Initialize();
                if (!IsRunning())
                {
                    Process.Start(i);
                }
                Application.Run(Form);
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show($"{AppName} has crashed because of {ex.Message}. \nWould you like to copy the crash report?", AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText($"{AppName} Crash Report: \n{ex.ToString()}");
                    MessageBox.Show("The crash report has been copied. You can sent this report to Craftplacer over the MessengerGeek forum.",  AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
		}

		public static void Initialize()
		{
			var eventHandlers = new DiscordRpc.EventHandlers();
			eventHandlers.errorCallback = delegate (int code, string msg)
			{
				new Thread(Error).Start($"{code}: {msg}");
			};
			DiscordRpc.Initialize("474675525928091657", ref eventHandlers, true, "");
		}

		public static void Error(object msg) => MessageBox.Show(msg.ToString(), AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);

		public static void StartAsThread(ThreadStart t) => new Thread(t).Start();

		/// <returns><see cref="null"/> when not found</returns>
		public static string IsInstalled()
		{
			string v = null;
			var sk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\TypeLib\\{E02AD29E-80F5-46C6-B416-9B3EBDDF057E}\\1.0\\\0\\win32\\", false);
			var o = sk.GetValue(null, null);
            sk.Close();
            if (o != null && o.GetType() == typeof(string))
			{
				var s = (string)o;
				v = s.Substring(s.Length - 2);
			}
			return v;
		}

		public static bool IsRunning()
		{
			if (Process.GetProcessesByName("msnmsgr").Length == 0)
			{
				return false;
			}
			return true;
		}

		public static bool IsConnected()
		{
			if (!IsRunning())
			{
				return false;
			}
			try
			{
                if (me == null) me = MessengerDotNet.MessengerAPI.Me;
                if (me.Status == MessengerDotNet.MessengerStatus.Unknown)
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				return false;
			}
			return true;
		}

		public static void UpdatePresence()
		{
			try
			{
				if (Form != null)
				{
                    if (me == null) me = MessengerDotNet.MessengerAPI.Me;
                    var count = MessengerDotNet.MessengerAPI.Contacts.Count();
                    var stauts = me.Status;
                    var signInName = me.SignInName;
                        CurrentPresence.largeImageKey = "messenger";
						if (Form.StatusCheckBox.Checked)
						{
                            CurrentPresence.smallImageText = ToString(stauts);
                            CurrentPresence.smallImageKey = ToKey(stauts);
						}
						//Details
						if (Form.EmailCheckBox.Checked && Form.NameCheckBox.Checked) CurrentPresence.details = $"{GetFilteredName()} ({signInName})";
						else if (Form.NameCheckBox.Checked) CurrentPresence.details = GetFilteredName();
						else if (Form.EmailCheckBox.Checked) CurrentPresence.details = signInName;

                        //Invitation Stuff
                        CurrentPresence.partyMax = Form.InviteCheckBox.Checked ? 1500 : 0;
                        CurrentPresence.partySize = Form.ContactsCheckBox.Checked ? count : 1;
                        CurrentPresence.partyId = Form.InviteCheckBox.Checked ? "FriendInvite" : null;
                        CurrentPresence.joinSecret = Form.InviteCheckBox.Checked ? signInName : null;

                        //Contacts count
						if (Form.InviteCheckBox.Checked) CurrentPresence.state = Form.ContactsCheckBox.Checked ? "Contacts: " : String.Empty;
						else CurrentPresence.state = Form.ContactsCheckBox.Checked ? count.ToString() + " contacts" : String.Empty;

                        
                        DiscordRpc.UpdatePresence(ref CurrentPresence);
				}
				try
				{
					DiscordRpc.RunCallbacks();
				}
				catch (SEHException)
				{
					//Ignore
				}
			}
			catch (COMException)
			{
				//Ignore
			}
		}

		public static string GetFilteredName() => Regex.Replace(MessengerDotNet.MessengerAPI.Me.Name, "\\[[^\\]]*\\]", "");

		public static string ToString(MessengerDotNet.MessengerStatus status)
		{
			switch (status)
			{
				case MessengerDotNet.MessengerStatus.Invisible:
                case MessengerDotNet.MessengerStatus.Offline: return "Offline";
                case MessengerDotNet.MessengerStatus.Online: return "Online";
                case MessengerDotNet.MessengerStatus.Busy: return "Busy";
                case MessengerDotNet.MessengerStatus.BeRightBack: return "Be right back";
                case MessengerDotNet.MessengerStatus.Away: return "Away";
				case MessengerDotNet.MessengerStatus.OnThePhone: return "On the phone";
				case MessengerDotNet.MessengerStatus.OutToLunch: return "Out to lunch";
				default: return null;
			}
		}

		public static string ToKey(MessengerDotNet.MessengerStatus status)
		{
			switch (status)
			{
				default:
                case MessengerDotNet.MessengerStatus.Invisible:
                case MessengerDotNet.MessengerStatus.Offline:
				case MessengerDotNet.MessengerStatus.Unknown:
					return "offline";

				case MessengerDotNet.MessengerStatus.Online:
					return "online";

                case MessengerDotNet.MessengerStatus.Away:
                case MessengerDotNet.MessengerStatus.OutToLunch:
                case MessengerDotNet.MessengerStatus.BeRightBack:
                    return "away";

                case MessengerDotNet.MessengerStatus.Busy:
				case MessengerDotNet.MessengerStatus.OnThePhone:
					return "busy";
			}
		}
	}
}