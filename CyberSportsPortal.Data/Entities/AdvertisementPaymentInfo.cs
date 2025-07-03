using System;

namespace CyberSportsPortal.Data.Entities
{
    public class AdvertisementPaymentInfo
    {
        public int Id { get; set; }
        public decimal PaymentSum { get; set; }
        public DateTime PaymentDate { get; set; }
        public int AdvertisingCompanyId { get; set; }
        public virtual AdvertisingCompany AdvertisingCompany { get; set; }
    }
}
