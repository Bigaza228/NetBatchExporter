namespace NetBatchExporter;


//a class with a method that returns random metric records, for testing purposes
public static class MetricsGeneration
{
    private static readonly string[] LogLevels = {"INFO", "WARNING", "ERROR", "CRITICAL"};
    private static readonly string[] LogNames = {"loginAccount", "logoutAccount", "connectionerror", "DbConnection", "applicationOperation1"};
    
    public static List<MetricRecord> GetMetricsData()
    {
        List<MetricRecord> metricRecords = new List<MetricRecord>();
        Random random = new Random();
        int temp;
        for(int c = 0; c < 20; c++)
        {
            MetricRecord metricRecord = new MetricRecord();
            metricRecord.LogLevel = LogLevels[random.Next(LogLevels.Length)];
            metricRecord.LogName = LogNames[random.Next(LogNames.Length)];
            metricRecord.DurationInMs = null;
            temp = random.Next(2);
            if(temp == 1)
                metricRecord.DurationInMs = random.Next(50);
            metricRecords.Add(metricRecord);
        }
        return metricRecords;
    }

}
