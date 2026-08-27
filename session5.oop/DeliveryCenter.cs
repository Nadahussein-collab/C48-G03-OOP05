using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5.oop
{
    public class DeliveryCenter
    {
        private Shipment?[] _shipments;
        private string _centerName;

        public Driver? Driver { get; set; }

        public DeliveryCenter(string centerName)
        {
            _centerName = centerName;
            _shipments = new Shipment?[20];
        }

        public string CenterName
        {
            get { return _centerName; }
            set { _centerName = value; }
        }

        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < _shipments.Length)
                    return _shipments[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < _shipments.Length)
                    _shipments[index] = value;
            }
        }

        public Shipment? this[string trackingCode]
        {
            get
            {
                foreach (var shipment in _shipments)
                {
                    if (shipment != null && shipment.TrackingCode == trackingCode)
                        return shipment;
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null && _shipments[i]!.TrackingCode == trackingCode)
                {
                    _shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Delivery Center : " + CenterName);
            if (Driver != null)
            {
                Console.WriteLine("Assigned Driver : " + Driver.FullName);
            }
            Console.WriteLine("====================================\n");

            foreach (var shipment in _shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine("------------------------------------");
                }
            }
        }
        public void PrintTrackingStatuses()
        {
            foreach (var shipment in _shipments)
            {
                if (shipment is ITrackable trackable)
                {
                    Console.WriteLine(trackable.GetTrackingStatus());
                }
            }
        }
    }
}
