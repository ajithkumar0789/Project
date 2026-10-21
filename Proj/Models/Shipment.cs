
using System;

namespace Proj_.Models
{
    public class ShipmentStatus
    {
        public int ShipmentId { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Location { get; set; }
        public string? Notes { get; set; }

        public ShipmentStatus(
            int shipmentId,
            string status,
            string location,
            string? notes = null)
        {
            ShipmentId = shipmentId;
            Status = status;
            UpdatedAt = DateTime.Now;
            Location = location;
            Notes = notes;
        }
    }
}
