#pragma checksum "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\DateTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a82fb1f1c65e88e7e54a72939b592e03ec6ac0cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_DateTime), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/DateTime.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/DateTime.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_DateTime))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 1 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\DateTime.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82fb1f1c65e88e7e54a72939b592e03ec6ac0cb", @"/Views/Shared/DisplayTemplates/DateTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec03bcea3de07d9112f2933877ce90791a284377", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_DateTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\DateTime.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(69, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(75, 8, true);
            WriteLiteral("Unknown\n");
            EndContext();
#line 6 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\DateTime.cshtml"
}
else
{
    if (ViewData.ModelMetadata.IsNullableValueType)
    {

#line default
#line hidden
            BeginContext(150, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(162, 25, false);
#line 11 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\DateTime.cshtml"
      Write(Model.Value.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(188, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 12 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\DateTime.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(210, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(222, 31, false);
#line 15 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\DateTime.cshtml"
      Write(((DateTime)Model).ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(254, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 16 "C:\Users\arnol\source\repos\SpyStore\SpyStore.MVC\SpyStore.MVC\Views\Shared\DisplayTemplates\DateTime.cshtml"
    }
}

#line default
#line hidden
            BeginContext(263, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime?> Html { get; private set; }
    }
}
#pragma warning restore 1591
