#pragma checksum "C:\Users\Admin\Desktop\ASP.NET\Lesson_ASP.NET\Lessons\Lessons\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73bbb81befebcf859abb23b833c55c89d9735d03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\ASP.NET\Lesson_ASP.NET\Lessons\Lessons\Views\_ViewImports.cshtml"
using Lessons.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\ASP.NET\Lesson_ASP.NET\Lessons\Lessons\Views\_ViewImports.cshtml"
using Lessons.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73bbb81befebcf859abb23b833c55c89d9735d03", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a24821e7ddd9e4e4070bfc554de9dcf3bae1052", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "C:\Users\Admin\Desktop\ASP.NET\Lesson_ASP.NET\Lessons\Lessons\Views\ShopCart\Index.cshtml"
     foreach (var item in Model.shopCart.listShopItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\r\n            <b>Автомобиль: </b> ");
#nullable restore
#line 7 "C:\Users\Admin\Desktop\ASP.NET\Lesson_ASP.NET\Lessons\Lessons\Views\ShopCart\Index.cshtml"
                           Write(item.car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n            <b>Цена: </b> ");
#nullable restore
#line 8 "C:\Users\Admin\Desktop\ASP.NET\Lesson_ASP.NET\Lessons\Lessons\Views\ShopCart\Index.cshtml"
                     Write(item.car.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 10 "C:\Users\Admin\Desktop\ASP.NET\Lesson_ASP.NET\Lessons\Lessons\Views\ShopCart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr/>\r\n    <div class=\"btn btn-danger\" asp-controller=\"Order\">Оплатить</div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591