using System.IO;

namespace SOLIDFilesAnalyzerCSharp.InitialConfig
{
  internal interface ReadFilesFromInterface
  {
    public virtual void ReadFiles(DriveInfo di) { }
    public virtual void ReadFiles(string endpoint) { }
  }
}
