namespace C__MOD_INSTALLER.Model
{
    public class ModInstaller
    {
        private static string? _gameDirectory;
        private readonly ModExporter _modExporter = new();


        public bool Install(Vehicle vehicle)
        {
            return _modExporter.ExportMod(vehicle);
        }


        internal bool ValidDirectory(string location)
        {
            bool handling = File.Exists(Path.Combine(location, @"common\data\handling.dat"));
            bool vehicles = File.Exists(Path.Combine(location, @"common\data\vehicles.ide"));
            bool carcols = File.Exists(Path.Combine(location, @"common\data\carcols.dat"));
            return handling && vehicles && carcols;
        }
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

    }
}