namespace C__MOD_INSTALLER.Model.FilesExporters
{
    internal class CarcolsDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public bool Export()
        {
            var carcolsDataExists = vehicle.getCarcolsData() != null;
            if (!carcolsDataExists) return false;

            var carcolsDatDir = modLoaderDir + @"\carcols.dat";
            if (!File.Exists(carcolsDatDir) && carcolsDataExists)
            {
                using (File.Create(carcolsDatDir))
                {
                    //nothing
                }
            }

            string tag = vehicle.getCars3() ? "cars3\n" : "cars4\n";
            ModExporter.AddDataIntoFiles(vehicle.getCarcolsData(), ',', carcolsDatDir, tag);
            return true;
        }

        public bool CanExport()
        {
            return vehicle.getCarcolsData() != null;
        }
    }
}