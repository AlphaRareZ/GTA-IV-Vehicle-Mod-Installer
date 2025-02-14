using C__MOD_INSTALLER.Model;
using ModInstaller;

namespace C__MOD_INSTALLER.Controller;

public class Controller
{
    // model
    private readonly Model.ModInstaller _modInstaller = new();

    public void InstallPressed(object? sender, VehicleArgs e)
    {
        var vehicle = new Vehicle(e.VehicleName, e.handlingData, e.vehicleData, e.carcols, e.wft, e.wtd, e.cars3);
        var installed = _modInstaller.Install(vehicle);
        MessageBox.Show(installed ? @"Vehicle installed successfully!" : @"Vehicle installation failed!");
    }

    public void GameDirTextChanged(object? sender, GameDirChangedArgs e)
    {
        if (!_modInstaller.ValidDirectory(e.GameDir))
        {
            e.Button.Enabled = false;
        }
        else
        {
            _modInstaller.SetGameDir(e.GameDir);
            e.Button.Enabled = true;
        }
    }
}