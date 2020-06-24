using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lessons2206.Engine;
using Lessons2206.Forms.Additional;

namespace Lessons2206.Forms
{
    public partial class MainForm : Form
    {
        public static MainForm hndlr;
        public MainForm()
        {
            hndlr = this;
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void publicInformation_btn_Click(object sender, EventArgs e)
        {
            if (PublicInformation.hndlr == null)
            {
                PublicInformation creators = new PublicInformation();
                creators.ShowDialog();
            }
            else PublicInformation.hndlr.ShowDialog();
        }

        private void creators_btn_Click(object sender, EventArgs e)
        {
            if (creatorsForm.hndlr == null)
            {
                creatorsForm creators = new creatorsForm();
                creators.ShowDialog();
            }
            else creatorsForm.hndlr.ShowDialog();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            if (About.hndlr == null)
            {
                About creators = new About();
                creators.ShowDialog();
            }
            else About.hndlr.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            status_lbl.Text = "Current user: " + AuthInfo.username;
            menu_st.Items.Add
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            if (Settings.hndlr == null)
            {
                Settings creators = new Settings();
                creators.ShowDialog();
            }
            else Settings.hndlr.ShowDialog();
        }
    }
}
