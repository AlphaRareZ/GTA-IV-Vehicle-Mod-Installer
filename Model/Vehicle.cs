namespace C__MOD_INSTALLER.Model;

public class Vehicle
{
    public GameVehicleData _GameVehicleData = new();
    public List<string>? _vehicleData, _handlingData, _carcols;


    public Vehicle(string? vehicleName, string? handlingData, string? vehicleData, string? carcols, string? wft,
        string? wtd,
        bool cars3)
    {
        _handlingData = Splitter.SplitAndTrim(handlingData ?? string.Empty, ' ');
        _vehicleData = Splitter.SplitAndTrim(vehicleData ?? string.Empty, ',');
        _carcols = Splitter.SplitAndTrim(carcols ?? string.Empty, ',');

        _vehicleName = vehicleName ?? "NA";
        _wftDir = wft;
        _wtdDir = wtd;
        this.cars3 = cars3;
        ProcessHandlingAndVehicleData();
    }

    public string? _wftDir { internal get; set; }
    public string? _wtdDir { internal get; set; }
    public string? _vehicleName { internal get; set; }
    public bool cars3 { internal get; set; }


    private void ProcessHandlingAndVehicleData()
    {
        if (_carcols != null)
            _carcols[0] = _vehicleName ?? "NA";
        if (_vehicleData == null && _handlingData == null) return;
        if (_vehicleData != null && _handlingData == null)
        {
            // Model name, Txd name, Type, HandlingId, Game name
            _vehicleData[0] = _vehicleName ?? "NA";
            _vehicleData[1] = _vehicleName ?? "NA";
            _vehicleData[4] = _vehicleName ?? "NA";
        }
        else if (_vehicleData != null && _handlingData != null)
        {
            _vehicleData[0] = _vehicleName ?? "NA";
            _vehicleData[1] = _vehicleName ?? "NA";
            _vehicleData[3] = _vehicleName ?? "NA";
            _vehicleData[4] = _vehicleName ?? "NA";

            _handlingData[0] = _vehicleName ?? "NA";
        }
        else if (_vehicleData == null && _handlingData != null)
        {
            _vehicleData = Splitter.SplitAndTrim(_GameVehicleData.RetrieveVehicleData(_handlingData[0]), ' ');
            if (_vehicleData?.Count >= 5)
            {
                _vehicleData[0] = _vehicleName ?? "NA";
                _vehicleData[1] = _vehicleName ?? "NA";
                _vehicleData[4] = _vehicleName ?? "NA";
            }


            _handlingData[0] = _vehicleName ?? "NA";
        }
    }
}