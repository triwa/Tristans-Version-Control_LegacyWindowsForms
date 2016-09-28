using System;
using System.Drawing;
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
        }

        //close application when exit button in tray menu is pressed
        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        //show settings window when settings button in tray menu is pressed
        private void OpenSettings(object sender, EventArgs e)
        {
            Visible = true;
            ShowInTaskbar = true;
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

        //hide settings window when finish button is pressed
        private void FinishButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            //add "\" to the end of the save path text box to make sure it saves into the new folder created instead of going into the root directory.
            SaveTextBox.Text = SaveTextBox.Text + "\\";
            VersionControlFunction();
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
            Timer.Interval = timerInterval;
            Timer.Start();
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
            Timer.Stop();
        }
    }
}
