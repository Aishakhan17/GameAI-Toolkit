namespace GameAIToolkit.Client.Components.UI.Graphs;

public partial class ForceDirectedGraph
{


    private Dictionary<string, Node> Nodes = new();
    private List<TreeEdge.Edge> Edges = new();
    private bool ParseInput()
    {
        //bool value to track if raw input has been parsed successfully
        var parsed = false;
        Nodes.Clear();
        Edges.Clear();

        var lines = rawInput.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        var random = new Random(42);

        CreateNodesAndEdges(lines, random);
        return parsed;
    }
    private void CreateNodesAndEdges(string[] lines, Random random)
    {
        CreateNodes(lines, random);
        CreateEdges(lines, random);
        RunForceDirectedGraphLayout();
    }
    private void CreateNodes(string[] lines, Random random)
    {
        foreach (var line in lines)
        {
            var parts = line.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (parts.Length <1) continue;
            string sourceId = parts[0];
            if (!Nodes.ContainsKey(sourceId))
            {
                var newNode = new Node
                {
                    Id  = sourceId,
                    X = (Width/2) + (random.NextDouble() + 0.5)*40,
                    Y = (Height/2) + (random.NextDouble() + 0.5)*40

                };
                Nodes[sourceId] = newNode;
            };
        }
    }
    private void CreateEdges(string[] lines, Random random)
    {
        var edgeTracker = new HashSet<string>();
        foreach (var line in lines)
        {
            var parts = line.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);   

            if (parts.Length < 2) continue;
            var sourceId = parts[0];
            var targets = parts[1].Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            foreach (var target in targets)
            {
                var targetId = target;
                if (!Nodes.ContainsKey(targetId)) {
                    var newNode = new Node
                    {
                        Id = targetId,
                        X = (Width/2)+(random.NextDouble() + 0.5)*40,
                        Y = (Height/2)+(random.NextDouble() + 0.5)*40
                    };
                    Nodes[targetId] = newNode; 
                }
                var edgeKey = string.Compare(sourceId, targetId) < 0 ? $"{sourceId}-{targetId}":$"{targetId}-{sourceId}";
                if (edgeTracker.Add(edgeKey))
                {
                    var newEdge = new TreeEdge.Edge
                    {
                        Source = sourceId,
                        Target = targetId
                    };    
                    Edges.Add(newEdge);
                }

            }
        }


    }
    private void RunForceDirectedGraphLayout()
    {
        if (Nodes.Count <= 0) return;
        int iterations = 250; 

        //ideal distance between connected mesh components 
        double k = Math.Sqrt((Width*Height) / Nodes.Count)*0.75;

        //starting temperature 
        double temperature = Width/10.0; 

        //cooling factor
        double coolingFactor = temperature/iterations;   ///Can tweak and experiment with this cooling factor

        for (int iter = 0; iter < iterations; iter++)
        {
            //set all node displacement vectors to zero at the start
            foreach (var node in Nodes.Values)
            {
                node.Fx = 0;
                node.Fy = 0;
            }


            var nodeList = Nodes.Values.ToList();
            for (int i = 0; i< nodeList.Count; i++)
            {
                for (int j = i +1; j< nodeList.Count; j++)
                {
                    var u = nodeList[i];
                    var v = nodeList[j];

                    //v.pos - u.pos
                    double dx = v.X - u.X;
                    double dy = v.Y - u.Y;

                    //calculate (euclidean) distance or | Δ |
                    double distance = Math.Sqrt(dx*dx + dy*dy);

                    if (distance < 0.1) distance = 0.1;  //prevent 0 division

                    //repulsion formula
                    double repulsionForce = -(k*k)/distance;
                    double fx = (dx/distance) * repulsionForce;
                    double fy = (dy/distance) * repulsionForce;

                    //update displacement?

                    u.Fx += fx;
                    u.Fy += fy;

                    v.Fx -= fx;
                    v.Fy -= fy;



                }
            }
            //Apply attractive forces: Hooke's law of spring attraction 
        foreach (var edge in Edges)
        {
            var u = Nodes[edge.Source];
            var v = Nodes[edge.Target];   

            double dx = v.X-u.X; 
            double dy = v.Y-u.Y;

            double distance = Math.Sqrt(dx*dx + dy*dy);
            if (distance < 0.1) distance = 0.1;
            double attractionForce = (distance*distance)/k;

            double fx = (dx/distance)*attractionForce;
            double fy = (dy/distance)*attractionForce;

            u.Fx += fx;
            u.Fy += fy;

            v.Fx -= fx;
            v.Fy -= fy;

        }

        foreach (var node in Nodes.Values)
        {
            var distance = Math.Sqrt(node.Fx*node.Fx+node.Fy*node.Fy);
            if (distance < 0.1) continue;
            var limitDisplacement = Math.Min(distance, temperature);
            node.X += (node.Fx/distance)*limitDisplacement;
            node.Y += (node.Fy/distance)*limitDisplacement;

            //enforce safety boundary
            // @* node.X = Math.Min(25, Math.Max(Width/2, node.X));
            // node.Y = Math.Min(25, Math.Max(Height/2, node.Y)); *@

            node.X = Math.Max(25, Math.Min(Width - 25, node.X));
            node.Y = Math.Max(25, Math.Min(Height - 25, node.Y));
        }

            temperature -= coolingFactor;
            if (temperature <= 0) break;
            
        }

    }
}
