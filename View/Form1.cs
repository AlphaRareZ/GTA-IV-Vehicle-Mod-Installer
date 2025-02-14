using C__MOD_INSTALLER.Controller;

namespace ModInstaller;

public partial class ModInstallerByAlaaDLord : Form
{
    public ModInstallerByAlaaDLord()
    {
        Controller controller = new();
        InitializeComponent();
        GameDirChanged += controller.GameDirTextChanged;
        InstallButtonClicked += controller.InstallPressed;
    }

    private event EventHandler<GameDirChangedArgs> GameDirChanged;

    private event EventHandler<VehicleArgs> InstallButtonClicked;

    // Select Button
    private void button1_Click(object sender, EventArgs e)
    {
        var folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.ShowDialog();
        gameDirTxt.Text = folderBrowserDialog.SelectedPath;
    }

    // Select WFT Button
    private void button2_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "WFT Files (*.wft)|*.wft";
        openFileDialog.ShowDialog();
        wftTxt.Text = openFileDialog.FileName;
    }

    // Select WTD Button
    private void button3_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "WTD Files(*.wtd) | *.wtd";
        openFileDialog.ShowDialog();
        wtdTxt.Text = openFileDialog.FileName;
    }

    // Install Button
    private void button4_Click(object sender, EventArgs e)
    {
        InstallButtonClicked?.Invoke(sender, new VehicleArgs(vehicleNameTxt.Text,
            handlingTxt.Text,
            vehicleDataTxt.Text,
            carcolsTxt.Text,
            wftTxt.Text,
            wtdTxt.Text,
            checkCars4.Checked == false));
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) //cars3
    {
        checkCars4.Enabled = !checkCars4.Enabled;
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e) //cars4
    {
        checkCars3.Enabled = !checkCars3.Enabled;
    }

    private void gameDirTxt_TextChanged(object sender, EventArgs e)
    {
        GameDirChanged?.Invoke(this, new GameDirChangedArgs(gameDirTxt.Text, installBtn));
    }
}