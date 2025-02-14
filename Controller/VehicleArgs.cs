namespace C__MOD_INSTALLER.Controller;

public class VehicleArgs(
    string vehicleName,
    string handlingData,
    string vehicleData,
    string carcols,
    string wft,
    string wtd,
    bool cars3)
{
    public string VehicleName { get; private set; } = vehicleName;
    public string handlingData { get; private set; } = handlingData;
    public string vehicleData { get; private set; } = vehicleData;
    public string carcols { get; private set; } = carcols;
    public string wft { get; private set; } = wft;
    public string wtd { get; private set; } = wtd;
    public bool cars3 { get; private set; } = cars3;
}