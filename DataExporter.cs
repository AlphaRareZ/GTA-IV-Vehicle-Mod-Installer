using C__MOD_INSTALLER;

namespace ModInstaller;

public class DataExporter
{
    
    public void ExportMod(Vehicle vehicle)
    {
        var vehicleDirInModLoader = Path.Combine(ModInstaller.GetGameDir(), "modloader", vehicle.GetVehicleName());
        if (!Directory.Exists(vehicleDirInModLoader))
        {
            Directory.CreateDirectory(vehicleDirInModLoader);
        }

        IExporter texturesExporter = new TexturesExporter(vehicle, vehicleDirInModLoader);
        IExporter handlingDataExporter = new HandlingDataExporter(vehicle, vehicleDirInModLoader);
        IExporter vehicleDataExporter = new VehicleDataExporter(vehicle, vehicleDirInModLoader);
        IExporter carColsExporter = new CarcolsDataExporter(vehicle, vehicleDirInModLoader);
        
        texturesExporter.Export();
        handlingDataExporter.Export();
        vehicleDataExporter.Export();
        carColsExporter.Export();
    }
    
    private static void AppendTextToFile(string path, string text)
    {
        try
        {
            using StreamWriter sw = new StreamWriter(path, true);
            sw.Write(text);
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred:");
            Console.WriteLine(e.Message);
        }
    }

    internal static void AddDataIntoFiles(List<string>? list, char delimiter, string dir, string tag)
    {
        AppendTextToFile(dir, tag);
        for (int i = 0; i < list.Count; i++)
        {
            string data = list[i];

            if (i != list.Count - 1)
            {
                data += delimiter;
            }

            AppendTextToFile(dir, data);
        }

        AppendTextToFile(dir, "\nend");
    }
}