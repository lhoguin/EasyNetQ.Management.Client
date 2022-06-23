using System;
using EasyNetQ.Management.Client.Serialization;
using Newtonsoft.Json;

namespace EasyNetQ.Management.Client.Model
{
    public class LengthsSample
    {
        public long Sample { get; set; }

        [JsonConverter(typeof(UnixMsDateTimeConverter))]
        public DateTime Timestamp { get; set; }
    }
}
