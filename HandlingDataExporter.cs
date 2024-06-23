using ModInstaller;

namespace C__MOD_INSTALLER
{
    internal class HandlingDataExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public void Export()
        {
            var handlingDatDir = modLoaderDir + @"\handling.dat";
            var handlingDataExists = vehicle.GetHandlingData() != null;
            if (!File.Exists(handlingDatDir) && handlingDataExists)
            {
                using (File.Create(handlingDatDir))
                {
                }
            }

            if (handlingDataExists)
                DataExporter.AddDataIntoFiles(vehicle.GetHandlingData(), ' ', handlingDatDir, "cars\n");
        }
    }
}