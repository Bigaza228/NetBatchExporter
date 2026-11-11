using System;
using System.IO;

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

    private void SendInBd(List<MetricRecord> metrics)
    {
        
    }

    private void SaveInFile(List<MetricRecord> metrics)
    {
        var backUpFiles = metrics.Select(p => $"{p.LogTime};{p.LogLevel};{p.LogName};{p.Description};{p.DurationInMs}");
        File.WriteAllLines(".\\BackUp\\reserve.txt", backUpFiles);
    }

    public void ExportData(List<MetricRecord> metrics)
    {
        try
        {
            SendInBd(metrics);
        } catch(Exception DbEx)
        {
            Console.WriteLine($"Не получилось отправить логи в бд: {DbEx.Message}");
            try
            {
                SaveInFile(metrics);
            } catch(Exception FileEx)
            {
                Console.WriteLine($"Не получилось отправить логи в бд: {FileEx.Message}");
                Console.WriteLine("Потеря данных");
            }
        }
    }
}
