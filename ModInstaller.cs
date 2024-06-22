namespace ModInstaller
{
    public class ModInstaller
    {
        private static string? gameLocation = null;
        private string modLoaderVehicle;

        public bool installMod(string vehicleName, string? handling, string? vehicles, string wft, string wtd)
        {
            var vehicle = new Vehicle(vehicleName);
            if (!string.IsNullOrEmpty(handling))
                vehicle.handlingData = Splitter.splitHandling(handling);
            if (!string.IsNullOrEmpty(vehicles))
                vehicle.vehicleData = Splitter.splitVehicle(vehicles);

            bool processDone = vehicle.processHandlingAndVehicleData();
            if (!processDone) return false;

            modLoaderVehicle = Path.Combine(gameLocation, "modloader", vehicleName.ToUpper());

            // Ensure the target directory exists
            if (!Directory.Exists(modLoaderVehicle))
            {
                Directory.CreateDirectory(modLoaderVehicle);
            }

            // Copy the files to the target directory
            File.Copy(wft, Path.Combine(modLoaderVehicle, $"{vehicleName}.wft"));
            File.Copy(wtd, Path.Combine(modLoaderVehicle, $"{vehicleName}.wtd"));

            vehicle.exportVehiclesAndHandling(modLoaderVehicle);
            return true;
        }

        public ModInstaller(string directory)
        {
            if (validDirectory(directory))
            {
                gameLocation = directory;
            }
        }

        public bool validDirectory(string location)
        {
            bool handling = File.Exists(Path.Combine(location, @"common\data\handling.dat"));
            bool vehicles = File.Exists(Path.Combine(location, @"common\data\vehicles.ide"));
            return handling && vehicles;
        }

        public static string? retrieveVehicle(string vehicleName)
        {
            try
            {
                using StreamReader sr = new StreamReader(Path.Combine(gameLocation, @"common\data\vehicles.ide"));
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith(vehicleName))
                    {
                        return line;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}