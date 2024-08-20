using Piranha.Extend.Fields;
using Piranha.Extend;

namespace raylight_cms.Models.FieldTypes
{
    public class Footer
    {
        [Field(Title = "Footer logo")]
        public ImageField Logo { get; set; }
        [Field(Title = "Footer text")]
        public HtmlField Text { get; set; }
    }
}
