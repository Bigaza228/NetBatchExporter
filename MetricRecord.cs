namespace NetBatchExporter;

public record MetricRecord
{
    public DateTime LogTime;
    public string LogLevel;
    public string LogName;
    public string? Description;
    public double? DurationInMs;
}
