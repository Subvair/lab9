using System;
using System.Windows.Forms;

namespace DirectorySyncMVP
{
  public partial class Form1 : Form, IView
  {
    public string Directory1Path => textBoxDir1.Text;
    public string Directory2Path => textBoxDir2.Text;
    public bool UseXmlLog => radioXml.Checked;
    public event Action SyncRequested;

    public Form1()
    {
      InitializeComponent();
      new SyncPresenter(this);
    }

    public void ShowLog(string message)
    {
      listBoxLog.Items.Add(message);
    }

    private void buttonSync_Click(object sender, EventArgs e)
    {
      SyncRequested?.Invoke();
    }

    private void buttonBrowse1_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {      
        textBoxDir1.Text = folderBrowserDialog.SelectedPath;
      }
    }

    private void buttonBrowse2_Click(object sender, EventArgs e)
    {
      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        textBoxDir2.Text = folderBrowserDialog.SelectedPath;
      }
    }
  }
}