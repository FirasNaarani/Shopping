#pragma checksum "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc41b27ab289c7edd8f5f72340405cc271114a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Allpurchases_Index), @"mvc.1.0.view", @"/Views/Allpurchases/Index.cshtml")]
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
#line 1 "E:\Shopping\AddProducts-MongoDb\Views\_ViewImports.cshtml"
using AddProducts_MongoDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Shopping\AddProducts-MongoDb\Views\_ViewImports.cshtml"
using AddProducts_MongoDb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc41b27ab289c7edd8f5f72340405cc271114a6", @"/Views/Allpurchases/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14df3dd1ed71025af1d2640c4c5d7ba161536583", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Allpurchases_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AddProducts_MongoDb.Models.MyPurchases>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List Of All Purchases</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VisaNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClientAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VisaNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 56 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 59 "E:\Shopping\AddProducts-MongoDb\Views\Allpurchases\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AddProducts_MongoDb.Models.MyPurchases>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
