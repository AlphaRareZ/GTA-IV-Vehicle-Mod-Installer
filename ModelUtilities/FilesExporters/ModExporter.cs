using C__MOD_INSTALLER.Model;

namespace C__MOD_INSTALLER.ModelUtilities.FilesExporters;

public class ModExporter
{
    public bool ExportMod(Vehicle vehicle)
    {
        var vehicleDirInModLoader = Path.Combine(Model.ModInstaller.GetGameDir(), "modloader", vehicle._vehicleName);

        IExporter texturesExporter = new TexturesExporter(vehicle, vehicleDirInModLoader);
        IExporter vehicleDataExporter = new VehicleDataExporter(vehicle, vehicleDirInModLoader);
        IExporter handlingDataExporter = new HandlingDataExporter(vehicle, vehicleDirInModLoader);
        IExporter carColsExporter = new CarcolsDataExporter(vehicle, vehicleDirInModLoader);

        if (!(texturesExporter.CanExport() && vehicleDataExporter.CanExport())) return false;

        if (!Directory.Exists(vehicleDirInModLoader)) Directory.CreateDirectory(vehicleDirInModLoader);


        if (!vehicleDataExporter.Export())
        {
            MessageBox.Show("Couldn't Export Vehicle Data\nMod Will Not Work.");
            return false;
        }

        if (!texturesExporter.Export())
        {
            MessageBox.Show("Couldn't Export Textures\nMod Will Not Work.");
            return false;
        }


        if (!handlingDataExporter.Export())
        {
            // will work properly because it will copy data of existing vehicle which is provided in vehicleData
        }

        if (!carColsExporter.Export())
        {
            // will work properly because it is Optional 
        }

        return true;
    }

    private static void AppendTextToFile(string path, string text)
    {
        try
        {
            using var sw = new StreamWriter(path, true);
            sw.Write(text);
            sw.Close();
        }
        catch (Exception e)
        {
            MessageBox.Show("An unexpected error occurred:" + e.Message);
        }
    }

    internal static void AddDataIntoFiles(List<string>? list, char delimiter, string dir, string tag)
    {
        AppendTextToFile(dir, tag);
        if (list != null)
            for (var i = 0; i < list.Count; i++)
            {
                var data = list[i];
                if (i != list.Count - 1) data += delimiter;
                AppendTextToFile(dir, data);
            }

        AppendTextToFile(dir, "\nend");
    }
}