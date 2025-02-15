using C__MOD_INSTALLER.Model;

namespace C__MOD_INSTALLER.ModelUtilities.FilesExporters;

internal class TexturesExporter(Vehicle vehicle, string modLoaderDir) : IExporter
{
    public bool Export()
    {
        try
        {
            if (vehicle._wftDir != null)
                File.Copy(vehicle._wftDir, Path.Combine(modLoaderDir, $"{vehicle._vehicleName}.wft"));
            if (vehicle._wtdDir != null)
                File.Copy(vehicle._wtdDir, Path.Combine(modLoaderDir, $"{vehicle._vehicleName}.wtd"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }

        return true;
    }

    public bool CanExport()
    {
        return File.Exists(vehicle._wftDir) && File.Exists(vehicle._wtdDir);
    }
}