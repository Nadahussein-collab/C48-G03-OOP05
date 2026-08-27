using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5.oop
{
    public abstract partial class Shipment
    {
        private string _trackingStatus = "In Transit";

        public string TrackingStatus
        {
            get { return _trackingStatus; }
            protected set { _trackingStatus = value; }
        }

        public string GetTrackingStatus()
        {
            return _trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            _trackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }
        partial void OnTrackingStatusChanged(string newStatus);
    }
    public abstract partial class Shipment
    {
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
}
