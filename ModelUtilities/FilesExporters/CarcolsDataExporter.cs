using C__MOD_INSTALLER.Model;

namespace C__MOD_INSTALLER.ModelUtilities.FilesExporters;

internal class CarcolsDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
{
    public bool Export()
    {
        var carcolsDataExists = vehicle._carcols != null;
        if (!carcolsDataExists) return false;

        var carcolsDatDir = modLoaderDir + @"\carcols.dat";
        if (!File.Exists(carcolsDatDir) && carcolsDataExists)
            using (File.Create(carcolsDatDir))
            {
                //nothing
            }

        var tag = vehicle.cars3 ? "cars3\n" : "cars4\n";
        ModExporter.AddDataIntoFiles(vehicle._carcols, ',', carcolsDatDir, tag);
        return true;
    }

    public bool CanExport()
    {
        return vehicle._carcols != null;
    }
}