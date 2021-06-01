using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using ZXing;
using System.Threading.Tasks;

namespace VRQR
{
    public partial class Form1 : Form
    {
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //runs on program start
        public Form1()
        {
            InitializeComponent();

            //watch VRChat photos folder for any new files being created
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "VRChat");
            watcher.Filter = "*.png";
            watcher.Created += fileCreatedEvent;
            watcher.EnableRaisingEvents = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //load settings from configuration file
            checkBoxPlaySound.Checked = bool.Parse(ConfigurationManager.AppSettings["PlaySound"]);
            checkBoxOpenURL.Checked = bool.Parse(ConfigurationManager.AppSettings["OpenURL"]);
            checkBoxStartMinimized.Checked = bool.Parse(ConfigurationManager.AppSettings["startMinimized"]);

            //start program minimized to notification tray
            if (checkBoxStartMinimized.Checked)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //when a new file is created, try to decode a QR code from it
        void fileCreatedEvent(object source, FileSystemEventArgs e)
        {
            //wait for file creation to finish
            while (isFileLocked(e.FullPath)) { Thread.Sleep(100); }

            //see if the new file contains a QR code
            String result = decodeQRCode(e.FullPath);
            if (result != null)
            {
                //add scanned URL to GUI list
                Invoke((MethodInvoker)delegate
                {
                    listBoxScans.Items.Add(result);
                    listBoxScans.SelectedIndex = listBoxScans.Items.Count - 1;
                });
                //launch scanned URL in default browser and play a notification sound
                if(checkBoxOpenURL.Checked) { openURL(result); }
                if(checkBoxPlaySound.Checked) { playScannedSound(); }
            }
        }

        //open a URL in the user's default browser
        void openURL(string url)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        //play the successful scan sound
        void playScannedSound()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.ScanCompleteSound);
            sound.Play();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //check if a file is still being used by another process
        bool isFileLocked(String path)
        {
            FileStream stream = null;

            try
            {
                FileInfo file = new FileInfo(path);
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (Exception)
            {
                return true;
            }
            finally
            {
                if (stream != null) { stream.Close(); }
            }

            return false;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //try to decode text from a QR code from an image file (returns null if failed)
        string decodeQRCode(String image_path)
        {
            BarcodeReader reader = new BarcodeReader();
            Bitmap image = (Bitmap)Bitmap.FromFile(image_path);
            Result result = reader.Decode(image);
            image.Dispose();

            if (result != null)
            {
                return result.Text.Trim();
            }
            else
            {
                return null;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //GUI control events
        private void buttonOpenURL_Click(object sender, EventArgs e)
        {
            openURL(listBoxScans.SelectedItem.ToString());
        }

        private void buttonCopyURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBoxScans.SelectedItem.ToString());
        }

        private void listBoxScans_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool item_selected = listBoxScans.SelectedIndex > -1;
            buttonOpenURL.Enabled = item_selected;
            buttonCopyURL.Enabled = item_selected;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save any changed settings
            Configuration file = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = file.AppSettings.Settings;
            settings["PlaySound"].Value = checkBoxPlaySound.Checked.ToString();
            settings["OpenURL"].Value = checkBoxOpenURL.Checked.ToString();
            settings["StartMinimized"].Value = checkBoxStartMinimized.Checked.ToString();
            file.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(file.AppSettings.SectionInformation.Name);
        }
    }
}
