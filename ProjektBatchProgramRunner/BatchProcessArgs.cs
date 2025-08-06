namespace BatchProgramRunner
{
    public class BatchProcessArgs
    {
        public string cmd { get; internal set; }
        public string args { get; internal set; }
        public System.Data.DataTable tbl { get; internal set; }
        public bool wait { get; internal set; }
    }
}