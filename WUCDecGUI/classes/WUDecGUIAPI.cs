
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace WUDecContentGUI
{
    class Api
    {
        int twork = 0;

        private string msg;
        private string[] filepaths;

        public void Initrun()
        {
            filepaths = new string[3];
            filepaths[2] = GetCkeyPath_SystemRegistry();
        }

        /// <summary>
        /// This is used to get the path
        /// for file X.* where X is unknow and * = the file type
        /// To then get the file path use GSFileResult
        /// </summary>
        /// <param name="fphat">The path for search for the file</param>
        /// <param name="ftype">File type to search for 0 = tmd 1 = tik</param>
        public void SearchForFile(string fphat, int ftype)
        {
            string ttype = null;
            if (!string.IsNullOrEmpty(fphat))
            {
                switch (ftype)
                {
                    case 0:
                        ttype = "tmd";
                        break;
                    case 1:
                        ttype = "tik";
                        break;
                    default:
                        break;
                }
                try
                {
                    string tdir = Path.GetDirectoryName(fphat);
                    string[] tfindfile = Directory.GetFiles(tdir, "*." + ttype);
                    while (twork != 1)
                    {
                        foreach (string tmp in tfindfile)
                        {
                            switch (ttype)
                            {
                                case "tmd":
                                    filepaths[0] = tmp;
                                    break;
                                case "tik":
                                    filepaths[1] = tmp;
                                    break;
                                default:
                                    break;
                            }
                            twork = 1;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    twork = 0;
                }
            }
        }

        /// <summary>
        /// This return the setted filepath of X
        /// </summary>
        /// <param name="type">0 = tmd 1 = tik 2 = common key</param>
        /// <returns></returns>
        public string GSFileResult(int type)
        {
            if (type >= 0 && type <= 2)
                return filepaths[type];
            return null;
        }

        public void SetPath(string tpath, int ftype)
        {
            if (ftype >= 0 && ftype <= 2)
                filepaths[ftype] = tpath;
        }

        /// <summary>
        /// clear previous path of Content to decrypt
        /// </summary>
        private void cleanup()
        {
            for (int i = 0; i <= 1; i++)
            {
                filepaths[i] = "";
            }
        }

        /// <summary>
        /// Use this to start decrypt content
        /// </summary>
        public void DecryptContent()
        {
            decryptcontent();
        }
        /// <summary>
        /// This start to try decrypt the content for real
        /// </summary>
        private void decryptcontent()
        {
            int error = 0;
            string errormsg = "I will not continue as you have not selected following file(s)\n\n";

            if ((string.IsNullOrEmpty(filepaths[0])) || (string.IsNullOrEmpty(filepaths[1])) || (string.IsNullOrEmpty(filepaths[2])))
            {
                error = 1;
                if (string.IsNullOrEmpty(filepaths[0]))
                    errormsg += "TMD\n";
                if (string.IsNullOrEmpty(filepaths[1]))
                    errormsg += "cetk";
                if (string.IsNullOrEmpty(filepaths[2]))
                    errormsg += "\nWiiU Common Key";
            }
            if (error != 0)
            {
                msg = errormsg;
            }
            else
            {
                string workdir = System.IO.Directory.GetCurrentDirectory();
                workdir += "\\include\\";
                if (File.Exists(workdir + "CDecrypt.exe") && File.Exists(workdir + "libeay32.dll") )
                {

                    Process decdisc = new Process();
                    decdisc.StartInfo.FileName = workdir + "CDecrypt.exe";
                    decdisc.StartInfo.Arguments = "\"" + filepaths[0] + "\" \"" + filepaths[1] + "\" \"" + filepaths[2] + "\"";
                    decdisc.StartInfo.WorkingDirectory = Path.GetDirectoryName(filepaths[1]);
                    decdisc.StartInfo.CreateNoWindow = true;
                    decdisc.StartInfo.RedirectStandardOutput = true;
                    decdisc.StartInfo.UseShellExecute = false;
                    decdisc.Start();

                    File.WriteAllText(workdir + "debug.txt", decdisc.StandardOutput.ReadToEnd());

                    decdisc.WaitForExit();

                    if (decdisc.HasExited)
                    {
                        msg = "Success";
                    }
                }
            }
            cleanup();
        }

        private void getupdatecheck(string url, string parameters)
        {
            WebRequest webrequest   = WebRequest.Create(url);
            webrequest.ContentType  = "application/json"; //Handle the content as json
            webrequest.Method       = "POST";
            byte[] bytes            = Encoding.UTF8.GetBytes(parameters);
            string bytestring = Encoding.UTF8.GetString(bytes);
            Stream os = null;
            //send the json to hopeful get valid respons back
            try
            {
                webrequest.ContentLength = bytes.Length;
                os = webrequest.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);
            }
            catch (WebException ex)
            {
                //Error handler
                throw ex;
            }
            //get the respons
            try
            {
                WebResponse webresponse = webrequest.GetResponse();
                if (webresponse != null)
                {
                    StreamReader sr = new StreamReader(webresponse.GetResponseStream());
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        public string ReturnMessage
        {
            get { return msg; }
        }

        public void SetCKeyPath_SystemRegistry(string keypath,string appname = "WU_Decrypt Content GUI", string creator = "Dynamit")
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(name: "Software", writable: true);

            key.CreateSubKey(creator);
            key = key.OpenSubKey(creator, true);

            key.CreateSubKey(appname);
            key = key.OpenSubKey(appname, true);

            key.SetValue("CommonKey_Path", keypath);
        }

        public string GetCkeyPath_SystemRegistry(string appname = "WU_Decrypt Content GUI", string creator = "Dynamit")
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + creator + "\\" + appname);
            string keyName = @"HKEY_CURRENT_USER\SOFTWARE\\" + creator + "\\" + appname;

            if (Registry.GetValue(keyName, valueName: "CommonKey_Path", defaultValue: null)!= null)
                return key.GetValue(name: "CommonKey_Path").ToString();
            else
                return null;
        }
    }
}
