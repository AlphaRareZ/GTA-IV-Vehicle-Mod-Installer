namespace C__MOD_INSTALLER.ControllerEventArgs;

public class GameDirChangedArgs(string gameDir, Button button) : EventArgs
{
    public string GameDir { get; private set; } = gameDir;
    public Button Button { get; private set; } = button;
}