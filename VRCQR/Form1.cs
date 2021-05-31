using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using ZXing;

namespace VRCQR
{
    public partial class Form1 : Form
    {
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //runs on program start
        public Form1()
        {
            InitializeComponent();

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "VRChat");
            watcher.Filter = "*.png";
            watcher.Created += fileCreatedEvent;
            watcher.EnableRaisingEvents = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //when a new file is created, try to decode a QR code from it
        void fileCreatedEvent(object source, FileSystemEventArgs e)
        {
            //wait for file creation to finish
            while (isFileLocked(e.FullPath)) { Thread.Sleep(100); }

            //see if the new file contains a QR code
            String result = decodeQRCode(e.FullPath);
            if(result != null)
            {
                //add scanned URL to GUI list
                Invoke((MethodInvoker)delegate
                {
                    listBoxHistory.Items.Add(result);
                    listBoxHistory.SelectedIndex = listBoxHistory.Items.Count - 1;
                });
                //launch scanned URL in default browser and play a notification sound
                openURL(result);
                playScannedSound();
            }
        }

        void openURL(string url)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        void playScannedSound()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.scanned);
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
            catch(Exception)
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

            if(result != null)
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
        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxHistory.SelectedIndex > -1)
            {
                buttonCopy.Enabled = true;
                buttonOpenInBrowser.Enabled = true;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBoxHistory.SelectedItem.ToString());
        }

        private void buttonOpenInBrowser_Click(object sender, EventArgs e)
        {
            openURL(listBoxHistory.SelectedItem.ToString());
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VRCQR automatically scans QR codes in photos you take in VRChat.\n\nCreated by Frost Sheridan\ngithub.com/frostion", "About VRCQR");
        }
    }
}
