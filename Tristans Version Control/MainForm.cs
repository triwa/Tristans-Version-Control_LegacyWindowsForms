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

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Settings", OpenSettings);
            trayMenu.MenuItems.Add("Exit", OnExit);

            trayIcon = new NotifyIcon();
            trayIcon.Text = "Tristan's Version Control";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Visible = true;
            ShowInTaskbar = true;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            CurrentBrowser.ShowDialog();
            CurrentTextBox.Text = CurrentBrowser.FileName;

            //set save path to same as selected file and appends a new folder there for the versions to save in.
            string pathOfCurrent = Path.GetDirectoryName(CurrentBrowser.FileName);
            SaveTextBox.Text = "" + pathOfCurrent + "\\Version History\\";
            SaveBrowser.SelectedPath = pathOfCurrent;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveBrowser.ShowDialog();
            SaveTextBox.Text = SaveBrowser.SelectedPath;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            SaveTextBox.Text = SaveTextBox.Text + "\\";
            VersionControlFunction();
        }

        private void VersionControlFunction()
        {
            currentPath = CurrentTextBox.Text;
            savePath = SaveTextBox.Text;
            filename = Path.GetFileName(CurrentBrowser.FileName);
            filename = filename.Substring(0, filename.Length - 3);
            extension = Path.GetExtension(CurrentBrowser.FileName);

            int timerInterval = 1800000;
            
            try
            {
                timerInterval = int.Parse(TimeTextBox.Text) * 60000;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Visible = true;
            }

            Directory.CreateDirectory(savePath);
            savePath = SaveTextBox.Text + filename + DateTime.Now.ToString().Replace(":", ".").Replace("/","-") + extension;
            File.Copy(currentPath, savePath);

            Timer.Interval = timerInterval;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            savePath = SaveTextBox.Text + filename + DateTime.Now.ToString().Replace(":",".").Replace("/", "-") + extension;
            File.Copy(currentPath, savePath);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            trayIcon.Visible = false;
            Timer.Stop();
        }
    }
}
