using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.IO;

//
// This form handles which applications can get notifications. 
// The programs selected for notifications are saved to a flat file in my documents under the "Tristan's Version Control" folder.
//

namespace Tristans_Version_Control
{
    public partial class NotificationsForm : Form
    {
        string saveFile;
        string[] processNames;

        public NotificationsForm()
        {
            InitializeComponent();
            RefreshProcessList();

            //create directory in user documents to store the notification settings
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string saveDirectory = documentsPath + "\\Tristan's Version Control";
            saveFile = saveDirectory + "\\notifications.tristan";
            Directory.CreateDirectory(saveDirectory);

            //load settings if they exist
            if (File.Exists(saveFile))
            {
                LoadSettings();
            }
        }

        private void RefreshButton_Click(object sender, System.EventArgs e)
        {
            RefreshProcessList();
        }

        private void FilterTextBox_TextChanged(object sender, System.EventArgs e)
        {
            FilterProcessList();
        }

		//retrieves programs that are enabled for notifications form the flat file
        private void LoadSettings()
        {
            StreamReader reader = new StreamReader(saveFile);
            string settingsRaw = reader.ReadToEnd();
            reader.Close();

            if (settingsRaw=="")
            {
                NotificationsListBox.Items.Clear();
            }
            else
            {
                string[] settingsArray = settingsRaw.Split('\n');
                NotificationsListBox.Items.AddRange(settingsArray);
            }
        }

        //puts selected processes into the notifications list and deselects everything in the current processes list
        private void AddToNotificationsButton_Click(object sender, EventArgs e)
        {
            var selectedProcesses = CurrentProcessesListBox.SelectedItems;

            foreach (var item in selectedProcesses)
            {
                NotificationsListBox.Items.Add(item);
            }

            CurrentProcessesListBox.ClearSelected();
        }

        //removes selected items from notificationslist
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            for (int i = NotificationsListBox.SelectedItems.Count - 1; i >= 0; i--)
            {
                int idx = NotificationsListBox.SelectedIndices[i];
                NotificationsListBox.Items.RemoveAt(idx);
            }
        }

        private void RefreshProcessList()
        {
            //retrieve the names of all the currently running processes
            processNames = Process.GetProcesses().Select(item => item.ProcessName).ToArray();

            //apply a filter if there is one
            if (FilterTextBox.Text == "")
            {
                CurrentProcessesListBox.DataSource = processNames;
            }
            else
            {
                FilterProcessList();
            }
        }

		//changes the list of programs to match what is typed in the filter textbox
        private void FilterProcessList()
        {
            string[] filteredProcessNames = processNames.Where(item => item.ToLower().Contains(FilterTextBox.Text)).ToArray();
            CurrentProcessesListBox.DataSource = filteredProcessNames;
        }

        //creates the file that stores the settings in saveDirectory
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(saveFile);

            for (int i = 0; i < NotificationsListBox.Items.Count; i++)
            {
                //no new line character for the last item
                if (i == NotificationsListBox.Items.Count-1)
                {
                    writer.Write(NotificationsListBox.Items[i]);
                }
                else
                {
                    writer.Write(NotificationsListBox.Items[i] + "\n");
                }
            }

            writer.Close();
            Close();
        }
    }
}