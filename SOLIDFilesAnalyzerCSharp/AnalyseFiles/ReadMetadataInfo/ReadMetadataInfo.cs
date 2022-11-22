using GroupDocs.Metadata;
using GroupDocs.Metadata.Common;
using System.Security.Cryptography.X509Certificates;

namespace SOLIDFilesAnalyzerCSharp.ReadMetadataInfo
{
  internal class ReadMetadataInfo
  {
    private string filePath;

    public string FilePath { get { return filePath; } set { filePath = value; } }

    public IDocumentInfo? GetDocumentInfo(string docPath)
    {
      IDocumentInfo? documentInfo = null;
      Metadata metadata;

      if (docPath != null)
      {
        metadata = new Metadata(docPath);
        documentInfo =  metadata.GetDocumentInfo();
      }

      return documentInfo;
    }
  }
}
