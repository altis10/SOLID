using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDFilesAnalyzerCSharp.Models
{
  internal enum FilesLocation
  {
    local,
    web
  }

  internal class WhatAndWhereToSearch
  {
    internal List<string> searchForFileTypes;
    internal FilesLocation searchLocation;
    internal DirectoryInfo? startSearchOn;
    private string pathToSearch;

    public string PathToSearch
    {
      get { return pathToSearch; }
      set 
      {
        pathToSearch = value;
        startSearchOn = new DirectoryInfo(pathToSearch);
      }
    }
    public WhatAndWhereToSearch()
    {
      searchForFileTypes = new List<string>();
      searchLocation = new FilesLocation();
      startSearchOn = new DirectoryInfo(DriveInfo.GetDrives()[0].Name);
    }


  }
}
