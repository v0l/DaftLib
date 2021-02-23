using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json.Serialization;

namespace DaftLib
{
    public class Range
    {
        [JsonPropertyName("from")]
        public string From { get; set; } = "";

        [JsonPropertyName("to")]
        public string To { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Filter
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("values")]
        public List<string> Values { get; set; }
    }

    public class GeoFilter
    {
        [JsonPropertyName("storedShapeIds")]
        public List<string> StoredShapeIds { get; set; }

        [JsonPropertyName("geoSearchType")]
        public string GeoSearchType { get; set; }
    }

    public class SearchRequest
    {
        [JsonPropertyName("section")]
        public string Section { get; set; } = "residential-for-sale";

        [JsonPropertyName("filters")]
        public List<Filter> Filters { get; set; } = new List<Filter>();

        [JsonPropertyName("andFilters")]
        public List<Filter> AndFilters { get; set; } = new List<Filter>();

        [JsonPropertyName("ranges")]
        public List<Range> Ranges { get; set; } = new List<Range>();

        [JsonPropertyName("paging")]
        public Paging Paging { get; set; } = new Paging() { From = 0, PageSize = 20 };

        [JsonPropertyName("geoFilter")]
        public GeoFilter GeoFilter { get; set; }

        [JsonPropertyName("sort")]
        public string Sort { get; set; }

        [JsonPropertyName("terms")]
        public string Terms { get; set; }
    }
}
