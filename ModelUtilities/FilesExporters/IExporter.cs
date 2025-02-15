namespace C__MOD_INSTALLER.ModelUtilities.FilesExporters;

public interface IExporter
{
    public bool Export();
    public bool CanExport();
}