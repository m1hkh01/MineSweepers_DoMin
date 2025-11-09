using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoMin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            isMusicPlaying = true;
            musicPlayer = new SoundPlayer(@"D:\PTCD_FPT\PMA101\sound\musicSound.wav");
            if (isMusicPlaying && musicPlayer != null)
            {
                musicPlayer.PlayLooping();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void CloseHowToPlayForm()
        {
            frmHowToPlay frmHowToPlay = Application.OpenForms["frmHowToPlay"] as frmHowToPlay;
            if (frmHowToPlay != null)
            {
                frmHowToPlay.Close();
            }
        }

        private void mnuEasy_Click(object sender, EventArgs e)
        {
            CloseHowToPlayForm();

            frmEasy frm2 = Application.OpenForms["frmEasy"] as frmEasy;

            if (frm2 == null)
            {
                frm2 = new frmEasy();
                frm2.MdiParent = this;
                frm2.FormBorderStyle = FormBorderStyle.None;
                frm2.StartPosition = FormStartPosition.CenterScreen;
                frm2.Show();

                mnuEasy.Enabled = false;
                mnuMedium.Enabled = true;
                mnuHard.Enabled = true;
            }
            else
            {
                mnuEasy.Enabled = false;
                mnuMedium.Enabled = true;
                mnuHard.Enabled = true;
            }
        }

        private void mnuMedium_Click(object sender, EventArgs e)
        {
            CloseHowToPlayForm();

            frmMedium frm2 = Application.OpenForms["frmMedium"] as frmMedium;

            if (frm2 == null)
            {
                frm2 = new frmMedium();
                frm2.MdiParent = this;
                frm2.FormBorderStyle = FormBorderStyle.None;
                frm2.StartPosition = FormStartPosition.CenterScreen;
                frm2.Show();

                mnuMedium.Enabled = false;
                mnuEasy.Enabled = true;
                mnuHard.Enabled = true;
            }
            else
            {
                mnuMedium.Enabled = false;
                mnuEasy.Enabled = true;
                mnuHard.Enabled = true;
            }
        }

        private void mnuHard_Click(object sender, EventArgs e)
        {
            CloseHowToPlayForm();

            frmHard frm2 = Application.OpenForms["frmHard"] as frmHard;

            if (frm2 == null)
            {
                frm2 = new frmHard();
                frm2.MdiParent = this;
                frm2.FormBorderStyle = FormBorderStyle.None;
                frm2.StartPosition = FormStartPosition.CenterScreen;
                frm2.Show();

                mnuHard.Enabled = false;
                mnuEasy.Enabled = true;
                mnuMedium.Enabled = true;
            }
            else
            {
                mnuHard.Enabled = false;
                mnuEasy.Enabled = true;
                mnuMedium.Enabled = true;
            }
        }


        private void mnuThoat_Click(object sender, EventArgs e)
        {
            var ans = MessageBox.Show("Exit the game?", "Notification",
                                     MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool isDarkMode = false;
        private bool isLightMode = false;

        private void UpdateAllFormsDarkMode(bool enableDarkMode)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.BackColor = enableDarkMode ? Color.Gray : SystemColors.Control;
                }
            }
        }

        private void UpdateAllFormsLightMode(bool enableLightMode)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.BackColor = enableLightMode ? Color.DarkSeaGreen : SystemColors.Control;
                }
            }
        }

        private void mnuDarkMode_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                return;
            }

            isDarkMode = true;
            isLightMode = false;

            menuStrip2.BackColor = Color.Gray;
            mnuGameMode.ForeColor = Color.Black;
            mnuView.ForeColor = Color.Black;
            mnuThoat.ForeColor = Color.Black;

            foreach (ToolStripMenuItem item in mnuView.DropDownItems)
            {
                item.ForeColor = Color.Black;
                item.BackColor = Color.Gray;
            }

            foreach (ToolStripMenuItem item in mnuGameMode.DropDownItems)
            {
                item.ForeColor = Color.Black;
                item.BackColor = Color.Gray;
            }

            UpdateAllFormsDarkMode(isDarkMode);

            mnuDarkMode.Enabled = false;

            mnuLightMode.Enabled = true;
        }

        private void mnuLightMode_Click(object sender, EventArgs e)
        {
            if (isLightMode)
            {
                return;
            }

            isLightMode = true;
            isDarkMode = false;

            menuStrip2.BackColor = Color.WhiteSmoke;

            foreach (ToolStripMenuItem item in mnuView.DropDownItems)
            {
                item.ForeColor = Color.Black;
                item.BackColor = Color.White;
            }

            foreach (ToolStripMenuItem item in mnuGameMode.DropDownItems)
            {
                item.ForeColor = Color.Black;
                item.BackColor = Color.White;
            }

            UpdateAllFormsLightMode(isLightMode);

            mnuLightMode.Enabled = false;

            mnuDarkMode.Enabled = true;
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuGameMode_Click(object sender, EventArgs e)
        {

        }

        private void mnuHow_Click(object sender, EventArgs e)
        {
            frmHowToPlay frm5 = Application.OpenForms["frmHowToPlay"] as frmHowToPlay;

            if (frm5 == null)
            {
                frm5 = new frmHowToPlay();
                frm5.MdiParent = this;
                frm5.FormBorderStyle = FormBorderStyle.None;
                frm5.StartPosition = FormStartPosition.CenterScreen;
                frm5.Show();
            }
            else
            {
                frm5.Close();
            }
        }

        private void mnuView_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEasy"] != null)
            {
                Application.OpenForms["frmEasy"].Close();
            }

            if (Application.OpenForms["frmMedium"] != null)
            {
                Application.OpenForms["frmMedium"].Close();
            }

            if (Application.OpenForms["frmHard"] != null)
            {
                Application.OpenForms["frmHard"].Close();
            }

            if (Application.OpenForms["frmHowToPlay"] != null)
            {
                Application.OpenForms["frmHowToPlay"].Close();
            }

            frmMain frmMainForm = Application.OpenForms["frmMain"] as frmMain;
            if (frmMainForm != null)
            {
                frmMainForm.Activate();
            }
            else
            {
                frmMain newFrmMain = new frmMain();
                newFrmMain.MdiParent = this;
                newFrmMain.Show();
            }

            mnuEasy.Enabled = true;
            mnuMedium.Enabled = true;
            mnuHard.Enabled = true;

            if (isMusicPlaying && musicPlayer != null)
            {
                musicPlayer.PlayLooping();
            }
        }



        private SoundPlayer musicPlayer;
        private bool isMusicPlaying;

        private void btnOnMusic_Click(object sender, EventArgs e)
        {

        }

        private void btnOffMusic_Click(object sender, EventArgs e)
        {

        }

        public void PlayMusic()
        {
            if (!isMusicPlaying && musicPlayer != null)
            {
                musicPlayer.PlayLooping();
                isMusicPlaying = true;
            }
        }

        public void StopMusic()
        {
            if (isMusicPlaying && musicPlayer != null)
            {
                musicPlayer.Stop();
                isMusicPlaying = false;
            }
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isMusicPlaying)
            {
                StopMusic();
            }
            else
            {
                PlayMusic();
            }
        }
    }
}
