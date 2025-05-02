using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DirectorySyncMVP
{
  public class XmlLogService : ILogService
  {
    public List<SyncLogEntry> Load(string path)
    {
      if (!File.Exists(path))
      {
        return new List<SyncLogEntry>();
      }
      var serializer = new XmlSerializer(typeof(List<SyncLogEntry>));
      using var stream = File.OpenRead(path);
      return (List<SyncLogEntry>)serializer.Deserialize(stream);
    }

    public void Save(string path, List<SyncLogEntry> entries)
    {
      var serializer = new XmlSerializer(typeof(List<SyncLogEntry>));
      using var stream = File.Create(path);
      serializer.Serialize(stream, entries);
    }
  }
}