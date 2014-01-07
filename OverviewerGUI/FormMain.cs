using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverviewerGUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            /*
             * overviewer.exe [--rendermodes=...] [options] <World> <Output Dir>
             * overviewer.exe --config=<config file> [options]
            */

            string source = txtSourceDir.Text;
            string output = txtOutputDir.Text;
            string config = txtConfigDir.Text;
            string oArgs = "";

            if (!String.IsNullOrWhiteSpace(config))
            {
                oArgs = "--config=\"" + config + "\"";
            }
            else
            {
                oArgs = "" + "\"" + source + "\" \"" + output + "\"";
            }
            // TODO: oArgs += [options]

            // Open console and run command
            try
            {
                System.Diagnostics.Process.Start("overviewer.exe", oArgs);
                //this.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                label1.Text = "File Not Found";
            }

        }
    }
}
