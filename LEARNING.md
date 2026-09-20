## Stuff I have learnt as I learn C# and Blazor

### Render Modes in Blazor

Interactive Server, Interactive WebAssembly and InteractiveAuto
For apps that implement interactive client side (webassembly or auto) and implement render mode via the Routes component and move layout and navigation files to
.Client folder. i.e. Pages and Layout files need to be moved to Client side. Each will need its own \_Import.razor to manage namespaces.
If setting render mode via Routes, add it to Headoutlet as well [https://learn.microsoft.com/en-us/aspnet/core/blazor/components/render-modes?view=aspnetcore-10.0]
**Propagation:**
Render modes propagate down the component hierarchy. Child components inherit the render mode of their parent.
**Hierarchy Restriction:**
A child component cannot switch to a different interactive render mode than its parent.
