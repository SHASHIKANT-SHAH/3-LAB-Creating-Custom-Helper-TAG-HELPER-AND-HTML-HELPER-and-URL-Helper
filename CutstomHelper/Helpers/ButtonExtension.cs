using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CutstomHelper.Helpers
{
    public static class ButtonExtension
    {
        public static IHtmlContent SubmitButton(this IHtmlHelper htmlHelper, string Command, string Value)
        {
            string str = $" <input type=\"submit\" name=\"{Command}\" value=\"{Value}\" class=\"btn btn-primary\" />";
            return new HtmlString(str);
        }
    }
}
