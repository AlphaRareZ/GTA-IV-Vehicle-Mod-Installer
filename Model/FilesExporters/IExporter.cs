namespace C__MOD_INSTALLER.Model.FilesExporters
{
    public interface IExporter
    {
        
        public bool Export();
        public bool CanExport();
    }
}