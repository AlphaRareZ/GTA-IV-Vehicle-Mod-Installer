using System.Runtime.CompilerServices;
using C__MOD_INSTALLER;

namespace C__MOD_INSTALLER.Model;

public class Vehicle
{
    private List<string>? _vehicleData, _handlingData, _carcols;

    private string _wftDir;
    private string _wtdDir;
    private string _vehicleName;
    private bool cars3 = true;
    private GameData _gameData = new();


    public Vehicle(string vehicleName, string handlingData, string vehicleData, string carcols, string wft, string wtd,
        bool cars3)
    {
        _handlingData = Splitter.SplitAndTrim(handlingData, ' ');
        _vehicleData = Splitter.SplitAndTrim(vehicleData, ',');
        _carcols = Splitter.SplitAndTrim(carcols, ',');
        _vehicleName = vehicleName;
        _wftDir = wft;
        _wtdDir = wtd;
        this.cars3 = cars3;
        ProcessHandlingAndVehicleData();
    }


    private void ProcessHandlingAndVehicleData()
    {
        if (_carcols != null)
            _carcols[0] = _vehicleName;
        if (_vehicleData == null && _handlingData == null) return;
        if (_vehicleData != null && _handlingData == null)
        {
            // Model name, Txd name, Type, HandlingId, Game name
            _vehicleData[0] = _vehicleName;
            _vehicleData[1] = _vehicleName;
            _vehicleData[4] = _vehicleName;
        }
        else if (_vehicleData != null && _handlingData != null)
        {
            _vehicleData[0] = _vehicleName;
            _vehicleData[1] = _vehicleName;
            _vehicleData[3] = _vehicleName;
            _vehicleData[4] = _vehicleName;

            _handlingData[0] = _vehicleName;
        }
        else if (_vehicleData == null && _handlingData != null)
        {
            _vehicleData = Splitter.SplitAndTrim(_gameData.RetrieveVehicleData(_handlingData[0]), ' ');
            _vehicleData[0] = _vehicleName;
            _vehicleData[1] = _vehicleName;
            _vehicleData[4] = _vehicleName;

            _handlingData[0] = _vehicleName;
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

    internal List<string>? GetHandlingData()
    {
        return _handlingData;
    }

    internal List<string>? GetVehicleData()
    {
        return _vehicleData;
    }

    internal List<string>? getCarcolsData()
    {
        return _carcols;
    }

    internal bool getCars3()
    {
        return cars3;
    }
}