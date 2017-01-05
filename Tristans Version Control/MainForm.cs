using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Tristans_Version_Control
{
    public partial class MainForm : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private string currentPath;
        private string savePath;
        private string filename;
        private string extension;
        private System.Timers.Timer timer, appMonitorTimer;

        public MainForm()
        {
            InitializeComponent();

            //initialize tray icon menu
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Settings", OpenSettings);
            trayMenu.MenuItems.Add("Exit", OnExit);

            //initialize tray icon image
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Tristan's Version Control";
            trayIcon.Icon = Icon;

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            //start application minimized
            WindowState = FormWindowState.Minimized;

            //instantiate timers and start the app monitor timer to see if adobe animate is open
            timer = new System.Timers.Timer();
            appMonitorTimer = new System.Timers.Timer();

            appMonitorTimer.Elapsed += AppMonitorTimer_Tick;
            timer.Elapsed += Timer_Tick;

            appMonitorTimer.Interval = 10000;
            appMonitorTimer.Start();
            
        }

        //close application when exit button in tray menu is pressed
        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        //show settings window when settings button in tray menu is pressed
        private void OpenSettings(object sender, EventArgs e)
        {
            Invoke(new Action(() => { WindowState = FormWindowState.Normal; }));
            Invoke(new Action(() => { ShowInTaskbar = true; }));
            Invoke(new Action(() => { Visible = true; }));
        }

        //browse button to select the file to backup
        private void CurrentButton_Click(object sender, EventArgs e)
        {
            CurrentBrowser.ShowDialog();
            CurrentTextBox.Text = CurrentBrowser.FileName;

            //set save path to same as selected file and create a new folder "\Version History" there for the backups to save in.
            string pathOfCurrent = Path.GetDirectoryName(CurrentBrowser.FileName);
            SaveTextBox.Text = "" + pathOfCurrent + "\\Version History\\";
            SaveBrowser.SelectedPath = pathOfCurrent;
        }

        //browse button to select the folder to save backups in
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveBrowser.ShowDialog();
            SaveTextBox.Text = SaveBrowser.SelectedPath;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SaveTextBox.Text = "";
            CurrentTextBox.Text = "";
        }

        //hide settings window when finish button is pressed
        private void FinishButton_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() => { ShowInTaskbar = false; }));

            if (CurrentTextBox.Text != "" || SaveTextBox.Text != "")
            {
                //add "\" to the end of the save path text box to make sure it saves into the new folder created instead of going into the root directory.
                SaveTextBox.Text = SaveTextBox.Text + "\\";

                VersionControlFunction();
            }

            Invoke(new Action(() => { WindowState = FormWindowState.Minimized; }));
            Invoke(new Action(() => { Visible = false; }));
        }

        //save settings to local variables and set up the timer
        private void VersionControlFunction()
        {
            currentPath = CurrentTextBox.Text;
            savePath = SaveTextBox.Text;
            filename = Path.GetFileName(CurrentBrowser.FileName);
            filename = filename.Substring(0, filename.Length - 3);
            extension = Path.GetExtension(CurrentBrowser.FileName);

            //set timer to default 30 minutes
            int timerInterval = 1800000;

            //timer interval is (x minutes * 60,000) to convert from minutes to milliseconds
            try
            {
                timerInterval = int.Parse(TimeTextBox.Text) * 60000;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Visible = true;
            }

            //creates new folder if needed
            Directory.CreateDirectory(savePath);

            //instantly saves a backup to the selected folder in savepath
            savePath = SaveTextBox.Text + filename + DateTime.Now.ToString().Replace(":", ".").Replace("/","-") + extension;
            File.Copy(currentPath, savePath);

            //start timer
            timer.Interval = timerInterval;
            timer.Start();
        }

        //make a backup every time the timer reaches the set interval
        private void Timer_Tick(object sender, EventArgs e)
        {
            savePath = SaveTextBox.Text + filename + DateTime.Now.ToString().Replace(":",".").Replace("/", "-") + extension;
            File.Copy(currentPath, savePath);
        }

        //makes sure to get rid of the tray icon and close the timer when application is closed
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            trayIcon.Visible = false;
            timer.Stop();
        }

        //checks current process list for adobe animate
        //if animate is open, show a popup message to launch this application
        private void AppMonitorTimer_Tick(object sender, EventArgs e)
        {
            Process[] animate = Process.GetProcessesByName("Animate");

            //if there is a process called animate, show popup
            if (animate.Length == 1)
            {
                appMonitorTimer.Stop();

                DialogResult result = MessageBox.Show("Wew lad, I see animate is open. You wanna start backing up your shit?",
                                                      "WEW",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question,
                                                      MessageBoxDefaultButton.Button1,
                                                      MessageBoxOptions.ServiceNotification);
                if (result == DialogResult.Yes)
                {
                    OpenSettings(null, null);
                }

                animate[0].EnableRaisingEvents = true;
                animate[0].Exited += new EventHandler(AnimateClosed);
            }
        }

        //if animate is closed, start the AppMonitor timer again
        private void AnimateClosed(object sender, EventArgs e)
        {
            appMonitorTimer.Start();
        }
    }
}