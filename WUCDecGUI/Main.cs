using System;
using System.Windows.Forms;

namespace WUCDecGUI
{
    public partial class wudecGUI : Form
    {

        WUDecContentGUI.Api wudec = new WUDecContentGUI.Api();
        wucdecGUIcredit credit = new wucdecGUIcredit();

        private string ockeypath;

        public wudecGUI()
        {
            InitializeComponent();
            wudec.Initrun();
            loadckeypath();
        }

        private void loadckeypath()
        {
            wudec.GetCkeyPath_SystemRegistry();
            if ((wudec.GSFileResult(2) !=null) && (System.IO.File.Exists(wudec.GSFileResult(2))) )
            {
                ckeyselBox.Checked = true;
                ockeypath = wudec.GSFileResult(2);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// We use this function to not need repeat the code
        /// for file selection
        /// </summary>
        /// <param name="fdesc">File description such TMD</param>
        /// <param name="ftype"></param>
        /// <param name="arrloc">0 = tmd 1 = cetk 2 = ckey</param>
        private void selectfiledialog(string fdesc,string ftype, int arrloc)
        {
            if (arrloc >= 0 && arrloc <= 2)
            {
                var FD = new OpenFileDialog();

                FD.Title = "Select " + fdesc + " and hit okey";
                FD.Filter = fdesc + " Files (*." + ftype + ") | *." + ftype;

                if (FD.ShowDialog() == DialogResult.OK)
                {
                    wudec.SetPath(FD.FileName.ToString(), arrloc);
                }
                switch (ftype)
                {
                    case "tmd":
                        tmdselBox.Checked = true;
                        break;
                    case "tik":
                        cetkselBox.Checked = true;
                        break;
                    case "bin":
                        ckeyselBox.Checked = true;
                        break;
                    default:
                        break;
                }
            }

        } 

        private void tmdfileBTNClick(object sender, EventArgs e)
        {
            selectfiledialog(fdesc: "TMD", ftype: "tmd", arrloc: 0);

            wudec.SearchForFile(wudec.GSFileResult(0), 1);
            if (!string.IsNullOrEmpty(wudec.GSFileResult(1)))
            {
                cetkselBox.Checked = true;
            }
        }

        private void cetkBTNClick(object sender, EventArgs e)
        {
            selectfiledialog(fdesc: "cetk", ftype: "tik", arrloc: 1);

            wudec.SearchForFile(wudec.GSFileResult(1), 0);
            
            if (!string.IsNullOrEmpty(wudec.GSFileResult(0)))
            {
                tmdselBox.Checked = true;
            }
        }

        private void ckeyBTNClick(object sender, EventArgs e)
        {
            selectfiledialog(fdesc: "WiiU Common Key", ftype: "bin", arrloc: 2);

            if (wudec.GSFileResult(2) != ockeypath)
            {
                wudec.SetPath(wudec.GSFileResult(2), 2);
                wudec.SetCKeyPath_SystemRegistry(wudec.GSFileResult(2));
            }
        }

        private void decnowBTNClick(object sender, EventArgs e)
        {
            wudec.DecryptContent();
            if (wudec.ReturnMessage != "Success")
            {
                MessageBox.Show(wudec.ReturnMessage, caption: "Importent", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(text: "I'm done master", caption: "Success", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            tmdselBox.Checked = false;
            cetkselBox.Checked = false;
        }

        private void aboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!credit.Visible)
                credit.Show();
            else
            {
                credit.WindowState = FormWindowState.Normal;
                credit.Focus();
            }
        }
    }
}