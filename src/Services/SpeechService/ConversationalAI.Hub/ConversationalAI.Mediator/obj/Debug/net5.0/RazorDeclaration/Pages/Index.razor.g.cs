// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ConversationalAI.Mediator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using ConversationalAI.Mediator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/_Imports.razor"
using ConversationalAI.Mediator.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/Pages/Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/akrish/Documents/code/ConversationalAI.Hub/ConversationalAI.Mediator/Pages/Index.razor"
       
    private HubConnection? _hubConnection;
    private readonly List<string> _messages = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/conversationalhub"))
            .Build();

        _hubConnection.On<string, string, string, string>("LogReceive", (method, user, message, originalMessage) =>
        {
            var encodedMsg = $"method: {method}, {user}: {message}, original message: {originalMessage}";
            _messages.Add(encodedMsg);
            StateHasChanged();
        });

        if (_hubConnection != null) await _hubConnection.StartAsync();
    }

    public bool IsConnected =>
        _hubConnection?.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        if (_hubConnection is not null)
        {
            await _hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
