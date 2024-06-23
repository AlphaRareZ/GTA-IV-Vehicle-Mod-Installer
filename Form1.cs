using System;
using System.Windows.Forms;

namespace ModInstaller
{
    public partial class ModInstaller_By_AlaaDLord : Form
    {
        public ModInstaller_By_AlaaDLord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            textBox1.Text = folderBrowserDialog.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WFT Files (*.wft)|*.wft";
            openFileDialog.ShowDialog();
            textBox5.Text = openFileDialog.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WTD Files(*.wtd) | *.wtd";
            openFileDialog.ShowDialog();
            textBox6.Text = openFileDialog.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModInstaller modInstaller = new ModInstaller();
            bool validDir = modInstaller.SetGameDir(textBox1.Text);
            if (!validDir)
            {
                MessageBox.Show("Invalid Directory May Cause Game Files Corruption!");
                return;
            }
            
            Vehicle vehicle = new Vehicle(textBox2.Text, textBox3.Text, textBox4.Text,textBox7.Text, textBox5.Text, textBox6.Text);
            bool installed = modInstaller.Install(vehicle);

            if (installed)
            {
                MessageBox.Show("Mod Installed Successfully");
            }
            else
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
    }
}