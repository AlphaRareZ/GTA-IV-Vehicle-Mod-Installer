using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C__MOD_INSTALLER.Controller;

namespace ModInstaller
{
    public partial class ModInstallerByAlaaDLord : Form
    {
        public ModInstallerByAlaaDLord()
        {
            _controller = new Controller(this);
            InitializeComponent();
        }

        private readonly Controller _controller;
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            gameDirTxt.Text = folderBrowserDialog.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WFT Files (*.wft)|*.wft";
            openFileDialog.ShowDialog();
            wftTxt.Text = openFileDialog.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WTD Files(*.wtd) | *.wtd";
            openFileDialog.ShowDialog();
            wtdTxt.Text = openFileDialog.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_controller.InstallPressed() ? "Mod Installed Successfully" : "Something Went Wrong!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //cars3
        {
            checkCars4.Enabled = !checkCars4.Enabled;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //cars4
        {
            checkCars3.Enabled = !checkCars3.Enabled;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!_controller.GameDirectoryUpdated())
            {
                MessageBox.Show("Invalid GTA IV Directory!");
            }
        }
    }
}