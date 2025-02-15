using C__MOD_INSTALLER.ModelUtilities.FilesExporters;

namespace C__MOD_INSTALLER.Model;

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
        var handling = File.Exists(Path.Combine(location, @"common\data\handling.dat"));
        var vehicles = File.Exists(Path.Combine(location, @"common\data\vehicles.ide"));
        var carcols = File.Exists(Path.Combine(location, @"common\data\carcols.dat"));
        var modLoader = Directory.Exists(Path.Combine(location, @"modloader"));
        return handling && vehicles && carcols && modLoader;
    }

    public void SetGameDir(string directory)
    {
        _gameDirectory = directory;
    }

    public static string GetGameDir()
    {
        return _gameDirectory!;
    }
}