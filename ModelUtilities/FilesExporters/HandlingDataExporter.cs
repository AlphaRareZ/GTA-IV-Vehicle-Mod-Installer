using C__MOD_INSTALLER.Model;

namespace C__MOD_INSTALLER.ModelUtilities.FilesExporters;

internal class HandlingDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
{
    public bool Export()
    {
        var handlingDataExists = vehicle._handlingData != null;
        if (!handlingDataExists) return false;

        var handlingDatDir = modLoaderDir + @"\handling.dat";
        if (!File.Exists(handlingDatDir) && handlingDataExists)
            using (File.Create(handlingDatDir))
            {
                // nothing
            }

        ModExporter.AddDataIntoFiles(vehicle._handlingData, ' ', handlingDatDir, "cars\n");
        return true;
    }

    public bool CanExport()
    {
        return vehicle._handlingData != null;
    }
}