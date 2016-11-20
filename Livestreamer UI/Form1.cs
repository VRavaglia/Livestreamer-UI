using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using System.IO;

namespace Livestreamer_UI
{
    public partial class Main_Form : Form
    {
        private string filePath = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LivestreamerUI\\Favorites.txt");
        private TwitchHelper helper = new TwitchHelper();
        public Main_Form()
        {
            InitializeComponent();
            helper.Callback += Helper_Callback;

        }
        List<string> onlineStreamList = new List<string>();


        private void Helper_Callback(object sender, TwitchHelper.AreOnlineCallbackEventArgs e)
        {
            //MessageBox.Show(String.Join("\n", e.Streams));            
                
            string onlineStreams = "These streams came online:\n";

            foreach (ListViewItem stream in Favorites_ListView.Items)
            {

                if (e.Streams.Contains(stream.SubItems[0].Text))
                {
                    if (stream.SubItems[3].Text.Equals("No"))
                    {
                        onlineStreams = onlineStreams + stream.SubItems[0].Text + "\n";

                    }
                    stream.SubItems[3].Text = "Yes";
                }
                else
                {
                    stream.SubItems[3].Text = "No";
                }
            }
                                      
            if (!onlineStreams.Equals("These streams came online:\n") && FormWindowState.Minimized == this.WindowState)
            {
                Main_NotifyIcon.BalloonTipText = onlineStreams;
                Main_NotifyIcon.BalloonTipTitle = "Livestreamer UI";
                Main_NotifyIcon.ShowBalloonTip(500);
            }



        }

        private void updateList()
        {
            List<string> favoritesList = new List<string>();

            foreach (ListViewItem streamItem in Favorites_ListView.Items)
            {
                favoritesList.Add(streamItem.SubItems[1].Text + ";" + streamItem.SubItems[0].Text + ";" + streamItem.SubItems[2].Text);
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in favoritesList)
                {
                    writer.WriteLine(line);
                }
            }

            Favorites_ListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            Favorites_ListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private List<string> readFavorites()
        {

            string favorites = filePath;

            string[] lines = File.ReadAllLines(favorites);

            List<string> favoritesList = new List<string>();

            foreach (string stream in lines)
            {
                favoritesList.Add(stream);
            }

            return favoritesList;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Quality_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Quality_ComboBox.SelectedItem = "High";
            string directoryFavorites = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LivestreamerUI");
            if (!Directory.Exists(directoryFavorites))
            {
                Directory.CreateDirectory(directoryFavorites);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            var tocheck = new List<string>();
            foreach (string line in readFavorites())
            {
                if (line != null)
                {
                    string[] ineount = line.Split(';');

                    ListViewItem item = new ListViewItem(ineount[1]);
                    item.SubItems.Add(ineount[0]);
                    item.SubItems.Add(ineount[2]);
                    item.SubItems.Add("No");
                    Favorites_ListView.Items.Add(item);
                    tocheck.Add(ineount[0]);
                }

            }

            helper.AreOnline(tocheck.ToArray());
            Favorites_ListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            Favorites_ListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            if(Favorites_ListView.Items.Count == 0)
            {
                Favorites_ListView.Columns[0].Width = -2;
                Favorites_ListView.Columns[1].Width = -2;
            }
            else
            {
                Favorites_ListView.Columns[1].Width = -1;
            }
        }

        private void launchstream(string streamtogo)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "livestreamer";
            startInfo.Arguments = streamtogo;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void PlayStream_Clicked(object sender, EventArgs e)
        {
            string stream = Stream_TextBox.Text,
                command = Source_TextBox.Text + "/" + stream + " " + Quality_ComboBox.Text;
            launchstream(command);           
        }

        private void Favorites_ListView_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem savedstream in Favorites_ListView.SelectedItems)
            {
                
                string command = savedstream.SubItems[1].Text + "/" + savedstream.SubItems[0].Text + " " + savedstream.SubItems[2].Text;
                launchstream(command);        
            }
        }

        private void DeleteSaved_Clicked(object sender, EventArgs e)
        {

            if (Favorites_ListView.SelectedItems.Count > 0)
            {
                var selected = Favorites_ListView.SelectedItems[0];

                Favorites_ListView.Items[selected.Index].Remove();               

                updateList();
            }

            if(Favorites_ListView.Items.Count == 0)
            {
                Favorites_ListView.Columns[0].Width = -2;
                Favorites_ListView.Columns[1].Width = -2;
            }
        }

        private void SaveStream_Clicked(object sender, EventArgs e)
        {
            if(!Source_TextBox.Text.Equals("") && !Quality_ComboBox.Text.Equals("Quality") && !Stream_TextBox.Text.Equals(""))
            {
                ListViewItem item = new ListViewItem(Stream_TextBox.Text);
                item.SubItems.Add(Source_TextBox.Text);
                item.SubItems.Add(Quality_ComboBox.Text);
                item.SubItems.Add("No");
                Favorites_ListView.Items.Add(item);

                updateList();

                List<string> tocheck = new List<string>();
                foreach (ListViewItem listItem in Favorites_ListView.Items)
                {
                    tocheck.Add(listItem.SubItems[0].Text);
                }

                helper.AreOnline(tocheck.ToArray());
               
            }
            
        }

        private void Help_Clicked(object sender, EventArgs e)
        {          
            MessageBox.Show("Se vira parça!");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            List<string> tocheck = new List<string>();
            foreach (ListViewItem listItem in Favorites_ListView.Items)
            {
                tocheck.Add(listItem.SubItems[0].Text);
            }

            helper.AreOnline(tocheck.ToArray());
            //MessageBox.Show("Tick");
        }

        private void About_Clicked(object sender, EventArgs e)
        {
            string softwareVersion = "1.0";
            MessageBox.Show("User interface for https://github.com/chrippa/livestreamer" + "\n\nCreated by Victor Ravaglia" + "\n\n" + "Version: " + softwareVersion);
        }

        private void Main_Form_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {

                //Main_NotifyIcon.BalloonTipText = "Livestreamer UI will search for online streams every minute.";
                //Main_NotifyIcon.BalloonTipTitle = "Livestreamer UI";
                //Main_NotifyIcon.ShowBalloonTip(500);
                Main_NotifyIcon.Visible = true;
                
                Main_NotifyIcon.Text = "Livestreamer UI will search for online streams every minute.";
                ShowInTaskbar = false;

            }
        }

        private void mynotifyicon_doubleclick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            Main_NotifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
