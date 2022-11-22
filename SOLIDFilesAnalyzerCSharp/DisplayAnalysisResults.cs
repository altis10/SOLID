using GroupDocs.Metadata;
using GroupDocs.Metadata.Common;
using GroupDocs.Metadata.Tagging;
using SOLIDFilesAnalyzerCSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SOLIDFilesAnalyzerCSharp
{
  public partial class DisplayAnalysisResults : Form
  {
    public DisplayAnalysisResults()
    {
      InitializeComponent();
      InitializeBackgroundWorker();
    }

    private void AnalyseFilesProperties(List<FileInfo> files, BackgroundWorker worker, DoWorkEventArgs e)
    {
      foreach (FileInfo file in files)
      {
        using (Metadata metadata = new Metadata(file.FullName))
        {
          if (metadata.FileFormat != FileFormat.Unknown && !metadata.GetDocumentInfo().IsEncrypted)
          {
            // fetch all metadata properties that fall into a particular category
            var properties = metadata.FindProperties(p => p.Tags.Any(t => t.Category == Tags.Content));
            Console.WriteLine("The metadata properties describing some characteristics of the file content: title, keywords, language, etc.");
            foreach (var property in properties)
            {
              Console.WriteLine("{0} = {1}", property.Name, property.Value);
            }

            // fetch all properties having a specific type and value
            var year = DateTime.Today.Year;
            properties = metadata.FindProperties(p => p.Value.Type == MetadataPropertyType.DateTime &&
            p.Value.ToStruct(DateTime.MinValue).Year == year);

            Console.WriteLine("All datetime properties with the year value equal to the current year");
            foreach (var property in properties)
            {
              Console.WriteLine("{0} = {1}", property.Name, property.Value);
            }
          }
        }
      }
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
      //dataGridViewDetectedFiles.DataSource = rfs.AllFiles.ToArray();
      //buttonScan.Enabled = true;
      //buttonSearchFolder.Enabled = true;
    }
  }
}
