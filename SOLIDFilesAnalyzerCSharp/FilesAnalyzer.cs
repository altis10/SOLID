using SOLIDFilesAnalyzerCSharp.InitialConfig;
using SOLIDFilesAnalyzerCSharp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Environment;
using System.Windows.Forms;

namespace SOLIDFilesAnalyzerCSharp
{
  public partial class FilesAnalyzer : Form, ReadFilesFromInterface
  {
    internal ReadFilesFromSource rfs;
    private WhatAndWhereToSearch wawtoSearch;
    internal DisplayAnalysisResults displayAnalysinsResults;


    internal Dictionary<string, string> FileTypes = new Dictionary<string, string>
    {
      { "txt", ".txt"},
      { "pdf", ".pdf" },
      { "mp3", ".mp3" },
      { "mp4", ".mp4" },
      { "exe", ".exe" },
      { "avi", ".avi" }
    };

    public FilesAnalyzer()
    {
      wawtoSearch = new WhatAndWhereToSearch();
      displayAnalysinsResults = new DisplayAnalysisResults();
      InitializeComponent();
      InitializeBackgroundWorker();
      rfs = new ReadFilesFromSource();
      scanLocalDrivesRadioButton.Checked = true;
      folderBrowserDialog_Select.RootFolder = SpecialFolder.MyComputer;
    }

    private void scanLocalDrivesRadioButton_CheckedChanged(object sender, System.EventArgs e)
    {
      if (scanLocalDrivesRadioButton.Checked)
        wawtoSearch.searchLocation = FilesLocation.local;
    }

    private void webScanLocationRadioButton_CheckedChanged(object sender, System.EventArgs e)
    {
      if (!scanLocalDrivesRadioButton.Checked)
        wawtoSearch.searchLocation = FilesLocation.web;
    }

    private void buttonScan_Click(object sender, System.EventArgs e)
    {
      if (wawtoSearch.searchForFileTypes.Count != 0)
      {
        buttonScan.Enabled = false;
        buttonSearchFolder.Enabled = false;
        backgroundWorkerDetectFiles.RunWorkerAsync(wawtoSearch);
      }
      else
      {
        MessageBox.Show("Select one or more file types before pressing the Scan button!");
      }  
    }

    private void backgroundWorkerDetectFiles_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker? worker = sender as BackgroundWorker;
      rfs.ProcessFiles((WhatAndWhereToSearch)e.Argument, worker, e);
      e.Result = rfs.AllFiles;
    }

    private void backgroundWorkerDetectFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      dataGridViewDetectedFiles.DataSource = rfs.AllFiles.ToArray();
      buttonScan.Enabled = true;
      buttonSearchFolder.Enabled = true;
    }

    private void backgroundWorkerDetectFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {

    }

    private void InitializeBackgroundWorker()
    {
      backgroundWorkerDetectFiles.DoWork += new DoWorkEventHandler(backgroundWorkerDetectFiles_DoWork);
      backgroundWorkerDetectFiles.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
      backgroundWorkerDetectFiles_RunWorkerCompleted);
      backgroundWorkerDetectFiles.ProgressChanged += new ProgressChangedEventHandler(
      backgroundWorkerDetectFiles_ProgressChanged);
    }

    private void textFilesCheckBox_CheckedChanged(object sender, System.EventArgs e)
    {
      if (this.textFilesCheckBox.Checked)
        wawtoSearch.searchForFileTypes.Add(FileTypes["txt"]);
    }

    private void mp4CheckBox_CheckedChanged(object sender, System.EventArgs e)
    {
      if (this.mp4CheckBox.Checked)
        wawtoSearch.searchForFileTypes.Add(FileTypes["mp4"]);
    }

    private void pdfCheckBox_CheckedChanged(object sender, System.EventArgs e)
    {
      if (this.pdfCheckBox.Checked)
        wawtoSearch.searchForFileTypes.Add(FileTypes["pdf"]);
    }

    private void aviCheckBox_CheckedChanged(object sender, System.EventArgs e)
    {
      if (this.aviCheckBox.Checked)
        wawtoSearch.searchForFileTypes.Add(FileTypes["avi"]);
    }

    private void mp3CheckBox_CheckedChanged(object sender, System.EventArgs e)
    {
      if (this.mp3CheckBox.Checked)
        wawtoSearch.searchForFileTypes.Add(FileTypes["mp3"]);
    }

    private void exeCheckBox_CheckedChanged(object sender, System.EventArgs e)
    {
      if (this.exeCheckBox.Checked)
        wawtoSearch.searchForFileTypes.Add(FileTypes["exe"]);
    }

    private void textBoxCustomFileType_TextChanged(object sender, System.EventArgs e)
    {
      if (!string.IsNullOrEmpty(textBoxCustomFileType.Text))
        wawtoSearch.searchForFileTypes.Add(this.textBoxCustomFileType.Text);
    }

    private void buttonSearchFolder_Click(object sender, System.EventArgs e)
    {
      DialogResult dr = folderBrowserDialog_Select.ShowDialog();
      if (dr == DialogResult.OK)
      {
        wawtoSearch.PathToSearch = folderBrowserDialog_Select.SelectedPath;
        textBoxSearchFolder.Text = folderBrowserDialog_Select.SelectedPath;
      }
    }

    private void buttonAnalyseFiles_Click(object sender, System.EventArgs e)
    {
      displayAnalysinsResults.Show();
      displayAnalysinsResults.RetrieveMetadata(rfs.AllFiles);
    }
  }
}