using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace C__MOD_INSTALLER.Model
{
    internal class CarcolsDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public bool Export()
        {
            var carcolsDatDir = modLoaderDir + @"\carcols.dat";

            var carcolsDataExists = vehicle.getCarcolsData() != null;


            if (!File.Exists(carcolsDatDir) && carcolsDataExists)
            {
                using (File.Create(carcolsDatDir))
                {
                }
            }

            if (!carcolsDataExists) return false;
            ModExporter.AddDataIntoFiles(vehicle.getCarcolsData(), ',', carcolsDatDir,
                vehicle.getCars3() ? "cars3\n" : "cars4\n");
            return true;
        }
    }
}