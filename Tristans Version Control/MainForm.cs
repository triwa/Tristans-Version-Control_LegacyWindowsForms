using IWshRuntimeLibrary;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Timers;
using System.Windows.Forms;

//
// This applications provides a way to incrementally back up files, and show a notification when selected programs are open.
// The notifications for programs are saved in a flat file in "//Documents/Tristan's Version Control" and are edited through the NotificationsForm.
//

namespace Tristans_Version_Control
{
    public partial class MainForm : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        private TextBox[] currentTextBoxArray;
        private TextBox[] saveTextBoxArray;

        //fileArray Structure:
        //          0           1           2               3
        //    ___________________________________________________
        //  0|  filename    extension   currentPath     SavePath
        //  ...
        private string[,] fileArray;

        private System.Timers.Timer saveTimer,
                                    appMonitorTimer;

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

            //match the tray menu to the tray icon
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            //initialize file array
            fileArray = new string[4,4];

            //group textboxes and browsers into arrays for looping functions
            groupTextBoxesAndBrowsers();

            //start application minimized
            WindowState = FormWindowState.Minimized;

            //instantiate timers and start the app monitor timer to see if adobe animate is open
            saveTimer = new System.Timers.Timer();
            appMonitorTimer = new System.Timers.Timer();

            appMonitorTimer.Elapsed += AppMonitorTimer_Tick;
            saveTimer.Elapsed += saveTimer_Tick;

            appMonitorTimer.Interval = 10000;
            appMonitorTimer.Start();

            //add program to startup folder if it isn't already
            string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(startupFolder + "\\Tristans Version Control.lnk");
            shortcut.Description = "Tristans Version Control";
            shortcut.TargetPath = Directory.GetCurrentDirectory() + "\\Tristans Version Control.exe";
            shortcut.Save();
        }

        private void groupTextBoxesAndBrowsers()
        {
            currentTextBoxArray = new TextBox[4];
            saveTextBoxArray = new TextBox[4];

            currentTextBoxArray[0] = CurrentTextBox;
            currentTextBoxArray[1] = CurrentTextBox1;
            currentTextBoxArray[2] = CurrentTextBox2;
            currentTextBoxArray[3] = CurrentTextBox3;

            saveTextBoxArray[0] = SaveTextBox;
            saveTextBoxArray[1] = SaveTextBox1;
            saveTextBoxArray[2] = SaveTextBox2;
            saveTextBoxArray[3] = SaveTextBox3;
        }

        //close application when exit button in tray menu is pressed
        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        //show settings window when settings button in tray menu is pressed
        private void OpenSettings(object sender, EventArgs e)
        {
            Invoke(new Action(() => 
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                Visible = true;
                TopMost = true;
                TopMost = false;
            }));
        }

        //browse button to select the file to backup
        private void CurrentButton_Click(object sender, EventArgs e)
        {
            CurrentBrowser.ShowDialog();
            CurrentTextBox.Text = CurrentBrowser.FileName;

            //set save path to same as selected file and create a new folder "\Version History" there for the backups to save in.
            try
            {
                string pathOfCurrent = Path.GetDirectoryName(CurrentBrowser.FileName);
                SaveTextBox.Text = pathOfCurrent + "\\" + Path.GetFileNameWithoutExtension(CurrentTextBox.Text) + " Version History\\";
                SaveBrowser.SelectedPath = pathOfCurrent;
            }
            catch (Exception)
            {
            }
        }

        private void CurrentButton1_Click(object sender, EventArgs e)
        {
            CurrentBrowser1.ShowDialog();
            CurrentTextBox1.Text = CurrentBrowser1.FileName;

            try
            {
                //set save path to same as selected file and create a new folder "\Version History" there for the backups to save in.
                string pathOfCurrent = Path.GetDirectoryName(CurrentBrowser1.FileName);
                SaveTextBox1.Text = pathOfCurrent + "\\" + Path.GetFileNameWithoutExtension(CurrentTextBox1.Text) + " Version History\\";
                SaveBrowser1.SelectedPath = pathOfCurrent;
            }
            catch (Exception)
            {
            }
        }

        private void CurrentButton2_Click(object sender, EventArgs e)
        {
            CurrentBrowser2.ShowDialog();
            CurrentTextBox2.Text = CurrentBrowser2.FileName;

            try
            {
                //set save path to same as selected file and create a new folder "\Version History" there for the backups to save in.
                string pathOfCurrent = Path.GetDirectoryName(CurrentBrowser2.FileName);
                SaveTextBox2.Text = pathOfCurrent + "\\" + Path.GetFileNameWithoutExtension(CurrentTextBox2.Text) + " Version History\\";
                SaveBrowser2.SelectedPath = pathOfCurrent;
            }
            catch (Exception)
            {
            }
        }

        private void CurrentButton3_Click(object sender, EventArgs e)
        {
            CurrentBrowser3.ShowDialog();
            CurrentTextBox3.Text = CurrentBrowser3.FileName;

            try
            {
                //set save path to same as selected file and create a new folder "\Version History" there for the backups to save in.
                string pathOfCurrent = Path.GetDirectoryName(CurrentBrowser3.FileName);
                SaveTextBox3.Text = pathOfCurrent + "\\" + Path.GetFileNameWithoutExtension(CurrentTextBox3.Text) + " Version History\\";
                SaveBrowser3.SelectedPath = pathOfCurrent;
            }
            catch (Exception)
            {
            }
        }

        //browse button to select the folder to save backups in
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveBrowser.ShowDialog();

            try
            {
                SaveTextBox.Text = SaveBrowser.SelectedPath + "\\";
            }
            catch (Exception)
            {
            }
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            SaveBrowser1.ShowDialog();

            try
            {
                SaveTextBox1.Text = SaveBrowser1.SelectedPath + "\\";
            }
            catch (Exception)
            {
            }
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            SaveBrowser2.ShowDialog();

            try
            {
                SaveTextBox2.Text = SaveBrowser2.SelectedPath + "\\";
            }
            catch (Exception)
            {
            }
        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            SaveBrowser3.ShowDialog();

            try
            {
                SaveTextBox3.Text = SaveBrowser3.SelectedPath + "\\";
            }
            catch (Exception)
            {
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            saveTimer.Stop();

            for (int i = 0; i < 4; i++)
            {
                saveTextBoxArray[i].Text = "";
                currentTextBoxArray[i].Text = "";
            }
        }

        //hide settings window when finish button is pressed
        private void FinishButton_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() => { ShowInTaskbar = false; }));

            for (int i = 0; i < 4; i++)
            {
                if (currentTextBoxArray[i].Text != "" || saveTextBoxArray[i].Text != "")
                {
                    //add "\" to the end of the save path text box to make sure it saves into the new folder created instead of going into the root directory.
                    saveTextBoxArray[i].Text = saveTextBoxArray[i].Text;
                }
            }

            if (CurrentTextBox.Text != "" || SaveTextBox.Text != "" ||
                CurrentTextBox1.Text != "" || SaveTextBox1.Text != "" ||
                CurrentTextBox2.Text != "" || SaveTextBox2.Text != "" ||
                CurrentTextBox3.Text != "" || SaveTextBox3.Text != "")
            {
                VersionControlFunction();
            }

            Invoke(new Action(() => { WindowState = FormWindowState.Minimized; }));
            Invoke(new Action(() => { Visible = false; }));
        }

        //save settings to local variables and set up the timer
        private void VersionControlFunction()
        {
            //fileArray Structure:
            //          0           1           2               3
            //    ___________________________________________________
            //  0|  filename    extension   currentPath     SavePath
            //  ...
            for (int i = 0; i < 4; i++)
            {
                fileArray[i, 0] = Path.GetFileNameWithoutExtension(currentTextBoxArray[i].Text);
                fileArray[i, 1] = Path.GetExtension(currentTextBoxArray[i].Text);
                fileArray[i, 2] = currentTextBoxArray[i].Text;
                fileArray[i, 3] = saveTextBoxArray[i].Text;
            }

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
            for (int i = 0; i < 4; i++)
            {
                if (fileArray[i,3] != "")
                {
                    Directory.CreateDirectory(fileArray[i,3]);

                    //instantly saves a backup to the selected folder in savepath
                    string fileCopy = saveTextBoxArray[i].Text + fileArray[i, 0] + " " + DateTime.Now.ToString().Replace(":", ".").Replace("/", "-") + fileArray[i, 1];
                    System.IO.File.Copy(fileArray[i,2], fileCopy);
                }
            }

            //start timer
            saveTimer.Interval = timerInterval;
            saveTimer.Start();
        }

        //make a backup every time the timer reaches the set interval
        private void saveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (fileArray[i, 3] != "")
                {
                    string fileCopy = saveTextBoxArray[i].Text + fileArray[i, 0] + " " + DateTime.Now.ToString().Replace(":", ".").Replace("/", "-") + fileArray[i, 1];
                    System.IO.File.Copy(fileArray[i, 2], fileCopy);
                }
            }
        }

        //makes sure to get rid of the tray icon and close the timer when application is closed
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            trayIcon.Visible = false;
            saveTimer.Stop();
        }

        //checks current process list for adobe animate
        //if any of the processes with notifications enabled is running, show a popup message to open this application
        string[] notificationProcessesList;
        private void AppMonitorTimer_Tick(object sender, EventArgs e)
        {
            //get processes that should recieve notifications
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string saveDirectory = documentsPath + "\\Tristan's Version Control";
            string saveFile = saveDirectory + "\\notifications.tristan";

            if (System.IO.File.Exists(saveFile))
            {
                StreamReader reader = new StreamReader(saveFile);
                notificationProcessesList = reader.ReadToEnd().Split('\n');
                reader.Close();

                Process[] existingProcessesWithNotifications;
                bool isProcessRunning = false;
                //if a process with notifications enabled is running, set IsProcessesRunning to true
                foreach (string element in notificationProcessesList)
                {
                    existingProcessesWithNotifications = Process.GetProcessesByName(element);

                    if (existingProcessesWithNotifications.Length >= 1)
                    {
                        isProcessRunning = true;
                    }
                }

                //if a process with notifications enabled is running, show a popup asking to open this program
                if (isProcessRunning)
                {
                    //changes elapsed event handler to AppMonitorTimer_Dismissed_Tick.
                    //this checks to see if all the programs have been closed before changing it back to this event handler.
                    //this is done so the popup doesn't come up every time the app monitor timer goes off.
                    appMonitorTimer.Elapsed -= AppMonitorTimer_Tick;
                    appMonitorTimer.Elapsed += AppMonitorTimer_Dismissed_Tick;

                    SoundPlayer player = new SoundPlayer(Resources.bigGuy);
                    player.Play();

                    DialogResult result = MessageBox.Show("Wew lad, I see one of your programs set to have notifications is open. You wanna start backing up your files?",
                                                          "WEW",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question,
                                                          MessageBoxDefaultButton.Button1,
                                                          MessageBoxOptions.ServiceNotification);

                    //if yes is selected in the popup, open this program
                    if (result == DialogResult.Yes)
                    {
                        player.Stream = Resources.forYou;
                        player.Play();

                        OpenSettings(null, null);
                    }
                }
            }
        }

        //this checks to see if all the programs have been closed before changing the app monitor event handler back to AppMonitorTimer_Tick.
        //this is done so the popup doesn't come up every time the app monitor timer goes off.
        private void AppMonitorTimer_Dismissed_Tick(object sender, ElapsedEventArgs e)
        {
            foreach (string element in notificationProcessesList)
            {
                Process[] existingProcessesWithNotifications = Process.GetProcessesByName(element);

                if (existingProcessesWithNotifications.Length == 0)
                {
                    appMonitorTimer.Elapsed -= AppMonitorTimer_Dismissed_Tick;
                    appMonitorTimer.Elapsed += AppMonitorTimer_Tick;
                }
            }
        }


        //shows the notifications window where a user can select one of the running applications to have notifications for in the future.
        //a notification comes up when selected programs are detected as being opened
        private void NotificationsButton_Click(object sender, EventArgs e)
        {
            NotificationsForm notificationsForm = new NotificationsForm();
            notificationsForm.ShowDialog();
        }
    }
}