using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Http;
using System.Text;
using CaseStudy.Models;
using Newtonsoft.Json;
using CaseStudy.Utils;

namespace CaseStudy.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("catalogue", Attributes = BrandIdAttribute)]
    public class BrandHelper : TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public BrandHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        private const string BrandIdAttribute = "brand";
        [HtmlAttributeName(BrandIdAttribute)]
        public string BrandId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (_session.Get<MenuProductViewModel[]>("menu") != null && Convert.ToInt32(BrandId) > 0)
            {
                var innerHtml = new StringBuilder();
                MenuProductViewModel[] menu = _session.Get<MenuProductViewModel[]>("menu");
                innerHtml.Append("<h5>Available Laptops</h5>");
                innerHtml.Append("<div class=\"row w-100 m-1\" style=\"overflow-y:scroll;height:60vh;\">"); 
                foreach (MenuProductViewModel item in menu)
                {
                    if (item.BrandId == Convert.ToInt32(BrandId))
                    {
                        // remove apostrophe from JSON
                        item.Description = item.Description.Contains("'") ? item.Description.Replace("'", "") : item.Description;
                        var itemJson = JsonConvert.SerializeObject(item);
                        var btn = "catbtn" + item.Id;
                        string temp = item.GRA;
                        innerHtml.Append("<div class=\"col-sm-3 col-xs-12 text-center\" style =\"border:solid;\">");
                        innerHtml.Append("<img src =\"/images/" + temp + "\" style=\"height: 140px; width: 200px;\" class=\"mt-2\"/><br />");
                        if (item.Description.Length > 25)
                        {
                            innerHtml.Append("<span class=\"m-0\" style=\"font-size:large;font-weight:bold;\">" +
                            item.Description.Substring(0, 25) + "...</span>");
                        }
                        else
                        {
                            innerHtml.Append("<span class=\"m-0\" style=\"font-size:large;font-weight:bold;\">" +
                            item.Description + "...</span>");
                        }
                        innerHtml.Append("<p><span style=\"font-size:medium\">Laptop info. in details</span >");
                        innerHtml.Append("<p><a id=\"" + btn + "\" href=\"#details_popup\" data-toggle=\"modal\"");
                        innerHtml.Append(" class=\"btn btn-outline-dark pt-2 pb-2\" data-id=" + item.Id);
                        innerHtml.Append(" data-details='" + itemJson + "'>Details</a></div>");
                    }
                }
                output.Content.SetHtmlContent(innerHtml.ToString());
            }
        }
    }
}
