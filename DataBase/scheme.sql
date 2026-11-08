--use [DbName]
go

CREATE TABLE MetricLogs (
    MetricLogsId INT IDENTITY(1,1) PRIMARY KEY,   -- Первичный ключ с автоинкрементом
    MetricLogsCreatedAt DATETIME2 NOT NULL,       -- Время события (замена зарезервированного DateTime)
    MetricLogsLogLevel VARCHAR(20) NOT NULL,      -- Уровень (INFO, WARN, ERROR и т.д.)
    MetricLogsLogName VARCHAR(100) NOT NULL,      -- Краткое название метрики/действия
    MetricLogsDescription VARCHAR(300) NULL,      -- Описание (может быть NULL)
    MetricLogsDurationInMs FLOAT NULL             -- Длительность в миллисекундах (FLOAT, т.к. может быть с дробной частью)
);
GO