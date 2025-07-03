using System.Collections.Generic;

namespace CyberSportsPortal.Data.Entities
{
    public class AdvertisingCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AdvertisementLink { get; set; }
        public virtual ICollection<AdvertisementPaymentInfo> AdvertisementPaymentInfos { get; set; }
    }
}
