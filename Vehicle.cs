using System.Runtime.CompilerServices;
using C__MOD_INSTALLER;

namespace ModInstaller;

public class Vehicle
{
    private List<String>? _vehicleData = null;

    private List<String>? _handlingData = null;

    private string _wftDir;
    private string _wtdDir;
    private string _vehicleName;

    private GameData _gameData = new();

    public Vehicle(string vehicleName, string handlingData, string vehicleData, string wft, string wtd)
    {
        _vehicleName = vehicleName;
        if (!string.IsNullOrEmpty(handlingData))
            _handlingData = Splitter.splitHandling(handlingData);
        if (!string.IsNullOrEmpty(vehicleData))
            _vehicleData = Splitter.splitVehicle(vehicleData);
        _wftDir = wft;
        _wtdDir = wtd;
        ProcessHandlingAndVehicleData();
    }


    private void ProcessHandlingAndVehicleData()
    {
        if (_vehicleData == null && _handlingData == null) return;

        if (_vehicleData != null && _handlingData == null)
        {
            // Model name, Txd name, Type, HandlingId, Game name
            _vehicleData[0] = _vehicleName;
            _vehicleData[1] = _vehicleName;
            _vehicleData[4] = _vehicleName.ToUpper();
        }
        else if (_vehicleData != null && _handlingData != null)
        {
            _vehicleData[0] = _vehicleName;
            _vehicleData[1] = _vehicleName;
            _vehicleData[3] = _vehicleName.ToUpper();
            _vehicleData[4] = _vehicleName.ToUpper();

            _handlingData[0] = _vehicleName.ToUpper();
        }
        else if (_vehicleData == null && _handlingData != null)
        {
            _vehicleData = Splitter.splitVehicle(_gameData.RetrieveVehicleFromVehiclesIde(_handlingData[0].ToLower()));
            _vehicleData[0] = _vehicleName;
            _vehicleData[1] = _vehicleName;
            _vehicleData[4] = _vehicleName.ToUpper();

            _handlingData[0] = _vehicleName.ToUpper();
        }
    }

    internal string GetVehicleName()
    {
        return _vehicleName;
    }

    internal string GetWftDir()
    {
        return _wftDir;
    }

    internal string GetWtdDir()
    {
        return _wtdDir;
    }

    internal List<String>? GetHandlingData()
    {
        return _handlingData;
    }

    internal List<String>? GetVehicleData()
    {
        return _vehicleData;
    }
}