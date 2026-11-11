using System;

namespace NetBatchExporter;

//a buffer for storing data and subsequently sending it
public class MetricBuffer : IDisposable
{
    private readonly IExporter dBMetricExporter;
    private List<MetricRecord> metricRecords = new();
    public MetricBuffer(DBMetricExporter dBMetricExporter)
    {
        this.dBMetricExporter = dBMetricExporter;
    }

    public void AddMetric(MetricRecord metric) => metricRecords.Add(metric);
    
    public void Dispose()
    {
        try
        {
            if(metricRecords.Count > 0)
                dBMetricExporter.ExportData(metricRecords);
                
        } catch(Exception ex)
        {
            Console.WriteLine($"Ошибка не получилось отправить данные{ex.Message}");
        }
    }
}
