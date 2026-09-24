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

**Blazor Render Tree**
Blazor creates its virtual DOM in its razor views using a virtual methon named BuildRenderTree
**Blazor Components**
Blazor components are .NET classes that represent a reusable piece of UI. Each component maintains its own state and specifies its own rendering logic, which can include rendering other components. Components specify event handlers for specific user interactions to update the component's state.
After a component handles an event, Blazor renders the component and keeps track of what changed in the rendered output. Components don't render directly to the Document Object Model (DOM). They instead render to an in-memory representation of the DOM called a RenderTree so that Blazor can track the changes. Blazor compares the newly rendered output with the previous output to calculate a UI diff that it then applies efficiently to the DOM.

**Data Structures**
List vs Arrays: Arrays are fixed size while Lists can grow dynamically.
Adjacency lists? Not C# specific but came across this term. Basically just a graph representation with vertices(nodes) and edges(lines connecting these nodes). Used in Tree Search Algos

## Bibliography

Blazor Render Tree: https://blazor-university.com/components/render-trees/
Virtual vs Direct DOM manipulation: https://dev.to/lalitkhu/rethinking-the-virtual-dom-a-case-for-direct-dom-manipulation-in-modern-web-development-1nhp
Implementing a binary tree in Blazor: https://ssojet.com/data-structures/implement-binary-tree-in-blazor#setting-up-the-blazor-project-and-basic-node-structure
Rationale for not using external diagramming libraries:
