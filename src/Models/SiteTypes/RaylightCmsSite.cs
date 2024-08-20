using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using raylight_cms.Models.FieldTypes;

namespace raylight_cms.Models.SiteTypes
{
    [SiteType(Title = "Raylight CMS Site")]
    public class RaylightCmsSite : SiteContent<RaylightCmsSite>
    {
        [Region(Title = "Footer", Display = RegionDisplayMode.Setting)]
        public Footer FooterContents { get; set; }
    }
}