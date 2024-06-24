namespace C__MOD_INSTALLER.Model.FilesExporters
{
    internal class HandlingDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public bool Export()
        {
            var handlingDataExists = vehicle.GetHandlingData() != null;
            if (!handlingDataExists) return false;

            var handlingDatDir = modLoaderDir + @"\handling.dat";
            if (!File.Exists(handlingDatDir) && handlingDataExists)
            {
                using (File.Create(handlingDatDir))
                {
                    // nothing
                }
            }

            ModExporter.AddDataIntoFiles(vehicle.GetHandlingData(), ' ', handlingDatDir, "cars\n");
            return true;
        }
    }
}