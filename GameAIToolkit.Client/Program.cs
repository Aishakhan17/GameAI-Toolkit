using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// {
//     options.PopoverOptions.ThrowOnDuplicateProvider = false;
// });  
await builder.Build().RunAsync();
