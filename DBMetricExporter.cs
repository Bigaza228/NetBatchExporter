using System;

namespace NetBatchExporter;


//class for sending data to a database
public class DBMetricExporter : IExporter
{
    //
    private readonly string serverAddress;
    public DBMetricExporter(string serverAddress)
    {
        this.serverAddress = serverAddress;
    }

//The data-sending method will be implemented later.
    public void ExportData(List<MetricRecord> metrics)
    {
        throw new NotImplementedException();
    }
}
