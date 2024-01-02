// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazorwasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/_Imports.razor"
using Blazorwasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazor.Diagrams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazor.Diagrams.Core.Anchors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazor.Diagrams.Core.Geometry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazor.Diagrams.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazor.Diagrams.Core.PathGenerators;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazor.Diagrams.Core.Routers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazor.Diagrams.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazor.Diagrams.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazorwasm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
using Blazorwasm.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/workspace")]
    public partial class Workspace : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/zhangyuanpu/Documents/CSharp/Blazorwasm/Pages/Workspace.razor"
       
    private BlazorDiagram Diagram { get; set; } = null!;

    protected override void OnInitialized()
    {
        var options = new BlazorDiagramOptions
        {
            AllowMultiSelection = true,
            Zoom =
            {
                Enabled = false,
            },
            Links =
            {
                DefaultRouter = new NormalRouter(),
                DefaultPathGenerator = new SmoothPathGenerator()
            },
        };

        Diagram = new BlazorDiagram(options);

        var firstNode = new Table();
        var secondNode = new Table();
        Diagram.Nodes.Add(new[] { firstNode, secondNode });
        
        var leftPort = secondNode.AddPort(PortAlignment.Left);
        var rightPort = secondNode.AddPort(PortAlignment.Right);

        // The connection point will be the intersection of
        // a line going from the target to the center of the source
        var sourceAnchor = new ShapeIntersectionAnchor(firstNode);
        // The connection point will be the port's position
        var targetAnchor = new SinglePortAnchor(leftPort);

        var node1 = NewNode();
        
        var link = Diagram.Links.Add(new LinkModel(node1.GetPort(PortAlignment.Right), targetAnchor));
    }

    private void AddNode()
    {
        var newnode = Diagram.Nodes.Add(new Table());
        var LeftPort = newnode.AddPort(PortAlignment.Left);
        var RightPort = newnode.AddPort(PortAlignment.Right);
        var TopPort = newnode.AddPort(PortAlignment.Top);
        var BottomPort = newnode.AddPort(PortAlignment.Bottom);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
