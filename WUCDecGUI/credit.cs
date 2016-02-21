using System.Windows.Forms;

namespace WUCDecGUI
{
    public partial class wucdecGUIcredit : Form
    {
        public wucdecGUIcredit()
        {
            InitializeComponent();

            this.FormClosing += WucdecGUIcredit_FormClosing;
        }

        private void WucdecGUIcredit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
