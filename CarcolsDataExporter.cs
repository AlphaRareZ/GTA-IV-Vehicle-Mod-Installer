using ModInstaller;

namespace C__MOD_INSTALLER
{
    internal class CarcolsDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public void Export()
        {
            
            var carcolsDatDir = modLoaderDir + @"\carcols.dat";

            var carcolsDataExists = vehicle.getCarcolsData() != null;


            if (!File.Exists(carcolsDatDir) && carcolsDataExists)
            {
                using (File.Create(carcolsDatDir))
                {
                }
            }

            if (carcolsDataExists)
                DataExporter.AddDataIntoFiles(vehicle.getCarcolsData(), ',', carcolsDatDir, vehicle.getCars3()?"cars3\n":"cars4\n");
            
            
        }
    }
}