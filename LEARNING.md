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
Adjacency lists? Not C# specific but came across this term. Basically just a graph representation with vertices(nodes) and edges(lines connecting these nodes) using List<T>. There are other ways to implement a graph but out of the scope of BFS implementation as of now. Look into Hashsets if there's time and see if they could be better for this use case? So far unsure as this BFS uses sequential integer data but what if data was different? Anyway, in the case of an undirected graph represented using List<T> the number of unique nodes is basically the number of nested rows/list in the data structure and not the total number of elements.

**Syntax specific**
Classes nested inside a component's code block need to be instantiated manually.
Inheritance
So far, I have used direct instantiation by the parent component in the case of where there's a relationship. Otherwise, it can be instantiated in the on parameters set call where the child can build its own class.
**General**
Still getting the hang of syntax, language is more verbose but have made some progress. Have tried minimizing use of AI - trying to read through stackoverflow and blogs like the good old days.

## Bibliography

Blazor Render Tree: https://blazor-university.com/components/render-trees/
Virtual vs Direct DOM manipulation: https://dev.to/lalitkhu/rethinking-the-virtual-dom-a-case-for-direct-dom-manipulation-in-modern-web-development-1nhp
Implementing a binary tree in Blazor: https://ssojet.com/data-structures/implement-binary-tree-in-blazor#setting-up-the-blazor-project-and-basic-node-structure
Rationale for not using external diagramming libraries:
HashSet: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-10.0
List<T>: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-10.0
Force Directed Graph Drawing: https://en.wikipedia.org/wiki/Force-directed_graph_drawing
https://www.yworks.com/pages/force-directed-graph-layout#examples
https://cs.brown.edu/people/rtamassi/gdhandbook/chapters/force-directed.pdf
px, rem and em: https://www.joshwcomeau.com/css/surprising-truth-about-pixels-and-accessibility/

Personal Notes: Force Directed Graph Drawing
Code in graph.razor was dumped by google AI. Was looking up how to render graphs with some sort of consistency and accurate edge mapping.
Going through the code. The first pass is extracting nodes and the second one is extracting edges. Edge tracker is preventing duplicate edgekeys. The conditional block to check if an edgekey exists in edge tracker is redundant (I think) as edge tracker is a hashset. Has been removed at this scale there probably isn't much of an improvement in performance but for a bigger graphs computing a hash and checking for duplicates under the hood could affect performance.
