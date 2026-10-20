namespace GameAIToolkit.Client.Components.Data;

public partial class AlgorithmData {
    public static readonly Dictionary<string, Dictionary<string, string>> AlgorithmTopicsList = new()
    {
        {
            "Data Structures", new()
            {
                {"Array List", "/algorithms/data-structures/array-list"},
                {"Linked Lists", "/algorithms/data-structures/linked-list"},
                {"Doubly Linked Lists", "/algorithms/data-structures/doubly-linked-list"},
                {"Heap", "/algorithms/data-structures/heap"},
                {"Stack", "/algorithms/data-structures/stack"},
                {"Queue","/algorithms/data-structures/queue"},
            }
        },
        {
            "Search Algorithms", new()
            {
                {"Monte Carlo Tree Search", "/algorithms/search-algorithms/mcts"},
                {"Minimax", "/algorithms/search-algorithms/minimax"}
            }
        },
        {
            "Pathfinding Algorithms", new()
            {
                {"A Star Search", "/algorithms/pathfinding-algorithms/astar"},
                {"Breadth First Search", "/algorithms/pathfinding-algorithms/bfs"},
                {"Depth First Search", "/algorithms/pathfinding-algorithms/dfs"},
                {"Djikstra's Algorithm", "/algorithms/pathfinding-algorithms/djikstra"},
            }
        },
        {
            "Optimization Algorithms", new()
            {
                {"Simmulated Annealing", "/algorithms/optimization-algorithms/simmulated-annealing"}
            }
        },
        {
            "Graph Drawing Algorithms", new()
            {
                {"Force Directed Graphs", "/algorithms/graph-drawing-algorithms/force-directed-graph"}
            }
        }
    };
    

}