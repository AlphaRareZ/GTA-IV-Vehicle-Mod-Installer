namespace C__MOD_INSTALLER.Controller;

using C__MOD_INSTALLER.Model;
using ModInstaller;

public class Controller(ModInstallerByAlaaDLord mod)
{
    private readonly ModInstaller _modInstaller = new();
    private ModInstallerByAlaaDLord _mod = mod;

    public bool GameDirectoryUpdated()
    {
        if (_modInstaller.ValidDirectory(_mod.gameDirTxt.Text))
        {
            _modInstaller.SetGameDir(_mod.gameDirTxt.Text);
            _mod.installBtn.Enabled = true;
            return true;
        }
        return false;
    }

    public bool InstallPressed()
    {
        Vehicle vehicle = new Vehicle(
            _mod.vehicleNameTxt.Text,
            _mod.handlingTxt.Text,
            _mod.vehicleDataTxt.Text,
            _mod.carcolsTxt.Text,
            _mod.wftTxt.Text,
            _mod.wtdTxt.Text,
            _mod.checkCars4.Checked == false
        );
        return _modInstaller.Install(vehicle);
    }
}