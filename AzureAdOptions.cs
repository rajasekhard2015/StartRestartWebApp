using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartRestartWebApp
{
    public class AzureAdOptions
    {
        public bool IsEnabled { get; set; }
        public string Instance { get; set; }
        public string TenantId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Domain { get; set; }
        public string CallbackPath { get; set; }
        public string GraphResource { get; set; }
        public string GraphResourceEndPoint { get; set; }
    }
}
