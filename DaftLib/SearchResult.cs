using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DaftLib
{
    public class Seller
    {
        [JsonPropertyName("sellerId")]
        public int SellerId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        [JsonPropertyName("standardLogo")]
        public string StandardLogo { get; set; }

        [JsonPropertyName("squareLogo")]
        public string SquareLogo { get; set; }

        [JsonPropertyName("backgroundColour")]
        public string BackgroundColour { get; set; }

        [JsonPropertyName("licenceNumber")]
        public string LicenceNumber { get; set; }

        [JsonPropertyName("sellerType")]
        public string SellerType { get; set; }

        [JsonPropertyName("showContactForm")]
        public bool ShowContactForm { get; set; }

        [JsonPropertyName("phoneWhenToCall")]
        public string PhoneWhenToCall { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("alternativePhone")]
        public string AlternativePhone { get; set; }

        [JsonPropertyName("profileImage")]
        public string ProfileImage { get; set; }
    }

    public class Image
    {

        [JsonPropertyName("size1440x960")]
        public string Size1440x960 { get; set; }

        [JsonPropertyName("size1200x1200")]
        public string Size1200x1200 { get; set; }

        [JsonPropertyName("size720x480")]
        public string Size720x480 { get; set; }

        [JsonPropertyName("size600x600")]
        public string Size600x600 { get; set; }

        [JsonPropertyName("size400x300")]
        public string Size400x300 { get; set; }

        [JsonPropertyName("size360x240")]
        public string Size360x240 { get; set; }

        [JsonPropertyName("size300x200")]
        public string Size300x200 { get; set; }

        [JsonPropertyName("size320x280")]
        public string Size320x280 { get; set; }

        [JsonPropertyName("size72x52")]
        public string Size72x52 { get; set; }

        [JsonPropertyName("size680x392")]
        public string Size680x392 { get; set; }

        [JsonPropertyName("caption")]
        public string Caption { get; set; }
    }

    public class Brochure
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Media
    {
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        [JsonPropertyName("totalImages")]
        public int TotalImages { get; set; }

        [JsonPropertyName("hasVideo")]
        public bool HasVideo { get; set; }

        [JsonPropertyName("hasVirtualTour")]
        public bool HasVirtualTour { get; set; }

        [JsonPropertyName("hasBrochure")]
        public bool HasBrochure { get; set; }

        [JsonPropertyName("brochure")]
        public List<Brochure> Brochure { get; set; }
    }

    public class Ber
    {
        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("epi")]
        public string Epi { get; set; }
    }

    public class Point
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        public List<double> Coordinates { get; set; }
    }

    public class SubUnit
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("numBedrooms")]
        public string NumBedrooms { get; set; }

        [JsonPropertyName("numBathrooms")]
        public string NumBathrooms { get; set; }

        [JsonPropertyName("propertyType")]
        public string PropertyType { get; set; }

        [JsonPropertyName("daftShortcode")]
        public string DaftShortcode { get; set; }

        [JsonPropertyName("seoFriendlyPath")]
        public string SeoFriendlyPath { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }

        [JsonPropertyName("media")]
        public Media Media { get; set; }

        [JsonPropertyName("ber")]
        public Ber Ber { get; set; }
    }

    public class NewHome
    {
        [JsonPropertyName("totalUnitTypes")]
        public int TotalUnitTypes { get; set; }

        [JsonPropertyName("subUnits")]
        public List<SubUnit> SubUnits { get; set; }

        [JsonPropertyName("tagLine")]
        public string TagLine { get; set; }

        [JsonPropertyName("developmentName")]
        public string DevelopmentName { get; set; }

        [JsonPropertyName("sitePlan")]
        public string SitePlan { get; set; }

        [JsonPropertyName("brochure")]
        public string Brochure { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("about")]
        public string About { get; set; }
    }

    public class PageBranding
    {
        [JsonPropertyName("standardLogo")]
        public string StandardLogo { get; set; }

        [JsonPropertyName("squareLogo")]
        public string SquareLogo { get; set; }

        [JsonPropertyName("backgroundColour")]
        public string BackgroundColour { get; set; }

        [JsonPropertyName("squareLogos")]
        public List<string> SquareLogos { get; set; }

        [JsonPropertyName("rectangleLogo")]
        public string RectangleLogo { get; set; }
    }

    public class FloorArea
    {
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Property
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonPropertyName("sections")]
        public List<string> Sections { get; set; }

        [JsonPropertyName("saleType")]
        public List<string> SaleType { get; set; }

        [JsonPropertyName("featuredLevel")]
        public string FeaturedLevel { get; set; }

        [JsonPropertyName("publishDate")]
        public object PublishDate { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("abbreviatedPrice")]
        public string AbbreviatedPrice { get; set; }

        [JsonPropertyName("numBedrooms")]
        public string NumBedrooms { get; set; }

        [JsonPropertyName("propertyType")]
        public string PropertyType { get; set; }

        [JsonPropertyName("daftShortcode")]
        public string DaftShortcode { get; set; }

        [JsonPropertyName("seller")]
        public Seller Seller { get; set; }

        [JsonPropertyName("media")]
        public Media Media { get; set; }

        [JsonPropertyName("ber")]
        public Ber Ber { get; set; }

        [JsonPropertyName("point")]
        public Point Point { get; set; }

        [JsonPropertyName("seoFriendlyPath")]
        public string SeoFriendlyPath { get; set; }

        [JsonPropertyName("newHome")]
        public NewHome NewHome { get; set; }

        [JsonPropertyName("pageBranding")]
        public PageBranding PageBranding { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("sticker")]
        public string Sticker { get; set; }

        [JsonPropertyName("numBathrooms")]
        public string NumBathrooms { get; set; }

        [JsonPropertyName("floorArea")]
        public FloorArea FloorArea { get; set; }
    }

    public class Listing
    {
        [JsonPropertyName("listing")]
        public Property Property { get; set; }

        [JsonPropertyName("savedAd")]
        public bool SavedAd { get; set; }
    }

    public class Paging
    {
        [JsonPropertyName("from")]
        public int? From { get; set; }

        [JsonPropertyName("totalPages")]
        public int? TotalPages { get; set; }

        [JsonPropertyName("currentPage")]
        public int? CurrentPage { get; set; }

        [JsonPropertyName("nextFrom")]
        public int? NextFrom { get; set; }

        [JsonPropertyName("previousFrom")]
        public int? PreviousFrom { get; set; }

        [JsonPropertyName("displayingFrom")]
        public int? DisplayingFrom { get; set; }

        [JsonPropertyName("displayingTo")]
        public int? DisplayingTo { get; set; }

        [JsonPropertyName("totalResults")]
        public int? TotalResults { get; set; }

        [JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }
    }

    public class DfpTargetingValues
    {
        [JsonPropertyName("pageType")]
        public List<string> PageType { get; set; }

        [JsonPropertyName("searchPageNo")]
        public List<string> SearchPageNo { get; set; }

        [JsonPropertyName("areaName")]
        public List<string> AreaName { get; set; }

        [JsonPropertyName("adState")]
        public List<string> AdState { get; set; }

        [JsonPropertyName("distilledBrand")]
        public List<string> DistilledBrand { get; set; }

        [JsonPropertyName("section")]
        public List<string> Section { get; set; }

        [JsonPropertyName("countyName")]
        public List<string> CountyName { get; set; }

        [JsonPropertyName("user_id")]
        public List<string> UserId { get; set; }
    }

    public class Breadcrumb
    {
        [JsonPropertyName("displayValue")]
        public string DisplayValue { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class SearchResults
    {
        [JsonPropertyName("listings")]
        public List<Listing> Listings { get; set; }

        [JsonPropertyName("showcaseListings")]
        public List<object> ShowcaseListings { get; set; }

        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }

        [JsonPropertyName("dfpTargetingValues")]
        public DfpTargetingValues DfpTargetingValues { get; set; }

        [JsonPropertyName("breadcrumbs")]
        public List<Breadcrumb> Breadcrumbs { get; set; }

        [JsonPropertyName("canonicalUrl")]
        public string CanonicalUrl { get; set; }

        [JsonPropertyName("mapView")]
        public bool MapView { get; set; }

        [JsonPropertyName("savedSearch")]
        public bool SavedSearch { get; set; }
    }


}
