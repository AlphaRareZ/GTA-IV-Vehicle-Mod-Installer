using ModInstaller;

namespace C__MOD_INSTALLER
{
    internal class VehicleDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public void Export()
        {
            var vehiclesIdeDir = modLoaderDir + @"\vehicles.ide";
            var vehicleDataExists = vehicle.GetVehicleData() != null;

            if (!File.Exists(vehiclesIdeDir) && vehicleDataExists)
            {
                using (File.Create(vehiclesIdeDir))
                {
                    // nothing
                }
            }

            if (vehicleDataExists)
                DataExporter.AddDataIntoFiles(vehicle.GetVehicleData(), ',', vehiclesIdeDir, "cars\n");
        }
    }
}