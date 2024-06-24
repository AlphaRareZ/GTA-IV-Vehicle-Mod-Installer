namespace C__MOD_INSTALLER.Controller;

using C__MOD_INSTALLER.Model;
using ModInstaller;

public class Controller(ModInstallerByAlaaDLord mod)
{
    private readonly ModInstaller _modInstaller = new ModInstaller();
    private ModInstallerByAlaaDLord _mod = mod;

    public bool GameDirectoryUpdated()
    {
        if (_modInstaller.ValidDirectory(mod.gameDirTxt.Text))
        {
            _modInstaller.SetGameDir(mod.gameDirTxt.Text);
            _mod.installBtn.Enabled = true;
            return true;
        }
        return false;
    }

    public bool InstallPressed()
    {
        Vehicle vehicle = new Vehicle(
            mod.vehicleNameTxt.Text,
            mod.handlingTxt.Text,
            mod.vehicleDataTxt.Text,
            mod.carcolsTxt.Text,
            mod.wftTxt.Text,
            mod.wtdTxt.Text,
            mod.checkCars4.Checked == false
        );
        return _modInstaller.Install(vehicle);
    }
}