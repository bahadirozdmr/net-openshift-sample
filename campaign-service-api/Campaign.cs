using System;

namespace campaign_service_api
{
    public class Campaign
    {
        public long Id { get; set; }
        
        public string Name { get; set; }
        
        public DateTime CreateDate { get; set; }
    }
}