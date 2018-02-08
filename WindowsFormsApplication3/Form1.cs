using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.Security.Cryptography;
using Ionic.Zip;
using ComponentFactory.Krypton.Toolkit;
using System.Globalization;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication3
{
    public partial class Form1 : KryptonForm
    {
                // string startPath = @"c:\example\start";
           // string zipPath = @"c:\example\result.zip";
           // string extractPath = @"c:\example\extract";
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1 = new BackgroundWorker();

            // Create a background worker thread that ReportsProgress &
            // SupportsCancellation
            // Hook up the appropriate events.
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler
                    (backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }
        string zipPath = @"tc2.dat";
        string extractPath = Environment.GetEnvironmentVariable("ProgramFiles") + @"\Microsoft Games" + @"\";
        string strPath;
        [DllImport("shell32.dll")]
        static extern bool SHGetSpecialFolderPath(IntPtr hwndOwner, [Out] StringBuilder lpszPath, int nFolder, bool fCreate);
        const int CSIDL_COMMON_DESKTOPDIRECTORY = 0x19;
        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // The background process is complete. We need to inspect
            // our response to see if an error occurred, a cancel was
            // requested or if we completed successfully.  
            if (e.Cancelled)
            {
                lbconv.Text = "Task Cancelled.";
            }

            // Check to see if an error occurred in the background process.

            else if (e.Error != null)
            {
                lbconv.Text = "Error while performing background operation.";
            }
            else
            {
                // Everything completed normally.
                lbconv.Text = "Conversion Successful!";
            }

            //Change the status of the buttons on the UI accordingly
            //btnStart.Enabled = true;
            //btnCancel.Enabled = false;
        }

        /// <summary>
        /// Notification is performed here to the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            // This function fires on the UI thread so it's safe to edit

            // the UI control directly, no funny business with Control.Invoke :)

            // Update the progressBar with the integer supplied to us from the

            // ReportProgress() function.  

            progressBar1.Value = e.ProgressPercentage;
            chkhd.Visible = false;
            lbver.Text = "Success!" + "\n" +"Age of Empires II HD was found!";
            
        }

        /// <summary>
        /// Time consuming operations go here </br>
        /// i.e. Database operations,Reporting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // The sender is the BackgroundWorker object we need it to
            // report progress and check for cancellation.
            //NOTE : Never play with the UI thread here...
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(100);
                string INSTALL_FOLDER = "tc2.dat";
                string inString = Environment.GetEnvironmentVariable("ProgramFiles").ToLower();
                TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
                string output = cultInfo.ToTitleCase(inString);
                string BURGOS_FOLDER = output + @"\microsoft games\age of empires ii" + @"\";
                if (!Directory.Exists(BURGOS_FOLDER))
                {
                    Directory.CreateDirectory(BURGOS_FOLDER);
                    using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(INSTALL_FOLDER))
                    {
                        zip.ExtractAll(BURGOS_FOLDER, ExtractExistingFileAction.OverwriteSilently);
                    }
                }

                // Periodically report progress to the main thread so that it can
                // update the UI.  In most cases you'll just need to send an
                // integer that will update a ProgressBar                    
                backgroundWorker1.ReportProgress(i);
                // Periodically check if a cancellation request is pending.
                // If the user clicks cancel the line
                // m_AsyncWorker.CancelAsync(); if ran above.  This
                // sets the CancellationPending to true.
                // You must check this flag in here and react to it.
                // We react to it by setting e.Cancel to true and leaving
                if (backgroundWorker1.CancellationPending)
                {
                    // Set the e.Cancel flag so that the WorkerCompleted event
                    // knows that the process was cancelled.
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }

            //Report 100% completion on operation completed
            backgroundWorker1.ReportProgress(100);
        }

        private void btnStartAsyncOperation_Click(object sender, EventArgs e)
        {
            //Change the status of the buttons on the UI accordingly
            //The start button is disabled as soon as the background operation is started
            //The Cancel button is enabled so that the user can stop the operation 
            //at any point of time during the execution
            //btnStart.Enabled = false;
            //btnCancel.Enabled = true;

            // Kickoff the worker thread to begin it's DoWork function.
            backgroundWorker1.RunWorkerAsync();
        }
        string fileName = @"tc.dat";
        
        private void Form1_Load(object sender, EventArgs e)
        {

            //string startPath = @"c:\example\start";
            convert.Enabled = false;
            kryptonButton1.Enabled = false;
            lbver2.Visible = false;
           
            //ZipFile.ExtractToDirectory(zipPath, extractPath);
          
            //EncryptFile(fileName, @"tc.dat");
            

        }

       
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void EncryptFile(string inputFile, string outputFile)
        {

            try
            {
                string password = @"HereIsKeyEncryption"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
        }

        ///
        /// Decrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        private void DecryptFile(string inputFile, string outputFile)
        {

            {
                string password = @"HereIsKeyEncryption"; 

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (Ionic.Zip.ZipFile zipnew = Ionic.Zip.ZipFile.Read(zipPath))
            {
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(100);

               
                    foreach (ZipEntry zenew in zipnew)
                    {
                        //Ionic.Zip.ZipFile.ExtractToDirectory(zipPath, extractPath);
                        //zipnew.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);
                        backgroundWorker1.ReportProgress(i);
                    }
                } 
                        //zip.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);
                       //System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                //ZipFile.ExtractToDirectory(zipPath, extractPath);

                // Periodically report progress to the main thread so that it can
                // update the UI.  In most cases you'll just need to send an
                // integer that will update a ProgressBar                    

            zipnew.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);
            
                
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void verify_Click(object sender, EventArgs e)
        {
           
            
        }

        private void convert_Click(object sender, EventArgs e)
        {
            

        }

        private void kryptonGroup4_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verify_Click_1(object sender, EventArgs e)
        {
            //specify the Path for your Application where your application is residing inside the Registry
            strPath = @"Software\WOW6432Node\Microsoft\DirectPlay\Applications\Age of Empires II - The Conquerors Expansion";
            // Reading the key value
            Microsoft.Win32.RegistryKey rkey;
            rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Microsoft Games\Age of Empires II HD");
            if (rkey == null)
            {
                // the Key does not exist
                lbver.Visible = false;
                lbver2.Visible = true;
                chkhd.Visible = false;
                lbver2.Text = "Hmm!" + "\n" + "Age of Empires II HD NOT found!";
                
            }
            else
            {

                //string myTestKey = (string)rkey.GetValue("SteamLanguage");
                //label1.Text = myTestKey;
                for (int i = 0; i < 100; i++)
                {
                    System.Threading.Thread.Sleep(30);
                    backgroundWorker1.ReportProgress(i);

                }
                progressBar1.Enabled = false;
                verify.Enabled = false;
                convert.Enabled = true;
                backgroundWorker1.ReportProgress(0);
            }


        }

        private void convert_Click_1(object sender, EventArgs e)
        {
            DecryptFile(fileName, @"tc2.dat");
            using (Ionic.Zip.ZipFile zipnew = Ionic.Zip.ZipFile.Read(zipPath))
            {
                for (int i = 0; i < 100; i++)
                {
                    //Thread.Sleep(100);


                    foreach (ZipEntry zenew in zipnew)
                    {
                        //Ionic.Zip.ZipFile.ExtractToDirectory(zipPath, extractPath);
                        //zipnew.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);
                        backgroundWorker1.ReportProgress(i);
                    }
                }
                //zip.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);
                //System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                //ZipFile.ExtractToDirectory(zipPath, extractPath);

                // Periodically report progress to the main thread so that it can
                // update the UI.  In most cases you'll just need to send an
                // integer that will update a ProgressBar                    

                zipnew.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);


                backgroundWorker1.RunWorkerAsync();
                convert.Enabled = false;
                kryptonButton1.Enabled = true;

               
            }
            System.IO.File.Delete(@"tc2.dat");
            string inString = Environment.GetEnvironmentVariable("ProgramFiles").ToLower();
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            string output = cultInfo.ToTitleCase(inString);
            string shortfold = output + @"\microsoft games\age of empires ii" + @"\";
            //Copy icon
            System.IO.File.Copy("icon.ico", shortfold + @"Age2_x1\icon.ico", true);
            //Create shortcut

            StringBuilder allUserProfile = new StringBuilder(260);
            SHGetSpecialFolderPath(IntPtr.Zero, allUserProfile, CSIDL_COMMON_DESKTOPDIRECTORY, false);

            string settingsLink = Path.Combine(allUserProfile.ToString(), "Age of Empires II The Conquerors.lnk");
            //Create All Users Desktop Shortcut for Application Settings
            WshShellClass shellClass = new WshShellClass();
            IWshShortcut shortcut = (IWshShortcut)shellClass.CreateShortcut(settingsLink);
            shortcut.TargetPath = shortfold + @"Age2_x1\age2_x1.exe";
            shortcut.IconLocation = shortfold + @"Age2_x1\icon.ico";
            shortcut.Arguments = "arg1 arg2";
            shortcut.Description = "Age of Empires II The Conquerors";
            shortcut.Save();

            MessageBox.Show("Shortcut created on your Desktop!");
            progressBar1.Enabled = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

                        // Creating key values
            string inString = Environment.GetEnvironmentVariable("ProgramFiles").ToLower();
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            string output = cultInfo.ToTitleCase(inString);
                        Microsoft.Win32.RegistryKey rkey;
                        rkey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\WOW6432Node\Microsoft\DirectPlay\Applications\Age of Empires II - The Conquerors Expansion");
                        rkey.SetValue("CurrentDirectory", output + @"\microsoft games\age of empires ii");
                        rkey.SetValue("Path", output + @"\microsoft games\age of empires ii" + @"\AGE2_X1");
                        rkey.SetValue("CommandLine", @"Lobby");
                        rkey.SetValue("File", @"\age2_x1.icd");
                        rkey.SetValue("Guid", @"{5DE93F3F-FC90-4ee1-AE5A-63DAFA055950}");
                        rkey.SetValue("Launcher", @"\age2_x1.Exe");
                        Microsoft.Win32.RegistryKey rkey2;
                        rkey2 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\DirectPlay\Applications\Age of Empires II - The Conquerors Expansion");
                        rkey2.SetValue("CurrentDirectory", output + @"\microsoft games\age of empires ii");
                        rkey2.SetValue("Path", output + @"\microsoft games\age of empires ii" + @"\AGE2_X1");
                        rkey2.SetValue("CommandLine", @"Lobby");
                        rkey2.SetValue("File", @"\age2_x1.icd");
                        rkey2.SetValue("Launcher", @"\age2_x1.Exe");
                        rkey2.SetValue("Guid", @"{5DE93F3F-FC90-4ee1-AE5A-63DAFA055950}");
                        Microsoft.Win32.RegistryKey rkey3;
                        rkey3 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Microsoft Games\Age of Empires II: The Conquerors Expansion\1.0");
                        rkey3.SetValue("EXE Path", output + @"\microsoft games\age of empires ii");
                        rkey3.SetValue("ReceivingFile", @"*");
                        rkey3.SetValue("Version", @"1.0C-VLY");
                        rkey3.SetValue("VersionType", @"RetailVersion");
                        rkey3.SetValue("Zone", @"http://www.voobly.com/games/view/Age-of-Empires-II-The-Conquerors");
                        
            Microsoft.Win32.RegistryKey rkey4;
                        rkey4 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Microsoft Games\Age of Empires II: The Conquerors Expansion\1.0");
                        rkey4.SetValue("EXE Path", output + @"\microsoft games\age of empires ii");
                        rkey4.SetValue("ReceivingFile", @"*");
                        rkey4.SetValue("Version", @"1.0C-VLY");
                        rkey4.SetValue("VersionType", @"RetailVersion");
                        rkey4.SetValue("Zone", @"http://www.voobly.com/games/view/Age-of-Empires-II-The-Conquerors");
                        
            Microsoft.Win32.RegistryKey rkey5;
            rkey5 = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Microsoft Games\Age of Empires II: The Conquerors Expansion\1.0");
                        rkey5.SetValue("EXE Path", output + @"\microsoft games\age of empires ii");
                        rkey5.SetValue("ReceivingFile", @"*");
                        rkey5.SetValue("Version", @"1.0C-VLY");
                        rkey5.SetValue("VersionType", @"RetailVersion");
                        rkey5.SetValue("Zone", @"http://www.voobly.com/games/view/Age-of-Empires-II-The-Conquerors");
            rkey.Close();
                        rkey2.Close();
                        rkey3.Close();
                        rkey4.Close();
                        rkey5.Close();
                        lbvoobconf.Text = "Successfully Configured!";
                        MessageBox.Show("Everything is fine! Happy Gaming & GLHF!");
                        kryptonButton1.Enabled = false;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.youtube.com/user/TheGregStream/videos");
        }
    }
}
