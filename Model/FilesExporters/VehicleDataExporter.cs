namespace C__MOD_INSTALLER.Model.FilesExporters
{
    internal class VehicleDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public bool Export()
        {
            var vehicleDataExists = vehicle.GetVehicleData() != null;
            if (!vehicleDataExists) return false;

            var vehiclesIdeDir = modLoaderDir + @"\vehicles.ide";
            if (!File.Exists(vehiclesIdeDir) && vehicleDataExists)
            {
                using (File.Create(vehiclesIdeDir))
                {
                    // nothing
                }
            }

            ModExporter.AddDataIntoFiles(vehicle.GetVehicleData(), ',', vehiclesIdeDir, "cars\n");
            return true;
        }

        public bool CanExport()
        {
            return vehicle.GetVehicleData() != null;
        }
    }
}