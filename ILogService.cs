using System.Collections.Generic;

namespace DirectorySyncMVP
{
  public interface ILogService
  {
    List<SyncLogEntry> Load(string path);
    void Save(string path, List<SyncLogEntry> entries);
  }
}