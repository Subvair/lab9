using System.Collections.Generic;

namespace DirectorySyncMVP
{
  public class SyncPresenter
  {
    private readonly IView _view;
    private readonly SyncModel _model;

    public SyncPresenter(IView view)
    {
        _view = view;

        ILogService logService = _view.UseXmlLog
            ? new XmlLogService()
            : new JsonLogService();

        _model = new SyncModel(logService);
        _view.SyncRequested += OnSyncRequested;
    }

        private void OnSyncRequested()
    {
      var entries = new List<SyncLogEntry>();
      var result = _model.SyncDirectories(_view.Directory1Path, _view.Directory2Path, _view.UseXmlLog, out entries);

      foreach (var message in result)
      {
        _view.ShowLog(message);
      }
    }
  }
}