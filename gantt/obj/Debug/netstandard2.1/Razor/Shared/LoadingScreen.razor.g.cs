#pragma checksum "D:\test\gantt\gantt\Shared\LoadingScreen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2b1786ee2b931f4f0f2e794bebde5b7c907d381"
// <auto-generated/>
#pragma warning disable 1591
namespace gantt.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\test\gantt\gantt\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\test\gantt\gantt\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\test\gantt\gantt\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\test\gantt\gantt\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\test\gantt\gantt\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\test\gantt\gantt\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\test\gantt\gantt\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\test\gantt\gantt\_Imports.razor"
using gantt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\test\gantt\gantt\_Imports.razor"
using gantt.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\test\gantt\gantt\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\test\gantt\gantt\Shared\LoadingScreen.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\test\gantt\gantt\Shared\LoadingScreen.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
    public partial class LoadingScreen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\test\gantt\gantt\Shared\LoadingScreen.razor"
 if (isLoaded)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "D:\test\gantt\gantt\Shared\LoadingScreen.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "D:\test\gantt\gantt\Shared\LoadingScreen.razor"
                 
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div class=\"d-flex justify-content-center\">\r\n        <div class=\"spinner-border\" role=\"status\">\r\n            <span class=\"sr-only\">Loading...</span>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "D:\test\gantt\gantt\Shared\LoadingScreen.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\test\gantt\gantt\Shared\LoadingScreen.razor"
       
    bool isLoaded;
   
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(4000); // TODO actual initialization job
        isLoaded = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
