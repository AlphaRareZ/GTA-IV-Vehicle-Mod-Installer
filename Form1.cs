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
            FolderBrowserDialog folderBrowserDialog= new FolderBrowserDialog();
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
            ModInstaller modInstaller = new ModInstaller(textBox1.Text);
            if (!modInstaller.validDirectory(textBox1.Text))
            {
                MessageBox.Show("Invalid Directory May Cause Game Files Corruption!");
                return;
            }
            bool installed = modInstaller.installMod(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
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
