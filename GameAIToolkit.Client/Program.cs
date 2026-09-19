using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddMudServices(options =>

{
    options.PopoverOptions.ThrowOnDuplicateProvider = false;
});  
await builder.Build().RunAsync();
