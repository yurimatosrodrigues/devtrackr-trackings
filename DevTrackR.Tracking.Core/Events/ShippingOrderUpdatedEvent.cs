namespace DevTrackR.Tracking.Core.Events
{
    public class ShippingOrderUpdatedEvent
    {
        public ShippingOrderUpdatedEvent(string trackingCode, string contactEmail, string description)
        {
            TrackingCode = trackingCode;
            ContactEmail = contactEmail;
            Description = description;
        }

        public string TrackingCode { get; set; }
        public string ContactEmail { get; set; }
        public string Description { get; set; }
    }
}
