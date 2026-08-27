using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5.oop
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string _destinationCountry;
        private decimal _customsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            _destinationCountry = !string.IsNullOrWhiteSpace(destinationCountry) ? destinationCountry : "Unknown";
            _customsFee = customsFee >= 0 ? customsFee : 0;
        }

        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return _customsFee; }
            set
            {
                if (value >= 0)
                    _customsFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + _customsFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            Console.WriteLine("Tracking Code       : " + TrackingCode);
            Console.WriteLine("Destination Country : " + DestinationCountry);
            Console.WriteLine("Estimated Cost      : " + EstimatedCost + " EGP");
        }

        public new string GetTrackingStatus()
        {
            return "Shipment " + TrackingCode + " has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        public override Shipment DeepCopy()
        {
            DeliveryAddress newAddress = new DeliveryAddress(Destination.City, Destination.Street, Destination.BuildingNumber);
            InternationalShipment copy = new InternationalShipment(TrackingCode, Description, Weight, DeliveryFee, newAddress, DestinationCountry, CustomsFee);
            copy.TrackingStatus = this.TrackingStatus;
            return copy;
        }
    }
}
