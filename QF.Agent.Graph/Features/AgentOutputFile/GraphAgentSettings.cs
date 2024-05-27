using System.ComponentModel.DataAnnotations;
using MetalHeaven.Integration.Shared.Classes;

namespace Rhodium24.Host.Features.AgentOutputFile
{
    public class GraphAgentSettings : AgentSettings
    {
        public string WatchDirectory { get; set; }
        public string WatchFilter { get; set; }

        [Required]
        public string TenantId { get; set; }

        [Required]
        public string ClientId { get; set; }

        [Required]
        public string ClientSecret { get; set; }

        public string DriveId { get; set; }

        public string TargetDirectory { get; set; }
    }
}
