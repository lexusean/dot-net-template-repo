Func<ICakeContext> ContextFunc = new Func<ICakeContext>(() => this); 
public class Context
{
    ICakeContext CakeContext 
    { 
        get { return ContextFunc(); } 
    }
}

public class BuildContext : Context
{
    private static Lazy<BuildContext> _lazy = new Lazy<BuildContext>(() => new BuildContext());
    public static BuildContext Singleton
    {
        get { return _lazy.Value; }
    }

    public DirectoryPath BaseDirectory { get; set; }
    
    //Args
    public string Target { get; set; }
    public string BuildConfiguration { get; set; }
    public string Verbosity { get; set; }
    
    //Dir
    private string _BaseDirectoryStr;
    public string BaseDirectoryStr
    {
        get { return this._BaseDirectoryStr; }
        set
        {
            this._BaseDirectoryStr = value;
            this.UpdateDirectories();
        }
    } 
    public DirectoryPath BaseDirectory { get; private set; }

    private string _ArtifactsDirectoryStr = "/artifacts";
    public string ArtifactsDirectoryStr
    {
        get { return this._ArtifactsDirectoryStr; }
        set
        {
            this._ArtifactsDirectoryStr = value;
            this.UpdateDirectories();
        }
    } 
    public DirectoryPath ArtifactsDirectory { get; private set; }

    private string _TestsDirectoryStr = "/test";
    public string TestsDirectoryStr
    {
        get { return this._TestsDirectoryStr; }
        set
        {
            this._TestsDirectoryStr = value;
            this.UpdateDirectories();
        }
    } 
    public DirectoryPath TestsDirectory { get; private set; }

    private string _TestResultsDirectoryStr = "/testresults";
    public string TestResultsDirectoryStr
    {
        get { return this._TestResultsDirectoryStr; }
        set
        {
            this._TestResultsDirectoryStr = value;
            this.UpdateDirectories();
        }
    } 
    public DirectoryPath TestResultsDirectory { get; private set; }

    public bool RunClean { get; set; }
    public bool RunRestore { get; set; }
    public bool RunBuild { get; set; }
    public bool RunBuildDocumentation { get; set; }
    public bool RunUnitTests { get; set; }
    public bool RunIntegrationTests { get; set; }
    public bool RunCoverage { get; set; }
    public bool RunCodeAnalysis { get; set; }
    public bool RunPackage { get; set; }
    public bool RunPublish { get; set; }
    public GitVersion Version { get; set; }

    private void UpdateDirectories()
    {

    } 
}