using ModInstaller;

namespace C__MOD_INSTALLER
{
    internal class TexturesExporter(Vehicle vehicle, string modLoaderDir) : IExporter
    {
        public void Export()
        {
            File.Copy(vehicle.GetWftDir(), Path.Combine(modLoaderDir, $"{vehicle.GetVehicleName()}.wft"));
            File.Copy(vehicle.GetWtdDir(), Path.Combine(modLoaderDir, $"{vehicle.GetVehicleName()}.wtd"));
        }
    }
}