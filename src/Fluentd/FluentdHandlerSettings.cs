namespace Serilog.Sinks.Fluentd.Core.Fluentd
{
    public class FluentdHandlerSettings
    {
        public string Tag { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public int Timeout { get; set; }
    }
}