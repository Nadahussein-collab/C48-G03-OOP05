using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5.oop
{
    public abstract partial class Shipment
    {
        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;
        public static int TotalShipmentsCreated = 0;
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress("Cairo", "Main St", 1))
        {
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN";
            _description = !string.IsNullOrWhiteSpace(description) ? description : "Unknown";
            _weight = weight > 0 ? weight : 1;
            _deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
            _destination = destination;
            TotalShipmentsCreated++;
        }

        public string TrackingCode
        {
            get { return _trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _trackingCode = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _description = value;
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                    _deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                _weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
                _weight = newWeight + extraPackingWeight;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                _deliveryFee = newFee;
        }
        public Shipment CopyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public abstract Shipment DeepCopy();
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
    }
}
