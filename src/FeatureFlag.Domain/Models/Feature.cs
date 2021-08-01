using System.Collections.Generic;

namespace FeatureFlag.Domain.Models
{
    public class Feature
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string ServiceName { get; set; }

        public bool Toggle { get; set; }

        public IList<Dictionary<string,string[]>> Rules { get; set; }
    }
}