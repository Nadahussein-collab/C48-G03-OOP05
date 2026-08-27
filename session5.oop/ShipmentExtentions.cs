using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5.oop
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            if (shipment == null) return string.Empty;
            string shipmentType = shipment.GetType().Name.Replace("Shipment", "");
            if (string.IsNullOrEmpty(shipmentType)) shipmentType = "Standard";

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment == null) return false;
            return shipment.TrackingStatus.Equals("Delivered", StringComparison.OrdinalIgnoreCase);
        }
    }
}
