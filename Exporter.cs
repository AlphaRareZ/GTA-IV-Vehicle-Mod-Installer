namespace ModInstaller;

public class DataExporter
{
    public void ExportMod( Vehicle vehicle)
    {
        var vehicleDirInModLoader = Path.Combine(ModInstaller.GetGameDir(), "modloader", vehicle.GetVehicleName());

        // Ensure the target directory exists
        if (!Directory.Exists(vehicleDirInModLoader))
        {
            Directory.CreateDirectory(vehicleDirInModLoader);
        }

        // Copy the files to the target directory
        File.Copy(vehicle.GetWftDir(), Path.Combine(vehicleDirInModLoader, $"{vehicle.GetVehicleName()}.wft"));
        File.Copy(vehicle.GetWtdDir(), Path.Combine(vehicleDirInModLoader, $"{vehicle.GetVehicleName()}.wtd"));
        

        var vehiclesIdeDir = vehicleDirInModLoader + @"\vehicles.ide";
        var handlingDatDir = vehicleDirInModLoader + @"\handling.dat";

        var vehicleDataExists = vehicle.GetVehicleData() != null;
        var handlingDataExists = vehicle.GetHandlingData() != null;

        if (!File.Exists(vehiclesIdeDir) && vehicleDataExists)
        {
            using (File.Create(vehiclesIdeDir))
            {
            }
        }

        if (!File.Exists(handlingDatDir) && handlingDataExists)
        {
            using (File.Create(handlingDatDir))
            {
            }
        }

        if (handlingDataExists)
            AddDataIntoFiles(vehicle.GetHandlingData(), ' ', handlingDatDir);
        if (vehicleDataExists)
            AddDataIntoFiles(vehicle.GetVehicleData(), ',', vehiclesIdeDir);
    }

    private void AppendTextToFile(string path, string text)
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

    private void AddDataIntoFiles(List<string>? list, char delimiter, string dir)
    {
        AppendTextToFile(dir, "cars\n");
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