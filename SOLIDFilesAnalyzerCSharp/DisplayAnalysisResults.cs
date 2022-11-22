using SOLIDFilesAnalyzerCSharp.AnalyseFiles.ReadMP3Tag;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;
using TagLib;
using File = TagLib.File;
using FileTypes = TagLib.FileTypes;

namespace SOLIDFilesAnalyzerCSharp
{
  public partial class DisplayAnalysisResults : Form
  {
    Mp3Tag mp3Tag;
    List<Mp3Tag> mp3Tags;
    Mp3Reader? mp3Reader;
    List<File> fullPropFiles;
    Properties properties;
    Tag tag;

    public DisplayAnalysisResults()
    {
      mp3Tag = new Mp3Tag();
      mp3Tags = new List<Mp3Tag>();
      fullPropFiles = new List<File>();

      InitializeComponent();
      InitializeBackgroundWorker();
    }

    private void AnalyseFilesProperties(List<FileInfo> files, BackgroundWorker worker, DoWorkEventArgs e)
    {
      List<FileInfo> notKnownExtension = new List<FileInfo>();
      foreach (FileInfo file in files)
      {
        if (file.Extension == ".mp3")
        {
          mp3Reader = new Mp3Reader(file.FullName);
          mp3Tags.Add(mp3Reader.GetTag());
        }

        try
        {
          var tfile = File.Create(file.FullName);
          fullPropFiles.Add(tfile);
        }
        catch (UnsupportedFormatException)
        {
          notKnownExtension.Add(file);
        }
      }
      var d = fullPropFiles;
    }

    public void RetrieveMetadata(List<FileInfo> files)
    {
      backgroundWorkerAnalyseFilesProperties.RunWorkerAsync(files);
    }

    private void InitializeBackgroundWorker()
    {
      backgroundWorkerAnalyseFilesProperties.DoWork += new DoWorkEventHandler(backgroundWorkerAnalyseFilesProperties_DoWork);
      backgroundWorkerAnalyseFilesProperties.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
      backgroundWorkerAnalyseFilesProperties_RunWorkerCompleted);
      backgroundWorkerAnalyseFilesProperties.ProgressChanged += new ProgressChangedEventHandler(
      backgroundWorkerAnalyseFilesProperties_ProgressChanged);
    }

    private void backgroundWorkerAnalyseFilesProperties_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker? worker = sender as BackgroundWorker;
      AnalyseFilesProperties((List<FileInfo>)e.Argument, worker, e);
      // e.Result = rfs.AllFiles;
    }

    private void backgroundWorkerAnalyseFilesProperties_ProgressChanged(object? sender, ProgressChangedEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void backgroundWorkerAnalyseFilesProperties_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
    {
      dataGridViewDisplayAnalysisResults.DataSource = fullPropFiles.ToArray();
      //buttonScan.Enabled = true;
      //buttonSearchFolder.Enabled = true;
    }
  }
}
