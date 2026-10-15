namespace GameAIToolkit.Client.Components.UI.Graphs;


public partial class Bfs
{
    static List<int> bfs(List<List<int>> input, int numNodes) 
        {
        //numNodes = adj.Count;
        //initialize an array of bools set to false that will be changes to true when the node is visited 
        bool[] visited = new bool[numNodes];
        //initialize a queue to implement fifo *@
        Queue<int> myQueue = new();
        //initialize a list to hold the nodes in order of traversal 
        List<int> result = new List<int>();

        //initialize a pointer to traverse the input
        int src = 0;
        visited[src] = true;
        myQueue.Enqueue(src);

        while (myQueue.Count > 0) {
            int current = myQueue.Dequeue();
            Console.WriteLine($"current {current}");
            result.Add(current);

            // @* foreach (x in input[current])
            // {
            //     if (!visited[x]) {
            //         visited[x] = true;
            //         myQueue.Enqueue(x);   
            //     }
            // } *@
        }
        foreach (int i in result)
        {
            Console.WriteLine($"i {i}");
        }
        return result;
    }
}