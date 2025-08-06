namespace BatchProgramRunner
{
    public class BatchProcessResult
    {
        public string buildCommandString { get; internal set; }
        public int exitCode { get; internal set; }
        public string stdOut { get; internal set; }
    }
}