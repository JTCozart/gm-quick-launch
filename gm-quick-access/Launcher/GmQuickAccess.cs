using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenNewGoogleMeeting();
        }
       

        private static void OpenNewGoogleMeeting()
        {
            System.Diagnostics.Process.Start("https://meet.google.com/new");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void newMeetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewGoogleMeeting();
        }
    }
}