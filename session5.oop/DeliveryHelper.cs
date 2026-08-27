using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5.oop
{
    public static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)

        {
            if (shipment != null)

            {
                shipment.PrintShipment();
            }
        }
    }
}
