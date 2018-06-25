var CleanTask = Task("Clean")
  .Does(() =>
  {
    Information("Performing clean operation...");

    // get project clean directories first
    var cleanDirs = GetCleanDirectories(Context, allProjectFiles).ToList();
    //add addition directories to be cleaned
    cleanDirs.Add(buildTmpDirectory);
    cleanDirs.Add(artifactsDirectory);
    cleanDirs.Add(testsDirectory);

    foreach(var dir in cleanDirs)
    {
      EnsureDirectoryExists(dir);
    }

    foreach(var dir in cleanDirs)
    {
      Verbose("Cleaning Directory: {0}", dir);
      CleanDirectory(dir, fs => {
        return fs.Path.FullPath != dir.FullPath;
      });
    }

    Information("Clean operation done!");
  });