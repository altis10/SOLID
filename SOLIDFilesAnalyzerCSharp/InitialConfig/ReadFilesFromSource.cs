using SOLIDFilesAnalyzerCSharp.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;

namespace SOLIDFilesAnalyzerCSharp.InitialConfig
{
  internal class ReadFilesFromSource : ReadFilesFromInterface
  {
    static StringCollection log = new();
    private List<FileInfo> _allFiles = null;
    public List<FileInfo> AllFiles { get { return _allFiles; } }

    // public void ReadFiles(DriveInfo di, BackgroundWorker worker, DoWorkEventArgs e)

    public void ProcessFiles(WhatAndWhereToSearch wawtoSearch, BackgroundWorker worker, DoWorkEventArgs e)
    {
      if (worker.CancellationPending)
      {
        e.Cancel = true;
      }
      else
      {
        if (wawtoSearch.searchLocation == FilesLocation.local)
        { ReadFiles(wawtoSearch); }
      }
    }

    public void ReadFiles(WhatAndWhereToSearch waw)
    {
      //// Here we skip the drive if it is not ready to be read. This
      //// is not necessarily the appropriate action in all scenarios.
      //if (waw.startSearchOn == null || !waw.startSearchOn.IsReady)
      //{
      //  Console.WriteLine("The drive {0} could not be read", waw.startSearchOn?.Name);
      //  throw new Exception("Unreadable drive");
      //}
      DirectoryInfo? rootDir = waw.startSearchOn;
      if (rootDir != null)
      {
        WalkDirectoryTree(rootDir, waw.searchForFileTypes);
      }
      
      // Write out all the files that could not be processed.
      Console.WriteLine("Files with restricted access:");
      foreach (string s in log)
      {
        Console.WriteLine(s);
      }
      // Keep the console window open in debug mode.
      // Console.WriteLine("Press any key");
      // Console.ReadKey();
    }

    private void WalkDirectoryTree(DirectoryInfo root, List<string> extensions)
    {
      FileInfo[]? files = null;
      // IEnumerable<FileInfo>? files = null;
      DirectoryInfo[]? subDirs = null;

      // First, process all the files directly under this folder
      try
      {
        foreach (string ext in extensions)
        {
          files = root.GetFiles("*" + ext);
          // files = root.EnumerateFiles("*" + ext);
          if (_allFiles == null)
          { _allFiles = new List<FileInfo>(); }
          _allFiles?.AddRange(files);
          files = null;
        }

        // Now find all the subdirectories under this directory.
        subDirs = root.GetDirectories();

        foreach (DirectoryInfo dirInfo in subDirs)
        {
          // Resursive call for each subdirectory.
          WalkDirectoryTree(dirInfo, extensions);
        }
      }
      // This is thrown if even one of the files requires permissions greater
      // than the application provides.
      catch (UnauthorizedAccessException e)
      {
        // This code just writes out the message and continues to recurse.
        // You may decide to do something different here. For example, you
        // can try to elevate your privileges and access the file again.
        log.Add(e.Message);
      }

      catch (DirectoryNotFoundException e)
      {
        Console.WriteLine(e.Message);
      }

      catch (IOException e)
      {
        log.Add(e.Message);
      }

      if (files != null)
      {
        foreach (FileInfo fi in files)
        {
          // In this example, we only access the existing FileInfo object. If we
          // want to open, delete or modify the file, then
          // a try-catch block is required here to handle the case
          // where the file has been deleted since the call to TraverseTree().
          Console.WriteLine(fi.FullName);
        }
      }
    }
  }
}
