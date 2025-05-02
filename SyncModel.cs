using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectorySyncMVP
{
    public class SyncModel
    {
        private readonly ILogService _logService;

        public SyncModel(ILogService logService)
        {
            _logService = logService;
        }

        public List<string> SyncDirectories(string dir1, string dir2, bool useXml, out List<SyncLogEntry> logEntries)
        {
            var logPath = useXml ? "log.xml" : "log.json";
            logEntries = _logService.Load(logPath);

            var result = new List<string>();
            SyncOneWay(dir1, dir2, logEntries, result);
            SyncOneWay(dir2, dir1, logEntries, result);

            _logService.Save(logPath, logEntries);
            return result;
        }

        private void SyncOneWay(string sourceDir, string targetDir, List<SyncLogEntry> log, List<string> output)
        {
            var sourceFiles = Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories)
                                       .Select(f => f.Substring(sourceDir.Length + 1))
                                       .ToHashSet();

            var targetFiles = Directory.GetFiles(targetDir, "*", SearchOption.AllDirectories)
                                       .Select(f => f.Substring(targetDir.Length + 1))
                                       .ToHashSet();

            foreach (var file in sourceFiles)
            {
                var srcFile = Path.Combine(sourceDir, file);
                var tgtFile = Path.Combine(targetDir, file);
                var timestamp = File.GetLastWriteTime(srcFile);

                if (!File.Exists(tgtFile))
                {
                    var targetDirectory = Path.GetDirectoryName(tgtFile);
                    if (!string.IsNullOrEmpty(targetDirectory))
                    {
                        Directory.CreateDirectory(targetDirectory);
                    }

                    File.Copy(srcFile, tgtFile, true);
                    output.Add($"Файл \"{file}\" создан");
                    log.Add(new SyncLogEntry { Path = file, Action = "Created", Timestamp = timestamp });
                }
                
                else if (timestamp > File.GetLastWriteTime(tgtFile))
                {
                    File.Copy(srcFile, tgtFile, true);
                    output.Add($"Файл \"{file}\" изменен");
                    log.Add(new SyncLogEntry { Path = file, Action = "Modified", Timestamp = timestamp });
                }
            }

            foreach (var file in targetFiles.Except(sourceFiles))
            {
                var tgtFile = Path.Combine(targetDir, file);
                File.Delete(tgtFile);
                output.Add($"Файл \"{file}\" удален");
                log.Add(new SyncLogEntry { Path = file, Action = "Deleted", Timestamp = DateTime.Now });
            }
        }
    }
}
