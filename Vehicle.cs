using System.Runtime.CompilerServices;

namespace ModInstaller;

internal class Vehicle
{
    internal List<String> vehicleData = null;
    internal List<String> handlingData = null;

    private string vehicleName;

    public Vehicle(string vehicleName)
    {
        this.vehicleName = vehicleName;
    }

    public bool processHandlingAndVehicleData()
    {
        // i got vehicle data and no handling string 
        if (vehicleData != null && handlingData == null)
        {
            // Model name, Txd name, Type, HandlingId, Game name,
            vehicleData[0] = vehicleName;
            vehicleData[1] = vehicleName;
            vehicleData[4] = vehicleName.ToUpper();
            return true;
        }

        else if (vehicleData == null && handlingData != null)
        {
            vehicleData = Splitter.splitVehicle(ModInstaller.retrieveVehicle(handlingData[0].ToLower()));
            vehicleData[0] = vehicleName;
            vehicleData[1] = vehicleName;
            vehicleData[4] = vehicleName.ToUpper();
            handlingData[0] = vehicleName.ToUpper();
            return true;
        }

        else if (vehicleData != null && handlingData != null)
        {
            // vehicle data
            vehicleData[0] = vehicleName;
            vehicleData[1] = vehicleName;
            vehicleData[3] = vehicleName.ToUpper();
            vehicleData[4] = vehicleName.ToUpper();
            // handling data
            handlingData[0] = vehicleName.ToUpper();
            return true;
        }
        return false;
    }

    internal void exportVehiclesAndHandling(string dir)
    {
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        var vehiclesDir = dir + @"\vehicles.ide";
        var handlingDir = dir + @"\handling.dat";

        var vehicleDataExists = vehicleData != null;
        var handlingDataExists = handlingData != null;

        if (!File.Exists(vehiclesDir) && vehicleDataExists)
        {
            using (File.Create(vehiclesDir)){}
        }

        if (!File.Exists(handlingDir) && handlingDataExists)
        {
            using (File.Create(handlingDir)){}
        }

        if (handlingDataExists)
            addDataIntoFiles(handlingData, ' ', handlingDir);
        if (vehicleDataExists)
            addDataIntoFiles(vehicleData, ',', vehiclesDir);
    }

    private void appendTextToFile(string path, string text)
    {
        try
        {
            // Using StreamWriter to append text to the file
            using StreamWriter sw = new StreamWriter(path, true);
            sw.Write(text);
            sw.Close();
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine("The directory specified could not be found:");
            Console.WriteLine();
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("You do not have permission to write to this file:");
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("An I/O error occurred while writing to the file:");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred:");
            Console.WriteLine(e.Message);
        }
    }

    private void addDataIntoFiles(List<String> list, char delimiter, string dir)
    {
        appendTextToFile(dir, "cars\n");
        for (int i = 0; i < list.Count; i++)
        {
            string data = list[i];

            if (i != list.Count - 1)
            {
                data += delimiter;
            }

            appendTextToFile(dir, data);
        }

        appendTextToFile(dir, "\nend");
    }
}