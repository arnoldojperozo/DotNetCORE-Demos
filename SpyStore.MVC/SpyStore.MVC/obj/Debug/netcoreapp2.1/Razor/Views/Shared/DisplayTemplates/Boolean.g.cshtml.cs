#pragma checksum "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\Boolean.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79b32bbfd6cbf4a5d3b77df212e163cf0c31208d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_Boolean), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/Boolean.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/Boolean.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_Boolean))]
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
using SpyStore.MVC.Models;

#line default
#line hidden
#line 3 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.WebServiceAccess;

#line default
#line hidden
#line 4 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.WebServiceAccess.Base;

#line default
#line hidden
#line 5 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.MVC.ViewModels;

#line default
#line hidden
#line 6 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.Entities;

#line default
#line hidden
#line 7 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.ViewModels;

#line default
#line hidden
#line 8 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\_ViewImports.cshtml"
using SpyStore.Models.ViewModels.Base;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b32bbfd6cbf4a5d3b77df212e163cf0c31208d", @"/Views/Shared/DisplayTemplates/Boolean.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da968de719725de9c38f29f5e39a3f0fef50802", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_Boolean : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\Boolean.cshtml"
  
    if (!Model.HasValue)
    {

#line default
#line hidden
            BeginContext(47, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(57, 8, true);
            WriteLiteral("Unknown\n");
            EndContext();
#line 6 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\Boolean.cshtml"
    }
    else if (Model.Value)
    {

#line default
#line hidden
            BeginContext(103, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(113, 4, true);
            WriteLiteral("Yes\n");
            EndContext();
#line 10 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\Boolean.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(138, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(148, 3, true);
            WriteLiteral("No\n");
            EndContext();
#line 14 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\Boolean.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool?> Html { get; private set; }
    }
}
#pragma warning restore 1591
