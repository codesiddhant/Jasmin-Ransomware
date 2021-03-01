using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jasmin_Decryptor
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Boolean isKeyVerified = false;
        int totalcount = 0;
        int decryptedfiles = 0;
        string key = "";

        async void pictureBox1_Click(object sender, EventArgs e)
        {
        recheck:
            ofd.Filter = "Jasmin Password File(*.flora) |*.flora;...";
            decryptbutton.Enabled = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                scanningicon.Visible = true;
                verifyingkey.Visible = true;
                totalcount = filecounter();
                floraicon.Visible = false;
                uppertext.Visible = false;
                invalidkeylabel.Visible = false;
                selecticon.Visible = false;             
                string path = ofd.FileName;
                string password = File.ReadAllText(path);
                await Task.Delay(2000);

                if (keyverify(password) == "invalid key")
                {
                    scanningicon.Visible = false;
                    verifyingkey.Visible = false;
                    notfound.Visible = false;
                    invalidkey.Visible = true;
                    invalidkeylabel.Visible = true;
                    await Task.Delay(2400);
                    goto recheck;

                }
                else if (keyverify(password) == "not found")
                {
                    invalidkey.Visible = false;
                    invalidkeylabel.Visible = false;
                    scanningicon.Visible = false;
                    verifyingkey.Visible = false;
                    verifiedlabel.Visible = false;
                    verifiedkey.Visible = false;
                    notfound.Visible = true;
                    await Task.Delay(3400);

                }
                else
                {
                    invalidkey.Visible = false;
                    invalidkeylabel.Visible = false;
                    scanningicon.Visible = false;
                    verifyingkey.Visible = false;
                    notfound.Visible = false;
                    verifiedlabel.Visible = true;
                    verifiedkey.Visible = true;
                    key = password;
                    await Task.Delay(1400);
                    isKeyVerified = true;
                    decryptbutton.Enabled = true;

                }
            }

        }
        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void decryptbutton_Click(object sender, EventArgs e)
        {

            if (isKeyVerified == true)
            {
                invalidkey.Visible = false;
                invalidkeylabel.Visible = false;
                scanningicon.Visible = false;
                verifyingkey.Visible = false;
                notfound.Visible = false;
                verifiedlabel.Visible = false;
                verifiedkey.Visible = false;
                progressBar1.Visible = true;
                loadingman2.Visible = true;
                isKeyVerified = false;
                backgroundWorker1.WorkerReportsProgress = true;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync(key);
                }
                decryptbutton.Enabled = false;
            }
            else
            {
                progressBar1.Visible = false;
                loadingman2.Visible = false;
                string message = "Please Load Password File";
                string title = "Jasmin";
                MessageBox.Show(message, title);

                pictureBox1_Click(sender, e);

            }
        }
        string keyverify(string key)
        {
            DriveInfo[] drives = DriveInfo.GetDrives(); //Disk Information Array
            string msg = "not found";
            string UserHomeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); //Users's Default Home Directory       
            string[] extensions = { "*.jasmin" }; //target file extesnions  
            foreach (DriveInfo drive in drives)
            {
                try
                {
                    if (drive.Name == @"C:\") // skiping C drive

                    {
                        continue;
                    }

                    string dpath = drive.Name; // Drive Path
                    foreach (string l in extensions)
                    {
                        try
                        {
                           foreach (string d in Directory.EnumerateDirectories(dpath))
                           {
                            
                                try
                                {
                                    foreach (string p in Directory.EnumerateFiles(d, l, SearchOption.AllDirectories))

                                        try
                                        {

                                            if (decryption(p, key) == "invalid key")
                                            {
                                               
                                                msg = "invalid key";
                                                return msg;
                                            }
                                            else
                                            {
                                                
                                                msg = "valid key";

                                                return msg;
                                            }

                                        }
                                        catch (UnauthorizedAccessException)
                                        {

                                            continue;
                                        }

                                }
                                catch (UnauthorizedAccessException)
                                {

                                    continue;
                                }

                           }
                        }
                        catch (Exception)
                        {

                        }

                    }
                }
                catch (Exception)
                {

                }

            }
            return msg;
        } //Verifying Key
        string decryption(string path, string password)
        {

            byte[] bytesToBeDecrypted = File.ReadAllBytes(path);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
            if (AES_Decrypt(bytesToBeDecrypted, passwordBytes) != null)
            {
                byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);
                string file = path.Remove(path.Length - 6, 6);
                File.WriteAllBytes(file, bytesDecrypted);
                File.Delete(path);
                decryptedfiles++;
                return file;
            }
            else
            {
                return "invalid key";
            }


        } //Decrypting Function       
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = e.ProgressPercentage;
                progressBar1.Update();
            }
            catch (Exception)
            { 

            }

        } //Progress bar
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            DriveInfo[] drives = DriveInfo.GetDrives(); //Disk Information Array
            string UserHomeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); //Users's Default Home Directory       
            string password = (string)e.Argument;
            string[] extensions = { "*.jasmin" }; //target file extesnions  
            string extension = "*.jasmin";
             foreach (DriveInfo drive in drives)
             {
                try
                {
                    if (drive.Name == @"C:\") // skiping C drive
                    {
                        continue;
                    }

                    string dpath = drive.Name; // Drive Path
                    

                    foreach (string d in Directory.EnumerateDirectories(dpath))
                    {
                         try
                         {
                             foreach (string p in Directory.EnumerateFiles(d, extension, SearchOption.AllDirectories))
                              try
                              {
                                    Thread t = new Thread(() => decryption(p, password));
                                    t.Priority = ThreadPriority.Highest;
                                    t.Start();
                                    //t.Join();
                                    Thread.Sleep(90);
                                    backgroundWorker1.ReportProgress(decryptedfiles * 100 / totalcount);

                              }
                              catch (UnauthorizedAccessException exx)
                              {
                                    Console.WriteLine(exx);
                                    continue;
                              }

                         }
                         catch (UnauthorizedAccessException)
                         {
                               
                                continue;
                         }
                         catch (Exception)
                         {
                                 continue;
                         }

                    } //recursively list all the files in a drive
                    foreach (string p in Directory.EnumerateFiles(dpath, extension))
                    {
                                try
                                {
                                    Thread t = new Thread(() => decryption(p, password));
                                    t.Priority = ThreadPriority.Highest;
                                    t.Start();
                                    //t.Join();
                                    Thread.Sleep(90);
                                    backgroundWorker1.ReportProgress(decryptedfiles * 100 / totalcount);
                                }
                                catch (UnauthorizedAccessException)
                                {
                                    
                                    continue;
                                }

                    }
                }
                catch (Exception)
                {
                   
                   continue;
                }

             } //retrieving Drives files
             foreach (string d in Directory.EnumerateDirectories(UserHomeDir))
             {
                 try
                 {

                  foreach (string p in Directory.EnumerateFiles(d, extension, SearchOption.AllDirectories))
                      try
                      {
                                    Thread t = new Thread(() => decryption(p, password));
                                    t.Priority = ThreadPriority.Highest;
                                    t.Start();
                                    //t.Join();
                                    Thread.Sleep(90);
                                    backgroundWorker1.ReportProgress(decryptedfiles * 100 / totalcount);

                      }
                      catch (UnauthorizedAccessException)
                      {
                        continue;
                      }
                      catch (ArgumentException)
                      {
                        continue;
                      }

                 }
                 catch (UnauthorizedAccessException)
                 {
                    
                     continue;
                 }


            } //recursively retrieving all the files in a drive
             foreach (string p in Directory.EnumerateFiles(UserHomeDir, extension))
             {
                        try
                        {
                            Thread t = new Thread(() => decryption(p, password));
                            t.Priority = ThreadPriority.Highest;
                            t.Start();
                            //t.Join();
                            Thread.Sleep(90);
                            backgroundWorker1.ReportProgress(decryptedfiles * 100 / totalcount);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            continue;
                        }

             } //retrieving User's files
             backgroundWorker2.RunWorkerAsync(); //deleting alertmsg files
             Thread.Sleep(1000);

           
        } //Main Decrypting Process
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string AlertMsgPath = "C:\\Users\\Public\\Windows\\Ui\\";
            string StartupDir = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\unlock your files.lnk";
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\unlock your files.lnk";
            string StartMenu = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"\unlock your files.lnk";
            try
            {
                Directory.Delete(AlertMsgPath, true);
            }
            catch (Exception)
            {

            } //Deleting AlertMsg Files

            String[] Path = { StartupDir, Desktop, StartMenu };
            foreach (String p in Path)
            {
                try
                {
                    File.Delete(p);
                }
                catch (Exception)
                {
                    continue;
                }
            }
            DriveInfo[] drives = DriveInfo.GetDrives(); //retrieving drives
            foreach (DriveInfo drive in drives)
            {
                try
                {
                    File.Delete(drive.Name + @"\unlock your files.lnk");
                }
                catch
                {
                    continue;
                }
            }      //deleting AlertMessage from Every Drive 

        } //deleting alertsmsg files
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            string decrypted = Convert.ToString(decryptedfiles);
            string remain = Convert.ToString(totalcount - decryptedfiles);
            string total = Convert.ToString(totalcount);         
            totalfileslabel.Text = total;
            decryptedfileslabel.Text = decrypted;
            remainingfileslabel.Text = remain;
            progressBar1.Visible = false;
            Thread.Sleep(1000);
            loadingman2.Visible = false;
            finalreport.Visible = true;
            totalfileslabel.Visible = true;
            decryptedfileslabel.Visible = true;
            remainingfileslabel.Visible = true;
            invalidkey.Visible = false;

        } //Final Report
        private static int filecounter()
        {
            int count = 0;
            DriveInfo[] drives = DriveInfo.GetDrives(); //Disk Information Array
            string UserHomeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); //Users's Default Home Directory           
            string extension = "*.jasmin"; //target file extesnions         
            foreach (DriveInfo drive in drives)
            {
                try
                {
                    if (drive.Name == @"C:\") // skiping C drive
                    {
                        continue;
                    }

                    string dpath = drive.Name; // Drive Path
                   
                    foreach (string d in Directory.EnumerateDirectories(dpath))
                    {
                        try
                        {
                            foreach (string p in Directory.EnumerateFiles(d, extension, SearchOption.AllDirectories))
                                try
                                {
                                    count++;
                                }
                                catch (UnauthorizedAccessException)
                                {
                                  
                                    continue;
                                }

                        }
                        catch (UnauthorizedAccessException)
                        {
                            
                            continue;
                        }
                        catch (Exception)
                        {
                            
                            continue;
                        }

                    } //recursively list all the files in a drive
                    foreach (string p in Directory.EnumerateFiles(dpath, extension))
                    {
                        try
                        {
                            count++;
                        }
                        catch (UnauthorizedAccessException)
                        {
                            
                            continue;
                        }

                    }
                }
                catch (Exception)
                {
                   
                    continue;
                }

            } //retrieving Drives files
            foreach (string d in Directory.EnumerateDirectories(UserHomeDir))
            {
                try
                {

                    foreach (string p in Directory.EnumerateFiles(d, extension, SearchOption.AllDirectories))
                        try
                        {
                            count++;
                        }
                        catch (UnauthorizedAccessException)
                        {
                            
                            continue;
                        }
                        catch (ArgumentException)
                        {
                           
                            continue;
                        }

                }
                catch (UnauthorizedAccessException)
                {
                   
                    continue;
                }


            } //recursively retrieving all the files in a drive
            foreach (string p in Directory.EnumerateFiles(UserHomeDir, extension))
            {
                try
                {
                    count++;
                }
                catch (UnauthorizedAccessException)
                {
                   
                    continue;
                }

            } //retrieving User's files
            return count;
        }  //counts total encrypted files in the system
        byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;
            // Set your salt here to meet your flavor:
            byte[] saltBytes = passwordBytes;
            // Example:
            //saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;
                    try
                    {
                        using (CryptoStream cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                        {

                            cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                            cs.Close();

                        }
                        decryptedBytes = ms.ToArray();
                    }
                    catch (CryptographicException)
                    {
                        decryptedBytes = null;
                    }
                }
            }

            return decryptedBytes;
        } //Decryptiong Algorithm      

        private void header_Click(object sender, EventArgs e)
        {

        }
    }//end of mainform class
}//end of namespace
