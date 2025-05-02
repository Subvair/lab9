namespace DirectorySyncMVP
{
  public interface IView
  {
    string Directory1Path { get; }
    string Directory2Path { get; }
    bool UseXmlLog { get; }
    event Action SyncRequested;
    void ShowLog(string message);
  }
}