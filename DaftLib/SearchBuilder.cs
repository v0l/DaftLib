using System.Collections.Generic;
using System.Linq;

namespace DaftLib
{
    public enum BERRating
    {
        A1,
        A2,
        A3,
        B1,
        B2,
        B3,
        C1,
        C2,
        C3,
        D1,
        D2,
        E1,
        E2,
        F,
        G,
        Exempt
    }

    public enum SearchLastRange
    {
        Last1Day,
        Last3Day,
        Last7Day,
        Last14Day,
        Last30Day
    }

    public enum AdState
    {
        Available,
        SaleAgreed
    }

    public enum PropertyType
    {
        House,
        DetachedHouse,
        SemiDetachedHouse,
        TerracedHouse,
        EndOfTerraceHouse,
        TownHouse,
        Apartment,
        StudioApartment,
        Duplex,
        Bungalow,
        Site
    }

    public enum Facilities
    {
        Alarm,
        GasFiredCentralHeating,
        OilFiredCentralHeating,
        Parking,
        WheelchairAccess,
        WiredForCableTV
    }

    public enum MediaType
    {
        Video,
        VirtualTour
    }

    public enum Sorting
    {
        BestMatch,
        MostRecent,
        PriceAsc,
        PriceDesc
    }

    public class SearchBuilder
    {
        private SearchRequest Search { get; } = new SearchRequest();

        public SearchRequest Build() => Search;

        public SearchBuilder WithSection(string section)
        {
            Search.Section = section;
            return this;
        }

        public SearchBuilder WithPrice(int? from = null, int? to = null)
        {
            Search.Ranges.Add(new Range()
            {
                Name = "salePrice",
                From = from?.ToString() ?? "",
                To = to?.ToString() ?? ""
            });
            return this;
        }

        public SearchBuilder WithBeds(int? from = null, int? to = null)
        {
            Search.Ranges.Add(new Range()
            {
                Name = "numBeds",
                From = from?.ToString() ?? "",
                To = to?.ToString() ?? ""
            });
            return this;
        }

        public SearchBuilder WithBaths(int? from = null, int? to = null)
        {
            Search.Ranges.Add(new Range()
            {
                Name = "numBaths",
                From = from?.ToString() ?? "",
                To = to?.ToString() ?? ""
            });
            return this;
        }

        public SearchBuilder WithSize(int? from = null, int? to = null)
        {
            Search.Ranges.Add(new Range()
            {
                Name = "floorSize",
                From = from?.ToString() ?? "",
                To = to?.ToString() ?? ""
            });
            return this;
        }

        public SearchBuilder WithBER(BERRating? from = null, BERRating? to = null)
        {
            Search.Ranges.Add(new Range()
            {
                Name = "ber",
                From = ((int?)from)?.ToString() ?? "",
                To = ((int?)to)?.ToString() ?? ""
            });
            return this;
        }

        public SearchBuilder WithListedDate(SearchLastRange searchLast)
        {
            Search.Ranges.Add(new Range()
            {
                Name = "firstPublishDate",
                From = SearchListToString(searchLast),
            });
            return this;
        }

        public SearchBuilder WithPropertyType(IEnumerable<PropertyType> types)
        {
            Search.Filters.Add(new Filter()
            {
                Name = "propertyType",
                Values = types.Select(a => PropertyTypeToString(a)).ToList()
            });
            return this;
        }

        public SearchBuilder WithAdState(IEnumerable<AdState> states)
        {
            Search.Filters.Add(new Filter()
            {
                Name = "adState",
                Values = states.Select(a => AdStateToString(a)).ToList()
            });
            return this;
        }

        public SearchBuilder WithFacilies(IEnumerable<Facilities> facilities)
        {
            Search.AndFilters.Add(new Filter()
            {
                Name = "facilities",
                Values = facilities.Select(a => FacilitiesToString(a)).ToList()
            });
            return this;
        }

        public SearchBuilder WithMedia(IEnumerable<MediaType> types)
        {
            Search.Filters.Add(new Filter()
            {
                Name = "mediaTypes",
                Values = types.Select(a => MediaTypeToString(a)).ToList()
            });
            return this;
        }

        public SearchBuilder WithKeyword(string keyword)
        {
            Search.Terms = keyword;
            return this;
        }

        public SearchBuilder WithSorting(Sorting sort)
        {
            Search.Sort = SortingToString(sort);
            return this;
        }

        private string SearchListToString(SearchLastRange r)
        {
            switch (r)
            {
                case SearchLastRange.Last1Day:
                    return "now-1d/d";
                case SearchLastRange.Last3Day:
                    return "now-3d/d";
                case SearchLastRange.Last7Day:
                    return "now-7d/d";
                case SearchLastRange.Last14Day:
                    return "now-14d/d";
                case SearchLastRange.Last30Day:
                    return "now-30d/d";
            }
            return string.Empty;
        }

        private string AdStateToString(AdState s)
        {
            switch (s)
            {
                case AdState.Available:
                    return "published";
                case AdState.SaleAgreed:
                    return "sale-agreed";
            }
            return string.Empty;
        }

        private string PropertyTypeToString(PropertyType p)
        {
            switch (p)
            {
                case PropertyType.House:
                    return "houses";
                case PropertyType.DetachedHouse:
                    return "detached-houses";
                case PropertyType.SemiDetachedHouse:
                    return "semi-detached-houses";
                case PropertyType.TerracedHouse:
                    return "terraced-houses";
                case PropertyType.EndOfTerraceHouse:
                    return "end-of-terrace-houses";
                case PropertyType.TownHouse:
                    return "townhouses";
                case PropertyType.Apartment:
                    return "appartments";
                case PropertyType.StudioApartment:
                    return "studio-apparment";
                case PropertyType.Duplex:
                    return "duplexes";
                case PropertyType.Bungalow:
                    return "bungalows";
                case PropertyType.Site:
                    return "sites";
            }
            return string.Empty;
        }

        private string FacilitiesToString(Facilities f)
        {
            switch (f)
            {
                case Facilities.Alarm:
                    return "alarm";
                case Facilities.GasFiredCentralHeating:
                    return "gas-fired-central-heating";
                case Facilities.OilFiredCentralHeating:
                    return "oil-fired-central-heating";
                case Facilities.Parking:
                    return "parking";
                case Facilities.WheelchairAccess:
                    return "wheelchair-access";
                case Facilities.WiredForCableTV:
                    return "wired-for-cable-television";
            }
            return string.Empty;
        }

        private string MediaTypeToString(MediaType t)
        {
            switch (t)
            {
                case MediaType.Video:
                    return "video";
                case MediaType.VirtualTour:
                    return "virtual-tour";
            }
            return string.Empty;
        }

        private string SortingToString(Sorting s)
        {
            switch (s)
            {
                case Sorting.BestMatch:
                    return "bestMatch";
                case Sorting.MostRecent:
                    return "publishDateDesc";
                case Sorting.PriceAsc:
                    return "priceAsc";
                case Sorting.PriceDesc:
                    return "priceDesc";
            }
            return string.Empty;
        }
    }
}
