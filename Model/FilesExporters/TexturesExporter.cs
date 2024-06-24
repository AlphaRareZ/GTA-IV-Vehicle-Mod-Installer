namespace C__MOD_INSTALLER.Model.FilesExporters
{
    internal class TexturesExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public bool Export()
        {
            try
            {
                File.Copy(vehicle.GetWftDir(), Path.Combine(modLoaderDir, $"{vehicle.GetVehicleName()}.wft"));
                File.Copy(vehicle.GetWtdDir(), Path.Combine(modLoaderDir, $"{vehicle.GetVehicleName()}.wtd"));
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
            return File.Exists(vehicle.GetWftDir()) && File.Exists(vehicle.GetWtdDir());
        }
    }
}