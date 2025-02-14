namespace C__MOD_INSTALLER.Model.FilesExporters;

internal class VehicleDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
{
    public bool Export()
    {
        var vehicleDataExists = vehicle._vehicleData != null;
        if (!vehicleDataExists) return false;

        var vehiclesIdeDir = modLoaderDir + @"\vehicles.ide";
        if (!File.Exists(vehiclesIdeDir) && vehicleDataExists)
            using (File.Create(vehiclesIdeDir))
            {
                // nothing
            }

        ModExporter.AddDataIntoFiles(vehicle._vehicleData, ',', vehiclesIdeDir, "cars\n");
        return true;
    }

    public bool CanExport()
    {
        return vehicle._vehicleData != null;
    }
}