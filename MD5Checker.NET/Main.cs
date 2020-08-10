using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace MD5Checker.NET
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private static string BytesToString(byte[] hashBytes)
        {
            StringBuilder hash = new StringBuilder(32);

            foreach (byte b in hashBytes)
                hash.Append(b.ToString("X2").ToLower());

            return hash.ToString();
        }

        private void BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select a file";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.ShowDialog();
            FilePath.Text = openFileDialog1.FileName;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FilePath.Text))
            {
                MessageBox.Show("No file selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                BackgroundWorker1.RunWorkerAsync(FilePath.Text);
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string filepath = e.Argument.ToString();
            byte[] bytesBuffer;
            int bytesRead;
            long size;
            long totalBytesRead = 0;

            using (Stream file = File.OpenRead(filepath))
            {
                size = file.Length;

                using (HashAlgorithm hasher = MD5.Create())
                {
                    do
                    {
                        bytesBuffer = new byte[4096];
                        bytesRead = file.Read(bytesBuffer, 0, bytesBuffer.Length);
                        totalBytesRead += bytesRead;
                        hasher.TransformBlock(bytesBuffer, 0, bytesRead, null, 0);
                        BackgroundWorker1.ReportProgress((int)((double)totalBytesRead / size * 100));
                    }

                    while (bytesRead != 0);

                    hasher.TransformFinalBlock(bytesBuffer, 0, 0);
                    e.Result = BytesToString(hasher.Hash);

                }
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Hash.Text = e.Result.ToString();
            ProgressBar1.Value = 0;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsersHash.Text))
            {
                MessageBox.Show("No hash given for comparison.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string usershash = UsersHash.Text.ToLower();
                UsersHash.Clear();
                UsersHash.Text = usershash;

                if (usershash == Hash.Text)
                {
                    MessageBox.Show("Given hash and calculated hash are equal.", "OK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Given hash and calculated hash are not equal.", "Hash mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
