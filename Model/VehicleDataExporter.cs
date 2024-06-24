namespace C__MOD_INSTALLER.Model
{
    internal class VehicleDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public bool Export()
        {
            var vehiclesIdeDir = modLoaderDir + @"\vehicles.ide";
            var vehicleDataExists = vehicle.GetVehicleData() != null;
            if (!vehicleDataExists) return false;
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
        public bool canExport()
        {
            return vehicle.GetVehicleData() != null;
        }
    }
}