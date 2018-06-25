public class SlnContext : Context
{
    private FilePath _SlnFile;
    public FilePath SlnFile 
    { 
        get { return this._SlnFile; } 
        private set 
        {
            this._SlnFile = value;
            this.SlnUpdated();
        }
    }

    public SolutionParserResult SlnResults { get; private set; }
    public List<> SlnResults { get; private set; }

    private void SlnUpdated()
    {

    }
}