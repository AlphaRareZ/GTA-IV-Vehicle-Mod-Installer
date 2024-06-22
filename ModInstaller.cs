namespace ModInstaller
{
    public class ModInstaller
    {
        private static string? _gameDirectory = null;
        private DataExporter _dataExporter = new();
        
        public bool SetGameDir(string directory)
        {
            if (ValidDirectory(directory))
            {
                _gameDirectory = directory;
                return true;
            }

            return false;
        }
        
        public static string GetGameDir()
        {
            return _gameDirectory!;
        }

        public bool Install(Vehicle vehicle)
        {
            _dataExporter.ExportMod(vehicle);
            return true;
        }


        public bool ValidDirectory(string location)
        {
            bool handling = File.Exists(Path.Combine(location, @"common\data\handling.dat"));
            bool vehicles = File.Exists(Path.Combine(location, @"common\data\vehicles.ide"));
            return handling && vehicles;
        }

       
    }
}