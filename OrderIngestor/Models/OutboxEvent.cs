using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderIngestor.Models
{
    public class OutboxEvent
    {
        public int Id { get; set; }
        public string EventType { get; set; } = string.Empty;
        public string Payload { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool Published { get; set; } = false;
        public DateTime? PublishedAt { get; set; }
    }
}
