#pragma checksum "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\EditorTemplates\Boolean.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13ae5f4e198e27ca2fee450e48c38a5e02ce8ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Boolean), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Boolean.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/Boolean.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_Boolean))]
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
#line 1 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC;

#line default
#line hidden
#line 2 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.WebServiceAccess;

#line default
#line hidden
#line 3 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.WebServiceAccess.Base;

#line default
#line hidden
#line 4 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.Entities;

#line default
#line hidden
#line 6 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.ViewModels.Base;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ae5f4e198e27ca2fee450e48c38a5e02ce8ab0", @"/Views/Shared/EditorTemplates/Boolean.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec03bcea3de07d9112f2933877ce90791a284377", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Boolean : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boolean?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\EditorTemplates\Boolean.cshtml"
  
    var value = false;
    var selectionMade = false;
    var list = new List<SelectListItem>();
    if (ViewData.ModelMetadata.IsNullableValueType)
    {
        list.Add(new SelectListItem
        {
            Text = "",
            Value = "",
        });
        if (!Model.HasValue)
        {
            list[0].Selected = true;
            selectionMade = true;
        }
        else
        {
            value = Model.Value;
        }
    }
    else
    {
        value = (bool)Model;
    }
    list.Add(new SelectListItem
    {
        Text = "Yes",
        Value = "true",
        Selected = (!selectionMade && value == true)
    });
    list.Add(new SelectListItem
    {
        Text = "No",
        Value = "false",
        Selected = (!selectionMade && value == false)
    });

#line default
#line hidden
            BeginContext(815, 65, false);
#line 40 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\EditorTemplates\Boolean.cshtml"
Write(Html.DropDownList(string.Empty, list, ViewData["htmlAttributes"]));

#line default
#line hidden
            EndContext();
            BeginContext(880, 2, true);
            WriteLiteral("\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boolean?> Html { get; private set; }
    }
}
#pragma warning restore 1591
