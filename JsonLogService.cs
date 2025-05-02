using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DirectorySyncMVP
{
  public class JsonLogService : ILogService
  {
    public List<SyncLogEntry> Load(string path)
    {
      if (!File.Exists(path))
        return new List<SyncLogEntry>();

      var json = File.ReadAllText(path);
      return JsonSerializer.Deserialize<List<SyncLogEntry>>(json);
    }

    public void Save(string path, List<SyncLogEntry> entries)
    {
      var json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
      File.WriteAllText(path, json);
    }
  }
}