namespace GameAIToolkit.Client.Components.UI.Graphs;
public partial class Node
    {
        public required string Id {get;set;} = string.Empty;
        //Visual Coordinates of each Node
        public double X {get; set;} 
        public double Y {get; set;}

        //Vector Force Fields 
        public double Fx {get; set;}
        public double Fy {get; set;}

        public bool Visited { get; set; }

    }