namespace AspNetCore.Consul
{
    public class ConsulConfig
    {
        public string ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string[] Tags { get; set; }
    }
}