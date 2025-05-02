using System;

namespace DirectorySyncMVP
{
  public class SyncLogEntry
  {
    public string Path { get; set; }
    public string Action { get; set; }
    public DateTime Timestamp { get; set; }
  }
}