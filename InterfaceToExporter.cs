using System;

namespace NetBatchExporter;

//interface to different exporters in which the data export method will be called
public interface IExporter
{
    void ExportData(List<MetricRecord> metrics);
}
