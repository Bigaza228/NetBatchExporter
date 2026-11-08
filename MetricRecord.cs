namespace NetBatchExporter.MetricRecord;

public record MetricRecord
(
    DateTime LogTime,
    string LogLevel,
    string LogName,
    string? Description,
    double? DurationInMs
);
